using Dapper;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace KlassenAdministratieDevOps
{
    public class DatabaseManager
    {

        /** 
         * Creates a new connection to the SQLite database. 
         * */
        public IDbConnection GetDBConnection()
        {
            return new SqliteConnection(@"Data Source=.\devops.db;");
        }

        /**
         * Create the tables, students, classes and grades
         */
        public void CreateTable()
        {
            using IDbConnection db = GetDBConnection();
            db.Execute("CREATE TABLE IF NOT EXISTS students (name VARCHAR(64), age INT, className VARCHAR(64))");
            db.Execute("CREATE TABLE IF NOT EXISTS classes (className VARCHAR(64), fieldOfStudy VARCHAR(64), teacherName VARCHAR(64))");
            db.Execute("CREATE TABLE IF NOT EXISTS grades (studentName VARCHAR(64), subject VARCHAR(32), grade FLOAT)");
            db.Execute("CREATE TABLE IF NOT EXISTS teachers (teacherName VARCHAR(64), teacherAge INT, className VARCHAR(64))");
        }


        /**
         * Returns a class with the name <param name="name"></param>.
         * Will return null if it doesn't exist.
         */
        public Class GetClassByName(String name)
        {
            using IDbConnection db = GetDBConnection();
            return db.Query<Class>("SELECT * FROM classes WHERE className = @className", new { className = name }).ToList()[0];
        }

        /**
         * Sets the grade to <param name="grade"></param> for the subject.
         * <param name="subject"></param> for the student <param name="student"></param>
         */
        public void SetGrade(Student student, Double grade, Subject subject)
        {
            using IDbConnection db = GetDBConnection();

            bool exists = db.ExecuteScalar<bool>("SELECT COUNT(1) FROM grades WHERE subject=@subject & studentName = @studentName", new { subject = subject.ToString(), studentName = student.Name });
            // if the grade already exists, we simply update the value
            if (exists)
            {
                db.Execute(
                "UPDATE grades SET grade = @grade WHERE subject = @subject & studentName = @studentName",
                new { studentName = student.Name, grade = grade, subject = subject.ToString() });
            }
            else
            {
                // else we insert it
                db.Execute(
                     "INSERT INTO grades (studentName, subject, grade) VALUES (@studentName, @subject, @grade)",
                new { studentName = student.Name, grade = grade, subject = subject.ToString() }
                 );
            }
        }

        /**
         * Returns the grades for <param name="student"></param>
         */
        public Dictionary<Subject, Double> GetGrades(Student student)
        {
            using IDbConnection db = GetDBConnection();
            Dictionary<Subject, Double> grades = new Dictionary<Subject, double>();
            try
            {
                var res = db.Query(
                     "SELECT * FROM grades WHERE studentName = @studentName",
                     new { studentName = student.Name }
                     );

                // Here we have all results in the DB
                // This could potentially not contain all subjects (since we default to 0)
                // So we need to find out all the subjects that are not in the DB, and add them with the default grade
                // Else it will get lost
                foreach (var item in res)
                {
                    grades.TryAdd(Enum.Parse<Subject>(item.subject), item.grade);
                }

                List<Subject> notExisting = Enum.GetValues(typeof(Subject)).Cast<Subject>().ToList().Except(grades.Keys).ToList();
                // Put all the grades that are not yet updated into the database with the defautl value
                notExisting.ForEach(notExisting =>
                {
                    grades.TryAdd(notExisting, 0);
                });

                // Sort it so it's consistent
                return grades.OrderBy(entry => entry.Key).ToDictionary(x => x.Key, x => x.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                // Give everyone 0 for their grades since its a new student.
                foreach (Subject s in Enum.GetValues(typeof(Subject)))
                {
                    grades.TryAdd(s, 0);
                }
                return grades;
            }
        }

        /**
         * Adds a new teacher <param name="teacher"></param>  to the database
         */
        public void AddTeacher(Teacher teacher)
        {
            if (!DoesTeacherExist(teacher.Name))
            {
                using IDbConnection db = GetDBConnection();
                db.Execute(
                    "INSERT INTO teachers (teacherName, teacherAge, className) VALUES (@name, @age, @className)",
                    new { name = teacher.Name, age = teacher.Age, className = teacher.ClassName }
                    );
            }
        }

        /**
         * Checks whether a teacher already has a class/exists
         */
        private Boolean DoesTeacherExist(String teacherName)
        {
            using IDbConnection db = GetDBConnection();
            return db.ExecuteScalar<bool>("SELECT COUNT(1) FROM teachers WHERE teacherName=@name", new { name = teacherName });

        }
        /**
         * Gets the teacher that belongs to <param name="c"></param>
         * Will return null if no such teacher exists.
         */
        public Teacher GetTeacherFromClass(Class c)
        {
            using IDbConnection db = GetDBConnection();
            return db.Query<Teacher>("SELET * FROM teachers WHERE className = @className", new { className = c.ClassName }).First();
        }

        /**
         * Add a class <param name="c"></param> to the database.
         */
        public void AddClass(Class c)
        {
            using IDbConnection db = GetDBConnection();
            db.Execute(
                "INSERT INTO classes (className, fieldOfStudy, teacherName) VALUES (@className, @fieldOfStudy, @teacherName)",
                new { className = c.ClassName, fieldOfStudy = c.FieldOfStudy, teacherName = c.TeacherName}
                );
        }

        /**
         * Adds the student <param name="student"></param> to the database.
         */
        public void AddStudent(Student student)
        {
            using IDbConnection db = GetDBConnection();
            db.Execute(
                "INSERT INTO students (name, age, className) VALUES (@name, @age, @className)",
                new { name = student.Name, age = student.Age, className = student.ClassName }
                );
        }

        /**
         * Checks whether <param name="student"></param> is in the class <param name="c"></param> 
         */
        public Boolean IsStudentInClass(Student student, Class c)
        {
            using IDbConnection db = GetDBConnection();
            foreach (Student s in GetAllStudentsFromClass(c))
            {
                if (s.Name == student.Name) { return true; }
            }
            return false;
        }


        /**
         * Checks whether a student with the name <param name="name"></param> exists.
         */
        public Boolean DoesStudentExist(String name)
        {
            using IDbConnection db = GetDBConnection();
            return db.ExecuteScalar<bool>("SELECT COUNT(1) FROM students WHERE name=@name", new { name = name });
        }

        /**
         * Removes a student <param name="student"></param> student from the database.
         */
        public void RemoveStudent(Student student)
        {
            using IDbConnection db = GetDBConnection();
            db.Execute("DELETE FROM students WHERE name = @studentName", new { studentName = student.Name });
        }

        /**
         * Returns a student with the name <param name="name"></param>.
         * Will return null if there is no such student.
         */
        public Student GetStudentByName(string name)
        {
            using IDbConnection db = GetDBConnection();
            return db.Query<Student>("SELECT * FROM students WHERE name = @name", new { name = name }).ToList()[0];
        }

        /**
         * Returns all the students that belong to the class <param name="c"></param>
         */
        public List<Student> GetAllStudentsFromClass(Class c)
        {
            using IDbConnection db = GetDBConnection();
            if (DoesClassHaveStudents(c))
            {
                return db.Query<Student>("SELECT * FROM students WHERE className = @className", new { className = c.ClassName }).ToList();
            }
            else return new List<Student>();
        }

        /**
         * Returns whether the class <param name="c"></param> has any students in it or not/
         */
        public Boolean DoesClassHaveStudents(Class c)
        {
            using IDbConnection db = GetDBConnection();
            return db.ExecuteScalar<bool>("SELECT COUNT(1) FROM students WHERE className=@className", new { className = c.ClassName });
        }
        /**
         * Returns a list of all classes.
         */
        public List<Class> GetAllClasses()
        {
            using IDbConnection db = GetDBConnection();
            return db.Query<Class>("SELECT * FROM classes").ToList();
        }

        /**
         * Returns whether a class with the name <param name="className"></param> exists.
         */
        public Boolean DoesClassExist(String className)
        {
            using IDbConnection db = GetDBConnection();
            return db.ExecuteScalar<bool>("SELECT COUNT(1) FROM classes WHERE className=@className", new { className = className });
        }
    }
}

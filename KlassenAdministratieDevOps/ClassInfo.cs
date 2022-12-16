using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using KlassenAdministratieDevOps;

namespace KlassenAdministratieDevOps
{
    public partial class ClassInfo : Form
    {

        // The class we are viewing
        private Class ViewingClass;
        // The original form we can get all the manager classes from
        public Form1 OriginalForm { get; }

        public ClassInfo(Class ViewingClass, Form1 OriginalForm)
        {
            InitializeComponent();
            this.ViewingClass = ViewingClass;
            this.OriginalForm = OriginalForm;
        }



        private void btn_add_student_Click(object sender, EventArgs e)
        {
            try
            {
                String studentName = txt_student_name.Text;
                int age = int.Parse(txt_student_age.Text);
                DatabaseManager db = this.OriginalForm.DatabaseContext;

                if (!db.DoesStudentExist(studentName))
                {
                    db.AddStudent(new Student(studentName, age, this.ViewingClass.ClassName));
                    StudentList.Items.Add(studentName);
                    txt_student_age.Text = "";
                    txt_student_name.Text = "";
                    return;
                }
                else
                {
                    MessageBox.Show("This student is already in a class!");
                }

            }
            catch (FormatException)
            {
                MessageBox.Show("Please provide a valid age!");
            }

        }

        private void btn_remove_student_Click(object sender, EventArgs e)
        {
            DatabaseManager db = this.OriginalForm.DatabaseContext;


            String studentName = txt_student_name.Text;
            
            if (!db.DoesStudentExist(studentName))
            {
                MessageBox.Show("This student does not exist!");
                return;
            }
            else
            {
                Student stud = db.GetStudentByName(studentName);
                db.RemoveStudent(stud);
                StudentList.Items.Remove(stud.Name);
            }

        }
    

        private void ClassInfo_Load(object sender, EventArgs e)
        {
            foreach (Student Student in OriginalForm.DatabaseContext.GetAllStudentsFromClass(ViewingClass))
            {
                StudentList.Items.Add(Student.Name);
            }
            lbl_viewing_class.Text += ViewingClass.ClassName;
            lbl_teacher.Text += ViewingClass.TeacherName;
            lbl_field_of_study.Text += " " + ViewingClass.FieldOfStudy;
        }

        private void StudentList_SelectedIndexChanged(object sender, EventArgs e)
        { DatabaseManager db = this.OriginalForm.DatabaseContext;
;            if (StudentList.SelectedItem == null) return;
            String name = StudentList.SelectedItem.ToString();
            if (db.DoesStudentExist(name))
            {
                new StudentInfo(db.GetStudentByName(name), this, ViewingClass).Show();
                this.Hide();
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.OriginalForm.Show();
            this.Hide();
        }
    }
}

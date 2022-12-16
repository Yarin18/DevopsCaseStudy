using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KlassenAdministratieDevOps
{
    public partial class StudentInfo : Form
    {

        private Student ViewingStudent;
        private ClassInfo ClassInfo;
        private Class ViewingClass;

        public StudentInfo(Student viewingStudent, ClassInfo classInfo, Class viewingClass)
        {
            InitializeComponent();
            this.ViewingStudent = viewingStudent;
            this.ClassInfo = classInfo;
            this.ViewingClass = viewingClass;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.ClassInfo.Show();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.ClassInfo.Hide();
            this.ClassInfo.OriginalForm.Show();

        }

        private void StudentInfo_Load(object sender, EventArgs e)
        {
            DatabaseManager db = this.ClassInfo.OriginalForm.DatabaseContext;

            // load the student grades
            ViewingStudent.Grades = db.GetGrades(ViewingStudent);

            // load in and display all grades
            foreach (KeyValuePair<Subject, Double> grade in this.ViewingStudent.Grades)
            {
                Grades.Items.Add("- " + Form1.ConvertSubjectToPrettyName(grade.Key) + ": " + grade.Value + "\n");
            }
            // list all subjects
            foreach (Subject s in Enum.GetValues(typeof(Subject)))
            {
                Subjects.Items.Add(Form1.ConvertSubjectToPrettyName(s) + "\n");
            }


            lbl_class.Text += " " + ViewingClass.ClassName;
            lbl_viewing_student.Text += " " + ViewingStudent.Name;
            //lbl_overall_avg_grade.Text += " " + ViewingStudent.Grades.Values.Average();

        }

        private void btn_update_grades_Click(object sender, EventArgs e)
        {
            try
            {
                DatabaseManager db = this.ClassInfo.OriginalForm.DatabaseContext;
                Double grade = Double.Parse(txt_grade.Text);
                Subject subject = Enum.Parse<Subject>(txt_subject.Text.ToUpper());
                db.SetGrade(ViewingStudent, grade, subject);
                UpdateGradeList(txt_subject.Text, grade);

                txt_subject.Text = "";
                txt_grade.Text = "";

            }
            catch
            {
                MessageBox.Show("Please provide a valid input for the grades and subjects");
            }
        }
        /**
         * Updates the grade <param name="grade"></param> to the value <param name="value"></param>
         */
        private void UpdateGradeList(String grade, Double value) 
        {

            foreach (String item in Grades.Items)
            {
                if (item.Contains(grade, StringComparison.CurrentCultureIgnoreCase))
                {
                    int index = Grades.Items.IndexOf(item);
                    Grades.Items.RemoveAt(index);
                    Grades.Items.Insert(index, "- " + Form1.ConvertSubjectToPrettyName(Enum.Parse<Subject>(grade.ToUpper())) + ": " + value + "\n");
                    break;
                }
            }

        }
    }
}

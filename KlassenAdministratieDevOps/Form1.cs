using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KlassenAdministratieDevOps
{
    public partial class Form1 : Form
    {
        public DatabaseManager DatabaseContext { get; } = new DatabaseManager();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DatabaseContext.CreateTable();

            foreach (Class c in DatabaseContext.GetAllClasses())
            {
                ClassList.Items.Add(c.ClassName);
            }
        }

        private void btn_add_class_Click(object sender, EventArgs e)
        {
            String className = txt_class_name.Text;
            String fieldOfStudy = txt_field_of_study.Text;

            String teacherName = txt_teacher_name.Text;
            int teacherAge;

            if (!int.TryParse(txt_teacher_age.Text, out teacherAge))
            {
                MessageBox.Show("Please provide a valid age for the teacher!");
                return;
            }

            if (className == "" || fieldOfStudy == "" || teacherName == "" || txt_teacher_age.Text == "")
            {
                MessageBox.Show("Please fill in all the boxes!");
                return;
            }
            else
            {
                
                if (DatabaseContext.DoesClassExist(className))
                {
                    MessageBox.Show("A Class with this name already exists!");
                }
                else
                {
                    txt_field_of_study.Text = "";
                    txt_class_name.Text = "";
                    txt_teacher_age.Text = "";
                    txt_teacher_name.Text = "";

                    // Add the class to the listbox
                    Teacher teacher = new Teacher(teacherName, teacherAge, className);
                    Class newClass = new Class(className, fieldOfStudy, teacher.Name);
                    DatabaseContext.AddTeacher(teacher);
                    DatabaseContext.AddClass(newClass);  
                    ClassList.Items.Add(className);
                }
            }
        }
        /**
         * Returns the pretty name of the Subject <param name="S"></param>
         */
        public static String ConvertSubjectToPrettyName(Subject S)
        {
            String PrettyName = "";

            switch (S)
            {
                case Subject.MATH:
                    PrettyName = "Math";
                    break;
                case Subject.JAVA:
                    PrettyName = "Java";
                    break;
                case Subject.ENGLISH:
                    PrettyName = "English";
                    break;
                case Subject.DEVOPS:
                    PrettyName = "DevOps";
                    break;
                case Subject.SPANISH:
                    PrettyName = "Spanish";
                    break;
                default:
                    PrettyName = "Unknown Subject";
                    break;
            }
            return PrettyName;
        }

        private void ClassList_SelectedIndexChanged(object sender, EventArgs e)
        {
             if (ClassList.SelectedItem == null) return;

            Class SelectedClass = this.DatabaseContext.GetClassByName(ClassList.SelectedItem.ToString());

            if (SelectedClass == null)
            {
                MessageBox.Show("Something went wrong!");
            }
            else
            {
                this.Hide();
                new ClassInfo(SelectedClass, this).Show();
            }
        }
    }
}
/**
 * Enum class representing Subjects.
 */
public enum Subject
{
    MATH,
    ENGLISH,
    JAVA,
    DEVOPS,
    SPANISH
}
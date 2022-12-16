namespace KlassenAdministratieDevOps
{
    partial class StudentInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_class = new System.Windows.Forms.Label();
            this.lbl_viewing_student = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_home = new System.Windows.Forms.Button();
            this.txt_subject = new System.Windows.Forms.TextBox();
            this.txt_grade = new System.Windows.Forms.TextBox();
            this.btn_update_grades = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Subjects = new System.Windows.Forms.ListBox();
            this.Grades = new System.Windows.Forms.ListBox();
            this.lbl_overall_avg_grade = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_class
            // 
            this.lbl_class.AutoSize = true;
            this.lbl_class.Location = new System.Drawing.Point(151, 9);
            this.lbl_class.Name = "lbl_class";
            this.lbl_class.Size = new System.Drawing.Size(45, 20);
            this.lbl_class.TabIndex = 0;
            this.lbl_class.Text = "Class:";
            // 
            // lbl_viewing_student
            // 
            this.lbl_viewing_student.AutoSize = true;
            this.lbl_viewing_student.Location = new System.Drawing.Point(12, 9);
            this.lbl_viewing_student.Name = "lbl_viewing_student";
            this.lbl_viewing_student.Size = new System.Drawing.Size(67, 20);
            this.lbl_viewing_student.TabIndex = 1;
            this.lbl_viewing_student.Text = "Student: ";
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(359, 449);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(94, 29);
            this.btn_back.TabIndex = 3;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_home
            // 
            this.btn_home.Location = new System.Drawing.Point(487, 449);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(94, 29);
            this.btn_home.TabIndex = 4;
            this.btn_home.Text = "Home";
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // txt_subject
            // 
            this.txt_subject.Location = new System.Drawing.Point(350, 191);
            this.txt_subject.Name = "txt_subject";
            this.txt_subject.Size = new System.Drawing.Size(125, 27);
            this.txt_subject.TabIndex = 5;
            // 
            // txt_grade
            // 
            this.txt_grade.Location = new System.Drawing.Point(505, 191);
            this.txt_grade.Name = "txt_grade";
            this.txt_grade.Size = new System.Drawing.Size(125, 27);
            this.txt_grade.TabIndex = 6;
            // 
            // btn_update_grades
            // 
            this.btn_update_grades.Location = new System.Drawing.Point(428, 252);
            this.btn_update_grades.Name = "btn_update_grades";
            this.btn_update_grades.Size = new System.Drawing.Size(121, 52);
            this.btn_update_grades.TabIndex = 7;
            this.btn_update_grades.Text = "Update Grades";
            this.btn_update_grades.UseVisualStyleBackColor = true;
            this.btn_update_grades.Click += new System.EventHandler(this.btn_update_grades_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(377, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Subject";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(539, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Grade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Grades";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(810, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Subjects";
            // 
            // Subjects
            // 
            this.Subjects.FormattingEnabled = true;
            this.Subjects.ItemHeight = 20;
            this.Subjects.Location = new System.Drawing.Point(810, 88);
            this.Subjects.Name = "Subjects";
            this.Subjects.Size = new System.Drawing.Size(232, 344);
            this.Subjects.TabIndex = 13;
            // 
            // Grades
            // 
            this.Grades.FormattingEnabled = true;
            this.Grades.ItemHeight = 20;
            this.Grades.Location = new System.Drawing.Point(20, 88);
            this.Grades.Name = "Grades";
            this.Grades.Size = new System.Drawing.Size(193, 324);
            this.Grades.TabIndex = 14;
            // 
            // lbl_overall_avg_grade
            // 
            this.lbl_overall_avg_grade.AutoSize = true;
            this.lbl_overall_avg_grade.Location = new System.Drawing.Point(304, 9);
            this.lbl_overall_avg_grade.Name = "lbl_overall_avg_grade";
            this.lbl_overall_avg_grade.Size = new System.Drawing.Size(162, 20);
            this.lbl_overall_avg_grade.TabIndex = 15;
            this.lbl_overall_avg_grade.Text = "Overall Average Grade:";
            // 
            // StudentInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 530);
            this.Controls.Add(this.lbl_overall_avg_grade);
            this.Controls.Add(this.Grades);
            this.Controls.Add(this.Subjects);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_update_grades);
            this.Controls.Add(this.txt_grade);
            this.Controls.Add(this.txt_subject);
            this.Controls.Add(this.btn_home);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.lbl_viewing_student);
            this.Controls.Add(this.lbl_class);
            this.Name = "StudentInfo";
            this.Text = "StudentInfo";
            this.Load += new System.EventHandler(this.StudentInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_class;
        private Label lbl_viewing_student;
        private Button btn_back;
        private Button btn_home;
        private TextBox txt_subject;
        private TextBox txt_grade;
        private Button btn_update_grades;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ListBox Subjects;
        private ListBox Grades;
        private Label lbl_overall_avg_grade;
    }
}
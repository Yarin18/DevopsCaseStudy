namespace KlassenAdministratieDevOps
{
    partial class ClassInfo
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
            this.StudentList = new System.Windows.Forms.ListBox();
            this.btn_add_student = new System.Windows.Forms.Button();
            this.btn_remove_student = new System.Windows.Forms.Button();
            this.txt_student_name = new System.Windows.Forms.TextBox();
            this.txt_student_age = new System.Windows.Forms.TextBox();
            this.lbl_viewing_class = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_teacher = new System.Windows.Forms.Label();
            this.lbl_field_of_study = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StudentList
            // 
            this.StudentList.FormattingEnabled = true;
            this.StudentList.ItemHeight = 20;
            this.StudentList.Location = new System.Drawing.Point(573, 84);
            this.StudentList.Name = "StudentList";
            this.StudentList.Size = new System.Drawing.Size(150, 104);
            this.StudentList.TabIndex = 0;
            this.StudentList.SelectedIndexChanged += new System.EventHandler(this.StudentList_SelectedIndexChanged);
            // 
            // btn_add_student
            // 
            this.btn_add_student.Location = new System.Drawing.Point(170, 275);
            this.btn_add_student.Name = "btn_add_student";
            this.btn_add_student.Size = new System.Drawing.Size(109, 42);
            this.btn_add_student.TabIndex = 1;
            this.btn_add_student.Text = "Add Student";
            this.btn_add_student.UseVisualStyleBackColor = true;
            this.btn_add_student.Click += new System.EventHandler(this.btn_add_student_Click);
            // 
            // btn_remove_student
            // 
            this.btn_remove_student.Location = new System.Drawing.Point(378, 275);
            this.btn_remove_student.Name = "btn_remove_student";
            this.btn_remove_student.Size = new System.Drawing.Size(110, 55);
            this.btn_remove_student.TabIndex = 2;
            this.btn_remove_student.Text = "Remove Student";
            this.btn_remove_student.UseVisualStyleBackColor = true;
            this.btn_remove_student.Click += new System.EventHandler(this.btn_remove_student_Click);
            // 
            // txt_student_name
            // 
            this.txt_student_name.Location = new System.Drawing.Point(170, 196);
            this.txt_student_name.Name = "txt_student_name";
            this.txt_student_name.Size = new System.Drawing.Size(125, 27);
            this.txt_student_name.TabIndex = 3;
            // 
            // txt_student_age
            // 
            this.txt_student_age.Location = new System.Drawing.Point(378, 196);
            this.txt_student_age.Name = "txt_student_age";
            this.txt_student_age.Size = new System.Drawing.Size(125, 27);
            this.txt_student_age.TabIndex = 4;
            // 
            // lbl_viewing_class
            // 
            this.lbl_viewing_class.AutoSize = true;
            this.lbl_viewing_class.Location = new System.Drawing.Point(12, 9);
            this.lbl_viewing_class.Name = "lbl_viewing_class";
            this.lbl_viewing_class.Size = new System.Drawing.Size(106, 20);
            this.lbl_viewing_class.TabIndex = 5;
            this.lbl_viewing_class.Text = "Viewing Class: ";
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(600, 373);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(94, 29);
            this.btn_back.TabIndex = 6;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Student Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(378, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Student Age";
            // 
            // lbl_teacher
            // 
            this.lbl_teacher.AutoSize = true;
            this.lbl_teacher.Location = new System.Drawing.Point(12, 84);
            this.lbl_teacher.Name = "lbl_teacher";
            this.lbl_teacher.Size = new System.Drawing.Size(67, 20);
            this.lbl_teacher.TabIndex = 9;
            this.lbl_teacher.Text = "Teacher: ";
            // 
            // lbl_field_of_study
            // 
            this.lbl_field_of_study.AutoSize = true;
            this.lbl_field_of_study.Location = new System.Drawing.Point(12, 46);
            this.lbl_field_of_study.Name = "lbl_field_of_study";
            this.lbl_field_of_study.Size = new System.Drawing.Size(105, 20);
            this.lbl_field_of_study.TabIndex = 10;
            this.lbl_field_of_study.Text = "Field Of Study:";
            // 
            // ClassInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_field_of_study);
            this.Controls.Add(this.lbl_teacher);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.lbl_viewing_class);
            this.Controls.Add(this.txt_student_age);
            this.Controls.Add(this.txt_student_name);
            this.Controls.Add(this.btn_remove_student);
            this.Controls.Add(this.btn_add_student);
            this.Controls.Add(this.StudentList);
            this.Name = "ClassInfo";
            this.Text = "ClassInfo";
            this.Load += new System.EventHandler(this.ClassInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox StudentList;
        private Button btn_add_student;
        private Button btn_remove_student;
        private TextBox txt_student_name;
        private TextBox txt_student_age;
        private Label lbl_viewing_class;
        private Button btn_back;
        private Label label1;
        private Label label2;
        private Label lbl_teacher;
        private Label lbl_field_of_study;
    }
}
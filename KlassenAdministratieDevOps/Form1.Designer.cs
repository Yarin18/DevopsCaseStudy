namespace KlassenAdministratieDevOps
{
    partial class Form1
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
            this.btn_add_class = new System.Windows.Forms.Button();
            this.txt_field_of_study = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ClassList = new System.Windows.Forms.ListBox();
            this.txt_class_name = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_add_class
            // 
            this.btn_add_class.Location = new System.Drawing.Point(268, 292);
            this.btn_add_class.Name = "btn_add_class";
            this.btn_add_class.Size = new System.Drawing.Size(94, 29);
            this.btn_add_class.TabIndex = 0;
            this.btn_add_class.Text = "Add Class";
            this.btn_add_class.UseVisualStyleBackColor = true;
            this.btn_add_class.Click += new System.EventHandler(this.btn_add_class_Click);
            // 
            // txt_field_of_study
            // 
            this.txt_field_of_study.Location = new System.Drawing.Point(404, 196);
            this.txt_field_of_study.Name = "txt_field_of_study";
            this.txt_field_of_study.Size = new System.Drawing.Size(125, 27);
            this.txt_field_of_study.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Choose Class Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(404, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Choose Field Of Study";
            // 
            // ClassList
            // 
            this.ClassList.FormattingEnabled = true;
            this.ClassList.ItemHeight = 20;
            this.ClassList.Location = new System.Drawing.Point(636, 87);
            this.ClassList.Name = "ClassList";
            this.ClassList.Size = new System.Drawing.Size(150, 104);
            this.ClassList.TabIndex = 5;
            this.ClassList.SelectedIndexChanged += new System.EventHandler(this.ClassList_SelectedIndexChanged);
            // 
            // txt_class_name
            // 
            this.txt_class_name.Location = new System.Drawing.Point(120, 196);
            this.txt_class_name.Name = "txt_class_name";
            this.txt_class_name.Size = new System.Drawing.Size(125, 27);
            this.txt_class_name.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_class_name);
            this.Controls.Add(this.ClassList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_field_of_study);
            this.Controls.Add(this.btn_add_class);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_add_class;
        private TextBox txt_field_of_study;
        private Label label1;
        private Label label2;
        private ListBox ClassList;
        private TextBox txt_class_name;
    }
}
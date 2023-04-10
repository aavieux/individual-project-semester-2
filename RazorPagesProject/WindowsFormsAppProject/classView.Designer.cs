namespace WindowsFormsAppProject
{
    partial class classView
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
            listBoxStudentsClass = new ListBox();
            changeClass_btn = new Button();
            changeClass_comboBox = new ComboBox();
            saveChanges_btn = new Button();
            teacherClass_lbl = new Label();
            changeTeacher_comboBox = new ComboBox();
            newClass_lbl = new Label();
            students_lbl = new Label();
            delete_btn = new Button();
            SuspendLayout();
            // 
            // listBoxStudentsClass
            // 
            listBoxStudentsClass.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            listBoxStudentsClass.FormattingEnabled = true;
            listBoxStudentsClass.ItemHeight = 37;
            listBoxStudentsClass.Location = new Point(12, 49);
            listBoxStudentsClass.Name = "listBoxStudentsClass";
            listBoxStudentsClass.Size = new Size(776, 189);
            listBoxStudentsClass.TabIndex = 0;
            // 
            // changeClass_btn
            // 
            changeClass_btn.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            changeClass_btn.Location = new Point(477, 314);
            changeClass_btn.Name = "changeClass_btn";
            changeClass_btn.Size = new Size(277, 109);
            changeClass_btn.TabIndex = 1;
            changeClass_btn.Text = "Change Class";
            changeClass_btn.UseVisualStyleBackColor = true;
            changeClass_btn.Click += changeClass_btn_Click;
            // 
            // changeClass_comboBox
            // 
            changeClass_comboBox.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            changeClass_comboBox.FormattingEnabled = true;
            changeClass_comboBox.Location = new Point(477, 314);
            changeClass_comboBox.Name = "changeClass_comboBox";
            changeClass_comboBox.Size = new Size(277, 45);
            changeClass_comboBox.TabIndex = 2;
            // 
            // saveChanges_btn
            // 
            saveChanges_btn.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            saveChanges_btn.Location = new Point(477, 365);
            saveChanges_btn.Name = "saveChanges_btn";
            saveChanges_btn.Size = new Size(277, 58);
            saveChanges_btn.TabIndex = 3;
            saveChanges_btn.Text = "Save Changes";
            saveChanges_btn.UseVisualStyleBackColor = true;
            saveChanges_btn.Click += saveChanges_btn_Click;
            // 
            // teacherClass_lbl
            // 
            teacherClass_lbl.AutoSize = true;
            teacherClass_lbl.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            teacherClass_lbl.Location = new Point(100, 274);
            teacherClass_lbl.Name = "teacherClass_lbl";
            teacherClass_lbl.Size = new Size(176, 37);
            teacherClass_lbl.TabIndex = 5;
            teacherClass_lbl.Text = "Head Teacher";
            // 
            // changeTeacher_comboBox
            // 
            changeTeacher_comboBox.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            changeTeacher_comboBox.FormattingEnabled = true;
            changeTeacher_comboBox.Location = new Point(55, 314);
            changeTeacher_comboBox.Name = "changeTeacher_comboBox";
            changeTeacher_comboBox.Size = new Size(277, 45);
            changeTeacher_comboBox.TabIndex = 6;
            // 
            // newClass_lbl
            // 
            newClass_lbl.AutoSize = true;
            newClass_lbl.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            newClass_lbl.Location = new Point(555, 274);
            newClass_lbl.Name = "newClass_lbl";
            newClass_lbl.Size = new Size(138, 37);
            newClass_lbl.TabIndex = 7;
            newClass_lbl.Text = "New Class";
            // 
            // students_lbl
            // 
            students_lbl.AutoSize = true;
            students_lbl.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            students_lbl.Location = new Point(332, 9);
            students_lbl.Name = "students_lbl";
            students_lbl.Size = new Size(119, 37);
            students_lbl.TabIndex = 8;
            students_lbl.Text = "Students";
            // 
            // delete_btn
            // 
            delete_btn.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            delete_btn.Location = new Point(637, 9);
            delete_btn.Name = "delete_btn";
            delete_btn.Size = new Size(151, 37);
            delete_btn.TabIndex = 9;
            delete_btn.Text = "Delete";
            delete_btn.UseVisualStyleBackColor = true;
            delete_btn.Click += delete_btn_Click;
            // 
            // classView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(delete_btn);
            Controls.Add(students_lbl);
            Controls.Add(newClass_lbl);
            Controls.Add(changeTeacher_comboBox);
            Controls.Add(teacherClass_lbl);
            Controls.Add(saveChanges_btn);
            Controls.Add(changeClass_comboBox);
            Controls.Add(changeClass_btn);
            Controls.Add(listBoxStudentsClass);
            Name = "classView";
            Text = "classView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxStudentsClass;
        private Button changeClass_btn;
        private ComboBox changeClass_comboBox;
        private Button saveChanges_btn;
        private Label teacherClass_lbl;
        private ComboBox changeTeacher_comboBox;
        private Label newClass_lbl;
        private Label students_lbl;
        private Button delete_btn;
    }
}
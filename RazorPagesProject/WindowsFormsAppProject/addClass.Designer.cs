namespace WindowsFormsAppProject
{
    partial class addClass
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
            addClass_lbl = new Label();
            checkedListBoxStudents = new CheckedListBox();
            addClass_btn = new Button();
            className_lbl = new Label();
            classTeacher_lbl = new Label();
            className_txt = new TextBox();
            classteacher_cb = new ComboBox();
            SuspendLayout();
            // 
            // addClass_lbl
            // 
            addClass_lbl.AutoSize = true;
            addClass_lbl.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            addClass_lbl.Location = new Point(320, 9);
            addClass_lbl.Name = "addClass_lbl";
            addClass_lbl.Size = new Size(133, 37);
            addClass_lbl.TabIndex = 0;
            addClass_lbl.Text = "Add Class";
            // 
            // checkedListBoxStudents
            // 
            checkedListBoxStudents.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            checkedListBoxStudents.FormattingEnabled = true;
            checkedListBoxStudents.Location = new Point(320, 56);
            checkedListBoxStudents.Name = "checkedListBoxStudents";
            checkedListBoxStudents.Size = new Size(468, 382);
            checkedListBoxStudents.TabIndex = 2;
            // 
            // addClass_btn
            // 
            addClass_btn.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            addClass_btn.Location = new Point(12, 367);
            addClass_btn.Name = "addClass_btn";
            addClass_btn.Size = new Size(246, 71);
            addClass_btn.TabIndex = 3;
            addClass_btn.Text = "Add Class";
            addClass_btn.UseVisualStyleBackColor = true;
            addClass_btn.Click += addClass_btn_Click;
            // 
            // className_lbl
            // 
            className_lbl.AutoSize = true;
            className_lbl.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            className_lbl.Location = new Point(12, 56);
            className_lbl.Name = "className_lbl";
            className_lbl.Size = new Size(112, 28);
            className_lbl.TabIndex = 4;
            className_lbl.Text = "Class Name";
            // 
            // classTeacher_lbl
            // 
            classTeacher_lbl.AutoSize = true;
            classTeacher_lbl.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            classTeacher_lbl.Location = new Point(12, 174);
            classTeacher_lbl.Name = "classTeacher_lbl";
            classTeacher_lbl.Size = new Size(125, 28);
            classTeacher_lbl.TabIndex = 5;
            classTeacher_lbl.Text = "Class Teacher";
            // 
            // className_txt
            // 
            className_txt.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            className_txt.Location = new Point(12, 109);
            className_txt.Name = "className_txt";
            className_txt.Size = new Size(298, 34);
            className_txt.TabIndex = 6;
            // 
            // classteacher_cb
            // 
            classteacher_cb.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            classteacher_cb.FormattingEnabled = true;
            classteacher_cb.Location = new Point(12, 225);
            classteacher_cb.Name = "classteacher_cb";
            classteacher_cb.Size = new Size(298, 36);
            classteacher_cb.TabIndex = 7;
            // 
            // addClass
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(classteacher_cb);
            Controls.Add(className_txt);
            Controls.Add(classTeacher_lbl);
            Controls.Add(className_lbl);
            Controls.Add(addClass_btn);
            Controls.Add(checkedListBoxStudents);
            Controls.Add(addClass_lbl);
            Name = "addClass";
            Text = "addClass";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label addClass_lbl;
        private CheckedListBox checkedListBoxStudents;
        private Button addClass_btn;
        private Label className_lbl;
        private Label classTeacher_lbl;
        private TextBox className_txt;
        private ComboBox classteacher_cb;
    }
}
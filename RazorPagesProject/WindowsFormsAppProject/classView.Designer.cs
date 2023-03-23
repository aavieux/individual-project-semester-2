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
            SuspendLayout();
            // 
            // listBoxStudentsClass
            // 
            listBoxStudentsClass.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            listBoxStudentsClass.FormattingEnabled = true;
            listBoxStudentsClass.ItemHeight = 37;
            listBoxStudentsClass.Location = new Point(12, 12);
            listBoxStudentsClass.Name = "listBoxStudentsClass";
            listBoxStudentsClass.Size = new Size(493, 411);
            listBoxStudentsClass.TabIndex = 0;
            // 
            // changeClass_btn
            // 
            changeClass_btn.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            changeClass_btn.Location = new Point(511, 12);
            changeClass_btn.Name = "changeClass_btn";
            changeClass_btn.Size = new Size(277, 58);
            changeClass_btn.TabIndex = 1;
            changeClass_btn.Text = "Change Class";
            changeClass_btn.UseVisualStyleBackColor = true;
            changeClass_btn.Click += changeClass_btn_Click;
            // 
            // changeClass_comboBox
            // 
            changeClass_comboBox.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            changeClass_comboBox.FormattingEnabled = true;
            changeClass_comboBox.Location = new Point(511, 76);
            changeClass_comboBox.Name = "changeClass_comboBox";
            changeClass_comboBox.Size = new Size(277, 45);
            changeClass_comboBox.TabIndex = 2;
            // 
            // saveChanges_btn
            // 
            saveChanges_btn.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            saveChanges_btn.Location = new Point(511, 12);
            saveChanges_btn.Name = "saveChanges_btn";
            saveChanges_btn.Size = new Size(277, 58);
            saveChanges_btn.TabIndex = 3;
            saveChanges_btn.Text = "Save Changes";
            saveChanges_btn.UseVisualStyleBackColor = true;
            saveChanges_btn.Click += saveChanges_btn_Click;
            // 
            // classView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(saveChanges_btn);
            Controls.Add(changeClass_comboBox);
            Controls.Add(changeClass_btn);
            Controls.Add(listBoxStudentsClass);
            Name = "classView";
            Text = "classView";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxStudentsClass;
        private Button changeClass_btn;
        private ComboBox changeClass_comboBox;
        private Button saveChanges_btn;
    }
}
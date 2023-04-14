namespace WindowsFormsAppProject
{
    partial class addUser
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
            phone_lbl = new Label();
            phone_txt = new TextBox();
            email_lbl = new Label();
            class_comboBox = new ComboBox();
            class_lbl = new Label();
            role_lbl = new Label();
            role_comboBox = new ComboBox();
            email_txt = new TextBox();
            lastName_txt = new TextBox();
            lastName_lbl = new Label();
            firstName_txt = new TextBox();
            firstName_lbl = new Label();
            addUsesr_btn = new Button();
            subject_clb = new CheckedListBox();
            subject_lbl = new Label();
            SuspendLayout();
            // 
            // phone_lbl
            // 
            phone_lbl.AutoSize = true;
            phone_lbl.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            phone_lbl.Location = new Point(9, 337);
            phone_lbl.Name = "phone_lbl";
            phone_lbl.Size = new Size(196, 37);
            phone_lbl.TabIndex = 29;
            phone_lbl.Text = "Phone Number";
            // 
            // phone_txt
            // 
            phone_txt.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            phone_txt.Location = new Point(227, 339);
            phone_txt.Name = "phone_txt";
            phone_txt.Size = new Size(332, 43);
            phone_txt.TabIndex = 27;
            // 
            // email_lbl
            // 
            email_lbl.AutoSize = true;
            email_lbl.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            email_lbl.Location = new Point(69, 280);
            email_lbl.Name = "email_lbl";
            email_lbl.Size = new Size(82, 37);
            email_lbl.TabIndex = 26;
            email_lbl.Text = "Email";
            // 
            // class_comboBox
            // 
            class_comboBox.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            class_comboBox.FormattingEnabled = true;
            class_comboBox.Location = new Point(227, 208);
            class_comboBox.Name = "class_comboBox";
            class_comboBox.Size = new Size(332, 45);
            class_comboBox.TabIndex = 25;
            // 
            // class_lbl
            // 
            class_lbl.AutoSize = true;
            class_lbl.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            class_lbl.Location = new Point(74, 216);
            class_lbl.Name = "class_lbl";
            class_lbl.Size = new Size(77, 37);
            class_lbl.TabIndex = 24;
            class_lbl.Text = "Class";
            // 
            // role_lbl
            // 
            role_lbl.AutoSize = true;
            role_lbl.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            role_lbl.Location = new Point(74, 152);
            role_lbl.Name = "role_lbl";
            role_lbl.Size = new Size(69, 37);
            role_lbl.TabIndex = 23;
            role_lbl.Text = "Role";
            // 
            // role_comboBox
            // 
            role_comboBox.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            role_comboBox.FormattingEnabled = true;
            role_comboBox.Location = new Point(227, 144);
            role_comboBox.Name = "role_comboBox";
            role_comboBox.Size = new Size(332, 45);
            role_comboBox.TabIndex = 22;
            role_comboBox.SelectedIndexChanged += role_comboBox_SelectedIndexChanged;
            // 
            // email_txt
            // 
            email_txt.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            email_txt.Location = new Point(227, 274);
            email_txt.Name = "email_txt";
            email_txt.Size = new Size(332, 43);
            email_txt.TabIndex = 21;
            // 
            // lastName_txt
            // 
            lastName_txt.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lastName_txt.Location = new Point(227, 83);
            lastName_txt.Name = "lastName_txt";
            lastName_txt.Size = new Size(332, 43);
            lastName_txt.TabIndex = 20;
            // 
            // lastName_lbl
            // 
            lastName_lbl.AutoSize = true;
            lastName_lbl.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lastName_lbl.Location = new Point(44, 83);
            lastName_lbl.Name = "lastName_lbl";
            lastName_lbl.Size = new Size(142, 37);
            lastName_lbl.TabIndex = 19;
            lastName_lbl.Text = "Last Name";
            // 
            // firstName_txt
            // 
            firstName_txt.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            firstName_txt.Location = new Point(227, 19);
            firstName_txt.Name = "firstName_txt";
            firstName_txt.Size = new Size(332, 43);
            firstName_txt.TabIndex = 18;
            // 
            // firstName_lbl
            // 
            firstName_lbl.AutoSize = true;
            firstName_lbl.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            firstName_lbl.Location = new Point(44, 25);
            firstName_lbl.Name = "firstName_lbl";
            firstName_lbl.Size = new Size(144, 37);
            firstName_lbl.TabIndex = 17;
            firstName_lbl.Text = "First Name";
            // 
            // addUsesr_btn
            // 
            addUsesr_btn.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            addUsesr_btn.Location = new Point(9, 435);
            addUsesr_btn.Name = "addUsesr_btn";
            addUsesr_btn.Size = new Size(246, 71);
            addUsesr_btn.TabIndex = 30;
            addUsesr_btn.Text = "Create User";
            addUsesr_btn.UseVisualStyleBackColor = true;
            addUsesr_btn.Click += addUsesr_btn_Click;
            // 
            // subject_clb
            // 
            subject_clb.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            subject_clb.FormattingEnabled = true;
            subject_clb.Location = new Point(578, 59);
            subject_clb.Name = "subject_clb";
            subject_clb.Size = new Size(161, 323);
            subject_clb.TabIndex = 32;
            // 
            // subject_lbl
            // 
            subject_lbl.AutoSize = true;
            subject_lbl.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            subject_lbl.Location = new Point(578, 19);
            subject_lbl.Name = "subject_lbl";
            subject_lbl.Size = new Size(192, 37);
            subject_lbl.TabIndex = 33;
            subject_lbl.Text = "Select Subjects";
            // 
            // addUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 524);
            Controls.Add(subject_lbl);
            Controls.Add(subject_clb);
            Controls.Add(addUsesr_btn);
            Controls.Add(phone_lbl);
            Controls.Add(phone_txt);
            Controls.Add(email_lbl);
            Controls.Add(class_comboBox);
            Controls.Add(class_lbl);
            Controls.Add(role_lbl);
            Controls.Add(role_comboBox);
            Controls.Add(email_txt);
            Controls.Add(lastName_txt);
            Controls.Add(lastName_lbl);
            Controls.Add(firstName_txt);
            Controls.Add(firstName_lbl);
            Name = "addUser";
            Text = "addUser";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label phone_lbl;
        private TextBox phone_txt;
        private Label email_lbl;
        private ComboBox class_comboBox;
        private Label class_lbl;
        private Label role_lbl;
        private ComboBox role_comboBox;
        private TextBox email_txt;
        private TextBox lastName_txt;
        private Label lastName_lbl;
        private TextBox firstName_txt;
        private Label firstName_lbl;
        private Button addUsesr_btn;
        private CheckedListBox subject_clb;
        private Label subject_lbl;
    }
}
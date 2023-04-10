namespace WindowsFormsAppProject
{
    partial class userView
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            saveChanges_btn = new Button();
            deleteUser_btn = new Button();
            updateDetails_btn = new Button();
            userId_lbl = new Label();
            phone_lbl = new Label();
            userId_txt = new TextBox();
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
            tabPage2 = new TabPage();
            promoteUser_btn = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1300, 564);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(promoteUser_btn);
            tabPage1.Controls.Add(saveChanges_btn);
            tabPage1.Controls.Add(deleteUser_btn);
            tabPage1.Controls.Add(updateDetails_btn);
            tabPage1.Controls.Add(userId_lbl);
            tabPage1.Controls.Add(phone_lbl);
            tabPage1.Controls.Add(userId_txt);
            tabPage1.Controls.Add(phone_txt);
            tabPage1.Controls.Add(email_lbl);
            tabPage1.Controls.Add(class_comboBox);
            tabPage1.Controls.Add(class_lbl);
            tabPage1.Controls.Add(role_lbl);
            tabPage1.Controls.Add(role_comboBox);
            tabPage1.Controls.Add(email_txt);
            tabPage1.Controls.Add(lastName_txt);
            tabPage1.Controls.Add(lastName_lbl);
            tabPage1.Controls.Add(firstName_txt);
            tabPage1.Controls.Add(firstName_lbl);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1292, 536);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "User Info";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // saveChanges_btn
            // 
            saveChanges_btn.FlatStyle = FlatStyle.Flat;
            saveChanges_btn.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            saveChanges_btn.Location = new Point(648, 30);
            saveChanges_btn.Name = "saveChanges_btn";
            saveChanges_btn.Size = new Size(372, 107);
            saveChanges_btn.TabIndex = 19;
            saveChanges_btn.Text = "Save Changes";
            saveChanges_btn.UseVisualStyleBackColor = true;
            saveChanges_btn.Click += saveChanges_btn_Click;
            // 
            // deleteUser_btn
            // 
            deleteUser_btn.FlatStyle = FlatStyle.Flat;
            deleteUser_btn.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            deleteUser_btn.Location = new Point(648, 155);
            deleteUser_btn.Name = "deleteUser_btn";
            deleteUser_btn.Size = new Size(372, 109);
            deleteUser_btn.TabIndex = 18;
            deleteUser_btn.Text = "Delete User";
            deleteUser_btn.UseVisualStyleBackColor = true;
            deleteUser_btn.Click += deleteUser_btn_Click;
            // 
            // updateDetails_btn
            // 
            updateDetails_btn.FlatStyle = FlatStyle.Popup;
            updateDetails_btn.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            updateDetails_btn.Location = new Point(648, 30);
            updateDetails_btn.Name = "updateDetails_btn";
            updateDetails_btn.Size = new Size(372, 107);
            updateDetails_btn.TabIndex = 17;
            updateDetails_btn.Text = "Update Details";
            updateDetails_btn.UseVisualStyleBackColor = true;
            updateDetails_btn.Click += updateDetails_btn_Click;
            // 
            // userId_lbl
            // 
            userId_lbl.AutoSize = true;
            userId_lbl.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            userId_lbl.Location = new Point(68, 420);
            userId_lbl.Name = "userId_lbl";
            userId_lbl.Size = new Size(103, 37);
            userId_lbl.TabIndex = 16;
            userId_lbl.Text = "User ID";
            // 
            // phone_lbl
            // 
            phone_lbl.AutoSize = true;
            phone_lbl.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            phone_lbl.Location = new Point(8, 348);
            phone_lbl.Name = "phone_lbl";
            phone_lbl.Size = new Size(196, 37);
            phone_lbl.TabIndex = 15;
            phone_lbl.Text = "Phone Number";
            // 
            // userId_txt
            // 
            userId_txt.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            userId_txt.Location = new Point(226, 420);
            userId_txt.Name = "userId_txt";
            userId_txt.Size = new Size(124, 43);
            userId_txt.TabIndex = 14;
            // 
            // phone_txt
            // 
            phone_txt.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            phone_txt.Location = new Point(226, 345);
            phone_txt.Name = "phone_txt";
            phone_txt.Size = new Size(332, 43);
            phone_txt.TabIndex = 13;
            // 
            // email_lbl
            // 
            email_lbl.AutoSize = true;
            email_lbl.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            email_lbl.Location = new Point(68, 291);
            email_lbl.Name = "email_lbl";
            email_lbl.Size = new Size(82, 37);
            email_lbl.TabIndex = 12;
            email_lbl.Text = "Email";
            // 
            // class_comboBox
            // 
            class_comboBox.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            class_comboBox.FormattingEnabled = true;
            class_comboBox.Location = new Point(226, 219);
            class_comboBox.Name = "class_comboBox";
            class_comboBox.Size = new Size(332, 45);
            class_comboBox.TabIndex = 11;
            // 
            // class_lbl
            // 
            class_lbl.AutoSize = true;
            class_lbl.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            class_lbl.Location = new Point(68, 227);
            class_lbl.Name = "class_lbl";
            class_lbl.Size = new Size(77, 37);
            class_lbl.TabIndex = 10;
            class_lbl.Text = "Class";
            // 
            // role_lbl
            // 
            role_lbl.AutoSize = true;
            role_lbl.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            role_lbl.Location = new Point(68, 163);
            role_lbl.Name = "role_lbl";
            role_lbl.Size = new Size(69, 37);
            role_lbl.TabIndex = 9;
            role_lbl.Text = "Role";
            // 
            // role_comboBox
            // 
            role_comboBox.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            role_comboBox.FormattingEnabled = true;
            role_comboBox.Location = new Point(226, 155);
            role_comboBox.Name = "role_comboBox";
            role_comboBox.Size = new Size(332, 45);
            role_comboBox.TabIndex = 8;
            // 
            // email_txt
            // 
            email_txt.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            email_txt.Location = new Point(226, 285);
            email_txt.Name = "email_txt";
            email_txt.Size = new Size(332, 43);
            email_txt.TabIndex = 7;
            // 
            // lastName_txt
            // 
            lastName_txt.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lastName_txt.Location = new Point(226, 94);
            lastName_txt.Name = "lastName_txt";
            lastName_txt.Size = new Size(332, 43);
            lastName_txt.TabIndex = 4;
            // 
            // lastName_lbl
            // 
            lastName_lbl.AutoSize = true;
            lastName_lbl.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lastName_lbl.Location = new Point(43, 94);
            lastName_lbl.Name = "lastName_lbl";
            lastName_lbl.Size = new Size(142, 37);
            lastName_lbl.TabIndex = 3;
            lastName_lbl.Text = "Last Name";
            // 
            // firstName_txt
            // 
            firstName_txt.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            firstName_txt.Location = new Point(226, 30);
            firstName_txt.Name = "firstName_txt";
            firstName_txt.Size = new Size(332, 43);
            firstName_txt.TabIndex = 2;
            // 
            // firstName_lbl
            // 
            firstName_lbl.AutoSize = true;
            firstName_lbl.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            firstName_lbl.Location = new Point(41, 33);
            firstName_lbl.Name = "firstName_lbl";
            firstName_lbl.Size = new Size(144, 37);
            firstName_lbl.TabIndex = 1;
            firstName_lbl.Text = "First Name";
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1292, 536);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "User Grades";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // promoteUser_btn
            // 
            promoteUser_btn.FlatStyle = FlatStyle.Flat;
            promoteUser_btn.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            promoteUser_btn.Location = new Point(648, 291);
            promoteUser_btn.Name = "promoteUser_btn";
            promoteUser_btn.Size = new Size(372, 109);
            promoteUser_btn.TabIndex = 20;
            promoteUser_btn.Text = "Promote User";
            promoteUser_btn.UseVisualStyleBackColor = true;
            promoteUser_btn.Click += promoteUser_btn_Click;
            // 
            // userView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1112, 595);
            Controls.Add(tabControl1);
            MaximizeBox = false;
            Name = "userView";
            Text = "userView";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label firstName_lbl;
        private Button deleteUser_btn;
        private Button updateDetails_btn;
        private Label userId_lbl;
        private Label phone_lbl;
        private TextBox userId_txt;
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
        private Button saveChanges_btn;
        private Button promoteUser_btn;
    }
}
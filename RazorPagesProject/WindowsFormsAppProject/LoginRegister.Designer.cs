namespace Housing_Project
{
    partial class LoginRegister
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabPageRegister = new TabPage();
            registerlbl = new Label();
            passwordlbl = new Label();
            emailadresslbl = new Label();
            phonenumberlbl = new Label();
            fullnamelbl = new Label();
            passwordtxt = new TextBox();
            emailadresstxt = new TextBox();
            phonenumbertxt = new TextBox();
            fullnametxt = new TextBox();
            registerbtn = new Button();
            label4 = new Label();
            tabPageLogin = new TabPage();
            loginpasswordtxt = new TextBox();
            loginemailtxt = new TextBox();
            label1 = new Label();
            loginwrongcredentialslbl = new Label();
            loginemaillbl = new Label();
            loginpasswordlbl = new Label();
            loginbtn = new Button();
            tabControlLoginRegister = new TabControl();
            tabPageRegister.SuspendLayout();
            tabPageLogin.SuspendLayout();
            tabControlLoginRegister.SuspendLayout();
            SuspendLayout();
            // 
            // tabPageRegister
            // 
            tabPageRegister.BackColor = Color.Transparent;
            tabPageRegister.Controls.Add(registerlbl);
            tabPageRegister.Controls.Add(passwordlbl);
            tabPageRegister.Controls.Add(emailadresslbl);
            tabPageRegister.Controls.Add(phonenumberlbl);
            tabPageRegister.Controls.Add(fullnamelbl);
            tabPageRegister.Controls.Add(passwordtxt);
            tabPageRegister.Controls.Add(emailadresstxt);
            tabPageRegister.Controls.Add(phonenumbertxt);
            tabPageRegister.Controls.Add(fullnametxt);
            tabPageRegister.Controls.Add(registerbtn);
            tabPageRegister.Controls.Add(label4);
            tabPageRegister.Location = new Point(4, 4);
            tabPageRegister.Margin = new Padding(3, 2, 3, 2);
            tabPageRegister.Name = "tabPageRegister";
            tabPageRegister.Padding = new Padding(3, 2, 3, 2);
            tabPageRegister.Size = new Size(445, 506);
            tabPageRegister.TabIndex = 1;
            tabPageRegister.Text = "Create account";
            // 
            // registerlbl
            // 
            registerlbl.AutoSize = true;
            registerlbl.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            registerlbl.ForeColor = Color.DodgerBlue;
            registerlbl.Location = new Point(9, 440);
            registerlbl.Name = "registerlbl";
            registerlbl.Size = new Size(377, 32);
            registerlbl.TabIndex = 28;
            registerlbl.Text = "Already registered with this email!";
            // 
            // passwordlbl
            // 
            passwordlbl.AutoSize = true;
            passwordlbl.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            passwordlbl.Location = new Point(20, 306);
            passwordlbl.Name = "passwordlbl";
            passwordlbl.Size = new Size(70, 19);
            passwordlbl.TabIndex = 26;
            passwordlbl.Text = "Password:";
            // 
            // emailadresslbl
            // 
            emailadresslbl.AutoSize = true;
            emailadresslbl.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            emailadresslbl.Location = new Point(20, 229);
            emailadresslbl.Name = "emailadresslbl";
            emailadresslbl.Size = new Size(89, 19);
            emailadresslbl.TabIndex = 25;
            emailadresslbl.Text = "Email Adress:";
            // 
            // phonenumberlbl
            // 
            phonenumberlbl.AutoSize = true;
            phonenumberlbl.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            phonenumberlbl.Location = new Point(20, 150);
            phonenumberlbl.Name = "phonenumberlbl";
            phonenumberlbl.Size = new Size(105, 19);
            phonenumberlbl.TabIndex = 24;
            phonenumberlbl.Text = "Phone Number:";
            // 
            // fullnamelbl
            // 
            fullnamelbl.AutoSize = true;
            fullnamelbl.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            fullnamelbl.Location = new Point(20, 79);
            fullnamelbl.Name = "fullnamelbl";
            fullnamelbl.Size = new Size(73, 19);
            fullnamelbl.TabIndex = 23;
            fullnamelbl.Text = "Full Name:";
            // 
            // passwordtxt
            // 
            passwordtxt.Location = new Point(20, 327);
            passwordtxt.Margin = new Padding(3, 2, 3, 2);
            passwordtxt.Name = "passwordtxt";
            passwordtxt.PasswordChar = '*';
            passwordtxt.Size = new Size(401, 34);
            passwordtxt.TabIndex = 22;
            // 
            // emailadresstxt
            // 
            emailadresstxt.Location = new Point(20, 250);
            emailadresstxt.Margin = new Padding(3, 2, 3, 2);
            emailadresstxt.Name = "emailadresstxt";
            emailadresstxt.Size = new Size(401, 34);
            emailadresstxt.TabIndex = 21;
            // 
            // phonenumbertxt
            // 
            phonenumbertxt.Location = new Point(20, 174);
            phonenumbertxt.Margin = new Padding(3, 2, 3, 2);
            phonenumbertxt.Name = "phonenumbertxt";
            phonenumbertxt.Size = new Size(401, 34);
            phonenumbertxt.TabIndex = 20;
            // 
            // fullnametxt
            // 
            fullnametxt.Location = new Point(20, 100);
            fullnametxt.Margin = new Padding(3, 2, 3, 2);
            fullnametxt.Name = "fullnametxt";
            fullnametxt.Size = new Size(401, 34);
            fullnametxt.TabIndex = 19;
            // 
            // registerbtn
            // 
            registerbtn.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            registerbtn.Location = new Point(20, 389);
            registerbtn.Name = "registerbtn";
            registerbtn.Size = new Size(134, 34);
            registerbtn.TabIndex = 18;
            registerbtn.Text = "Register";
            registerbtn.UseVisualStyleBackColor = true;
            registerbtn.Click += registerbtn_Click_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(20, 20);
            label4.Name = "label4";
            label4.Size = new Size(154, 28);
            label4.TabIndex = 0;
            label4.Text = "Create account";
            // 
            // tabPageLogin
            // 
            tabPageLogin.BackColor = Color.Transparent;
            tabPageLogin.Controls.Add(loginpasswordtxt);
            tabPageLogin.Controls.Add(loginemailtxt);
            tabPageLogin.Controls.Add(label1);
            tabPageLogin.Controls.Add(loginwrongcredentialslbl);
            tabPageLogin.Controls.Add(loginemaillbl);
            tabPageLogin.Controls.Add(loginpasswordlbl);
            tabPageLogin.Controls.Add(loginbtn);
            tabPageLogin.Location = new Point(4, 4);
            tabPageLogin.Margin = new Padding(3, 2, 3, 2);
            tabPageLogin.Name = "tabPageLogin";
            tabPageLogin.Padding = new Padding(3, 2, 3, 2);
            tabPageLogin.Size = new Size(445, 506);
            tabPageLogin.TabIndex = 0;
            tabPageLogin.Text = "Login Form";
            // 
            // loginpasswordtxt
            // 
            loginpasswordtxt.Location = new Point(20, 209);
            loginpasswordtxt.Margin = new Padding(3, 2, 3, 2);
            loginpasswordtxt.Name = "loginpasswordtxt";
            loginpasswordtxt.PasswordChar = '*';
            loginpasswordtxt.Size = new Size(401, 34);
            loginpasswordtxt.TabIndex = 14;
            // 
            // loginemailtxt
            // 
            loginemailtxt.Location = new Point(20, 107);
            loginemailtxt.Margin = new Padding(3, 2, 3, 2);
            loginemailtxt.Name = "loginemailtxt";
            loginemailtxt.Size = new Size(401, 34);
            loginemailtxt.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(20, 20);
            label1.Name = "label1";
            label1.Size = new Size(70, 28);
            label1.TabIndex = 0;
            label1.Text = "Log in";
            // 
            // loginwrongcredentialslbl
            // 
            loginwrongcredentialslbl.AutoSize = true;
            loginwrongcredentialslbl.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            loginwrongcredentialslbl.ForeColor = Color.DodgerBlue;
            loginwrongcredentialslbl.Location = new Point(20, 451);
            loginwrongcredentialslbl.Name = "loginwrongcredentialslbl";
            loginwrongcredentialslbl.Size = new Size(241, 37);
            loginwrongcredentialslbl.TabIndex = 14;
            loginwrongcredentialslbl.Text = "Wrong credentials!";
            // 
            // loginemaillbl
            // 
            loginemaillbl.AutoSize = true;
            loginemaillbl.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            loginemaillbl.Location = new Point(20, 75);
            loginemaillbl.Name = "loginemaillbl";
            loginemaillbl.Size = new Size(89, 19);
            loginemaillbl.TabIndex = 12;
            loginemaillbl.Text = "Email Adress:";
            // 
            // loginpasswordlbl
            // 
            loginpasswordlbl.AutoSize = true;
            loginpasswordlbl.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            loginpasswordlbl.Location = new Point(20, 175);
            loginpasswordlbl.Name = "loginpasswordlbl";
            loginpasswordlbl.Size = new Size(70, 19);
            loginpasswordlbl.TabIndex = 13;
            loginpasswordlbl.Text = "Password:";
            // 
            // loginbtn
            // 
            loginbtn.Cursor = Cursors.Hand;
            loginbtn.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            loginbtn.Location = new Point(20, 286);
            loginbtn.Name = "loginbtn";
            loginbtn.Size = new Size(134, 34);
            loginbtn.TabIndex = 0;
            loginbtn.Text = "Log In";
            loginbtn.UseVisualStyleBackColor = true;
            loginbtn.Click += loginbtn_Click;
            // 
            // tabControlLoginRegister
            // 
            tabControlLoginRegister.Alignment = TabAlignment.Bottom;
            tabControlLoginRegister.Controls.Add(tabPageLogin);
            tabControlLoginRegister.Controls.Add(tabPageRegister);
            tabControlLoginRegister.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            tabControlLoginRegister.Location = new Point(91, 35);
            tabControlLoginRegister.Margin = new Padding(3, 2, 3, 2);
            tabControlLoginRegister.Name = "tabControlLoginRegister";
            tabControlLoginRegister.Padding = new Point(55, 6);
            tabControlLoginRegister.SelectedIndex = 0;
            tabControlLoginRegister.Size = new Size(453, 553);
            tabControlLoginRegister.TabIndex = 17;
            tabControlLoginRegister.Click += tabControlLoginRegister_Click;
            // 
            // LoginRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(644, 634);
            Controls.Add(tabControlLoginRegister);
            Margin = new Padding(3, 2, 3, 2);
            Name = "LoginRegister";
            Text = "Login/Register";
            tabPageRegister.ResumeLayout(false);
            tabPageRegister.PerformLayout();
            tabPageLogin.ResumeLayout(false);
            tabPageLogin.PerformLayout();
            tabControlLoginRegister.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabPage tabPageRegister;
        private Label passwordlbl;
        private Label emailadresslbl;
        private Label phonenumberlbl;
        private Label fullnamelbl;
        private TextBox passwordtxt;
        private TextBox emailadresstxt;
        private TextBox phonenumbertxt;
        private TextBox fullnametxt;
        private Button registerbtn;
        private Label label4;
        private TabPage tabPageLogin;
        private TextBox loginpasswordtxt;
        private TextBox loginemailtxt;
        private Label label1;
        private Label loginwrongcredentialslbl;
        private Label loginemaillbl;
        private Label loginpasswordlbl;
        private Button loginbtn;
        private TabControl tabControlLoginRegister;
        private Label registerlbl;
    }
}
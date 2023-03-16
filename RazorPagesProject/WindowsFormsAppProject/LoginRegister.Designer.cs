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
			this.tabPageRegister = new System.Windows.Forms.TabPage();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.registerlbl = new System.Windows.Forms.Label();
			this.passwordlbl = new System.Windows.Forms.Label();
			this.emailadresslbl = new System.Windows.Forms.Label();
			this.phonenumberlbl = new System.Windows.Forms.Label();
			this.fullnamelbl = new System.Windows.Forms.Label();
			this.passwordtxt = new System.Windows.Forms.TextBox();
			this.emailadresstxt = new System.Windows.Forms.TextBox();
			this.phonenumbertxt = new System.Windows.Forms.TextBox();
			this.fullnametxt = new System.Windows.Forms.TextBox();
			this.registerbtn = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.tabPageLogin = new System.Windows.Forms.TabPage();
			this.loginpasswordtxt = new System.Windows.Forms.TextBox();
			this.loginemailtxt = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.loginwrongcredentialslbl = new System.Windows.Forms.Label();
			this.loginemaillbl = new System.Windows.Forms.Label();
			this.loginpasswordlbl = new System.Windows.Forms.Label();
			this.loginbtn = new System.Windows.Forms.Button();
			this.tabControlLoginRegister = new System.Windows.Forms.TabControl();
			this.tabPageRegister.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.tabPageLogin.SuspendLayout();
			this.tabControlLoginRegister.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabPageRegister
			// 
			this.tabPageRegister.BackColor = System.Drawing.Color.Transparent;
			this.tabPageRegister.Controls.Add(this.pictureBox2);
			this.tabPageRegister.Controls.Add(this.registerlbl);
			this.tabPageRegister.Controls.Add(this.passwordlbl);
			this.tabPageRegister.Controls.Add(this.emailadresslbl);
			this.tabPageRegister.Controls.Add(this.phonenumberlbl);
			this.tabPageRegister.Controls.Add(this.fullnamelbl);
			this.tabPageRegister.Controls.Add(this.passwordtxt);
			this.tabPageRegister.Controls.Add(this.emailadresstxt);
			this.tabPageRegister.Controls.Add(this.phonenumbertxt);
			this.tabPageRegister.Controls.Add(this.fullnametxt);
			this.tabPageRegister.Controls.Add(this.registerbtn);
			this.tabPageRegister.Controls.Add(this.label4);
			this.tabPageRegister.Location = new System.Drawing.Point(4, 4);
			this.tabPageRegister.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tabPageRegister.Name = "tabPageRegister";
			this.tabPageRegister.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tabPageRegister.Size = new System.Drawing.Size(445, 506);
			this.tabPageRegister.TabIndex = 1;
			this.tabPageRegister.Text = "Create account";
			// 
			// pictureBox2
			// 
			this.pictureBox2.Location = new System.Drawing.Point(192, 19);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(35, 28);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 29;
			this.pictureBox2.TabStop = false;
			// 
			// registerlbl
			// 
			this.registerlbl.AutoSize = true;
			this.registerlbl.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.registerlbl.ForeColor = System.Drawing.Color.DodgerBlue;
			this.registerlbl.Location = new System.Drawing.Point(9, 440);
			this.registerlbl.Name = "registerlbl";
			this.registerlbl.Size = new System.Drawing.Size(377, 32);
			this.registerlbl.TabIndex = 28;
			this.registerlbl.Text = "Already registered with this email!";
			// 
			// passwordlbl
			// 
			this.passwordlbl.AutoSize = true;
			this.passwordlbl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.passwordlbl.Location = new System.Drawing.Point(20, 306);
			this.passwordlbl.Name = "passwordlbl";
			this.passwordlbl.Size = new System.Drawing.Size(70, 19);
			this.passwordlbl.TabIndex = 26;
			this.passwordlbl.Text = "Password:";
			// 
			// emailadresslbl
			// 
			this.emailadresslbl.AutoSize = true;
			this.emailadresslbl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.emailadresslbl.Location = new System.Drawing.Point(20, 229);
			this.emailadresslbl.Name = "emailadresslbl";
			this.emailadresslbl.Size = new System.Drawing.Size(89, 19);
			this.emailadresslbl.TabIndex = 25;
			this.emailadresslbl.Text = "Email Adress:";
			// 
			// phonenumberlbl
			// 
			this.phonenumberlbl.AutoSize = true;
			this.phonenumberlbl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.phonenumberlbl.Location = new System.Drawing.Point(20, 150);
			this.phonenumberlbl.Name = "phonenumberlbl";
			this.phonenumberlbl.Size = new System.Drawing.Size(105, 19);
			this.phonenumberlbl.TabIndex = 24;
			this.phonenumberlbl.Text = "Phone Number:";
			// 
			// fullnamelbl
			// 
			this.fullnamelbl.AutoSize = true;
			this.fullnamelbl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.fullnamelbl.Location = new System.Drawing.Point(20, 79);
			this.fullnamelbl.Name = "fullnamelbl";
			this.fullnamelbl.Size = new System.Drawing.Size(73, 19);
			this.fullnamelbl.TabIndex = 23;
			this.fullnamelbl.Text = "Full Name:";
			// 
			// passwordtxt
			// 
			this.passwordtxt.Location = new System.Drawing.Point(20, 327);
			this.passwordtxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.passwordtxt.Name = "passwordtxt";
			this.passwordtxt.PasswordChar = '*';
			this.passwordtxt.Size = new System.Drawing.Size(401, 34);
			this.passwordtxt.TabIndex = 22;
			// 
			// emailadresstxt
			// 
			this.emailadresstxt.Location = new System.Drawing.Point(20, 250);
			this.emailadresstxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.emailadresstxt.Name = "emailadresstxt";
			this.emailadresstxt.Size = new System.Drawing.Size(401, 34);
			this.emailadresstxt.TabIndex = 21;
			// 
			// phonenumbertxt
			// 
			this.phonenumbertxt.Location = new System.Drawing.Point(20, 174);
			this.phonenumbertxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.phonenumbertxt.Name = "phonenumbertxt";
			this.phonenumbertxt.Size = new System.Drawing.Size(401, 34);
			this.phonenumbertxt.TabIndex = 20;
			// 
			// fullnametxt
			// 
			this.fullnametxt.Location = new System.Drawing.Point(20, 100);
			this.fullnametxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.fullnametxt.Name = "fullnametxt";
			this.fullnametxt.Size = new System.Drawing.Size(401, 34);
			this.fullnametxt.TabIndex = 19;
			// 
			// registerbtn
			// 
			this.registerbtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.registerbtn.Location = new System.Drawing.Point(20, 389);
			this.registerbtn.Name = "registerbtn";
			this.registerbtn.Size = new System.Drawing.Size(134, 34);
			this.registerbtn.TabIndex = 18;
			this.registerbtn.Text = "Register";
			this.registerbtn.UseVisualStyleBackColor = true;
			this.registerbtn.Click += new System.EventHandler(this.registerbtn_Click_1);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label4.Location = new System.Drawing.Point(20, 20);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(154, 28);
			this.label4.TabIndex = 0;
			this.label4.Text = "Create account";
			// 
			// tabPageLogin
			// 
			this.tabPageLogin.BackColor = System.Drawing.Color.Transparent;
			this.tabPageLogin.Controls.Add(this.loginpasswordtxt);
			this.tabPageLogin.Controls.Add(this.loginemailtxt);
			this.tabPageLogin.Controls.Add(this.label1);
			this.tabPageLogin.Controls.Add(this.loginwrongcredentialslbl);
			this.tabPageLogin.Controls.Add(this.loginemaillbl);
			this.tabPageLogin.Controls.Add(this.loginpasswordlbl);
			this.tabPageLogin.Controls.Add(this.loginbtn);
			this.tabPageLogin.Location = new System.Drawing.Point(4, 4);
			this.tabPageLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tabPageLogin.Name = "tabPageLogin";
			this.tabPageLogin.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tabPageLogin.Size = new System.Drawing.Size(445, 506);
			this.tabPageLogin.TabIndex = 0;
			this.tabPageLogin.Text = "Login Form";
			// 
			// loginpasswordtxt
			// 
			this.loginpasswordtxt.Location = new System.Drawing.Point(20, 209);
			this.loginpasswordtxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.loginpasswordtxt.Name = "loginpasswordtxt";
			this.loginpasswordtxt.PasswordChar = '*';
			this.loginpasswordtxt.Size = new System.Drawing.Size(401, 34);
			this.loginpasswordtxt.TabIndex = 14;
			// 
			// loginemailtxt
			// 
			this.loginemailtxt.Location = new System.Drawing.Point(20, 107);
			this.loginemailtxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.loginemailtxt.Name = "loginemailtxt";
			this.loginemailtxt.Size = new System.Drawing.Size(401, 34);
			this.loginemailtxt.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(20, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(70, 28);
			this.label1.TabIndex = 0;
			this.label1.Text = "Log in";
			// 
			// loginwrongcredentialslbl
			// 
			this.loginwrongcredentialslbl.AutoSize = true;
			this.loginwrongcredentialslbl.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.loginwrongcredentialslbl.ForeColor = System.Drawing.Color.DodgerBlue;
			this.loginwrongcredentialslbl.Location = new System.Drawing.Point(20, 451);
			this.loginwrongcredentialslbl.Name = "loginwrongcredentialslbl";
			this.loginwrongcredentialslbl.Size = new System.Drawing.Size(241, 37);
			this.loginwrongcredentialslbl.TabIndex = 14;
			this.loginwrongcredentialslbl.Text = "Wrong credentials!";
			// 
			// loginemaillbl
			// 
			this.loginemaillbl.AutoSize = true;
			this.loginemaillbl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.loginemaillbl.Location = new System.Drawing.Point(20, 75);
			this.loginemaillbl.Name = "loginemaillbl";
			this.loginemaillbl.Size = new System.Drawing.Size(89, 19);
			this.loginemaillbl.TabIndex = 12;
			this.loginemaillbl.Text = "Email Adress:";
			// 
			// loginpasswordlbl
			// 
			this.loginpasswordlbl.AutoSize = true;
			this.loginpasswordlbl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.loginpasswordlbl.Location = new System.Drawing.Point(20, 175);
			this.loginpasswordlbl.Name = "loginpasswordlbl";
			this.loginpasswordlbl.Size = new System.Drawing.Size(70, 19);
			this.loginpasswordlbl.TabIndex = 13;
			this.loginpasswordlbl.Text = "Password:";
			// 
			// loginbtn
			// 
			this.loginbtn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.loginbtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.loginbtn.Location = new System.Drawing.Point(20, 286);
			this.loginbtn.Name = "loginbtn";
			this.loginbtn.Size = new System.Drawing.Size(134, 34);
			this.loginbtn.TabIndex = 0;
			this.loginbtn.Text = "Log In";
			this.loginbtn.UseVisualStyleBackColor = true;
			this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
			// 
			// tabControlLoginRegister
			// 
			this.tabControlLoginRegister.Alignment = System.Windows.Forms.TabAlignment.Bottom;
			this.tabControlLoginRegister.Controls.Add(this.tabPageLogin);
			this.tabControlLoginRegister.Controls.Add(this.tabPageRegister);
			this.tabControlLoginRegister.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.tabControlLoginRegister.Location = new System.Drawing.Point(91, 35);
			this.tabControlLoginRegister.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tabControlLoginRegister.Name = "tabControlLoginRegister";
			this.tabControlLoginRegister.Padding = new System.Drawing.Point(55, 6);
			this.tabControlLoginRegister.SelectedIndex = 0;
			this.tabControlLoginRegister.Size = new System.Drawing.Size(453, 553);
			this.tabControlLoginRegister.TabIndex = 17;
			this.tabControlLoginRegister.Click += new System.EventHandler(this.tabControlLoginRegister_Click);
			// 
			// LoginRegister
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(644, 634);
			this.Controls.Add(this.tabControlLoginRegister);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "LoginRegister";
			this.Text = "Login/Register";
			this.tabPageRegister.ResumeLayout(false);
			this.tabPageRegister.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.tabPageLogin.ResumeLayout(false);
			this.tabPageLogin.PerformLayout();
			this.tabControlLoginRegister.ResumeLayout(false);
			this.ResumeLayout(false);

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
        private PictureBox pictureBox2;
    }
}
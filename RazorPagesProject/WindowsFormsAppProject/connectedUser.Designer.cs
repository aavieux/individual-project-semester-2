namespace WindowsFormsAppProject
{
	partial class connectedUser
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
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.listBoxTeachers = new System.Windows.Forms.ListBox();
			this.listBoxStudents = new System.Windows.Forms.ListBox();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Location = new System.Drawing.Point(12, 66);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(1300, 510);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.listBoxTeachers);
			this.tabPage1.Controls.Add(this.listBoxStudents);
			this.tabPage1.Location = new System.Drawing.Point(4, 24);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(1292, 482);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Manage Users";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// listBoxTeachers
			// 
			this.listBoxTeachers.FormattingEnabled = true;
			this.listBoxTeachers.ItemHeight = 15;
			this.listBoxTeachers.Location = new System.Drawing.Point(6, 247);
			this.listBoxTeachers.Name = "listBoxTeachers";
			this.listBoxTeachers.Size = new System.Drawing.Size(753, 229);
			this.listBoxTeachers.TabIndex = 1;
			// 
			// listBoxStudents
			// 
			this.listBoxStudents.FormattingEnabled = true;
			this.listBoxStudents.ItemHeight = 15;
			this.listBoxStudents.Location = new System.Drawing.Point(6, 6);
			this.listBoxStudents.Name = "listBoxStudents";
			this.listBoxStudents.Size = new System.Drawing.Size(753, 229);
			this.listBoxStudents.TabIndex = 0;
			this.listBoxStudents.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxStudents_MouseDoubleClick);
			// 
			// connectedUser
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1324, 588);
			this.Controls.Add(this.tabControl1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "connectedUser";
			this.Text = "connectedUser";
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private TabControl tabControl1;
		private TabPage tabPage1;
		private ListBox listBoxStudents;
		private ListBox listBoxTeachers;
	}
}
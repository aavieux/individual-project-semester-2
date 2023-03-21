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
            tabControlManager = new TabControl();
            manageUsers_tab = new TabPage();
            listBoxTeachers = new ListBox();
            listBoxStudents = new ListBox();
            viewFeedback_tab = new TabPage();
            listBoxFeedbacks = new ListBox();
            tabControlManager.SuspendLayout();
            manageUsers_tab.SuspendLayout();
            viewFeedback_tab.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlManager
            // 
            tabControlManager.Controls.Add(manageUsers_tab);
            tabControlManager.Controls.Add(viewFeedback_tab);
            tabControlManager.Location = new Point(12, 66);
            tabControlManager.Name = "tabControlManager";
            tabControlManager.SelectedIndex = 0;
            tabControlManager.Size = new Size(1300, 510);
            tabControlManager.TabIndex = 0;
            tabControlManager.SelectedIndexChanged += tabControlManager_SelectedIndexChanged;
            // 
            // manageUsers_tab
            // 
            manageUsers_tab.Controls.Add(listBoxTeachers);
            manageUsers_tab.Controls.Add(listBoxStudents);
            manageUsers_tab.Location = new Point(4, 24);
            manageUsers_tab.Name = "manageUsers_tab";
            manageUsers_tab.Padding = new Padding(3);
            manageUsers_tab.Size = new Size(1292, 482);
            manageUsers_tab.TabIndex = 0;
            manageUsers_tab.Text = "Manage Users";
            manageUsers_tab.UseVisualStyleBackColor = true;
            // 
            // listBoxTeachers
            // 
            listBoxTeachers.FormattingEnabled = true;
            listBoxTeachers.ItemHeight = 15;
            listBoxTeachers.Location = new Point(6, 247);
            listBoxTeachers.Name = "listBoxTeachers";
            listBoxTeachers.Size = new Size(753, 229);
            listBoxTeachers.TabIndex = 1;
            // 
            // listBoxStudents
            // 
            listBoxStudents.FormattingEnabled = true;
            listBoxStudents.ItemHeight = 15;
            listBoxStudents.Location = new Point(6, 6);
            listBoxStudents.Name = "listBoxStudents";
            listBoxStudents.Size = new Size(753, 229);
            listBoxStudents.TabIndex = 0;
            listBoxStudents.MouseDoubleClick += listBoxStudents_MouseDoubleClick;
            // 
            // viewFeedback_tab
            // 
            viewFeedback_tab.Controls.Add(listBoxFeedbacks);
            viewFeedback_tab.Location = new Point(4, 24);
            viewFeedback_tab.Name = "viewFeedback_tab";
            viewFeedback_tab.Size = new Size(1292, 482);
            viewFeedback_tab.TabIndex = 1;
            viewFeedback_tab.Text = "Feedback Tickets";
            viewFeedback_tab.UseVisualStyleBackColor = true;
            // 
            // listBoxFeedbacks
            // 
            listBoxFeedbacks.FormattingEnabled = true;
            listBoxFeedbacks.ItemHeight = 15;
            listBoxFeedbacks.Location = new Point(3, 3);
            listBoxFeedbacks.Name = "listBoxFeedbacks";
            listBoxFeedbacks.Size = new Size(1278, 469);
            listBoxFeedbacks.TabIndex = 0;
            // 
            // connectedUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1324, 588);
            Controls.Add(tabControlManager);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "connectedUser";
            Text = "connectedUser";
            tabControlManager.ResumeLayout(false);
            manageUsers_tab.ResumeLayout(false);
            viewFeedback_tab.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlManager;
        private TabPage manageUsers_tab;
        private ListBox listBoxStudents;
        private ListBox listBoxTeachers;
        private TabPage viewFeedback_tab;
        private ListBox listBoxFeedbacks;
    }
}
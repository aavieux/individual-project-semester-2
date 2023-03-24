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
            manageClasses_tab = new TabPage();
            addClass_btn = new Button();
            listBoxClasses = new ListBox();
            manageFeedbacks_tab = new TabPage();
            listBoxFeedbacks = new ListBox();
            tabControlManager.SuspendLayout();
            manageUsers_tab.SuspendLayout();
            manageClasses_tab.SuspendLayout();
            manageFeedbacks_tab.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlManager
            // 
            tabControlManager.Controls.Add(manageUsers_tab);
            tabControlManager.Controls.Add(manageClasses_tab);
            tabControlManager.Controls.Add(manageFeedbacks_tab);
            tabControlManager.Location = new Point(12, 12);
            tabControlManager.Name = "tabControlManager";
            tabControlManager.SelectedIndex = 0;
            tabControlManager.Size = new Size(772, 492);
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
            manageUsers_tab.Size = new Size(764, 464);
            manageUsers_tab.TabIndex = 0;
            manageUsers_tab.Text = "Manage Users";
            manageUsers_tab.UseVisualStyleBackColor = true;
            // 
            // listBoxTeachers
            // 
            listBoxTeachers.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            listBoxTeachers.FormattingEnabled = true;
            listBoxTeachers.ItemHeight = 28;
            listBoxTeachers.Location = new Point(6, 232);
            listBoxTeachers.Name = "listBoxTeachers";
            listBoxTeachers.Size = new Size(753, 228);
            listBoxTeachers.TabIndex = 1;
            listBoxTeachers.MouseDoubleClick += listBoxTeachers_MouseDoubleClick;
            // 
            // listBoxStudents
            // 
            listBoxStudents.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            listBoxStudents.FormattingEnabled = true;
            listBoxStudents.ItemHeight = 28;
            listBoxStudents.Location = new Point(6, 6);
            listBoxStudents.Name = "listBoxStudents";
            listBoxStudents.Size = new Size(753, 200);
            listBoxStudents.TabIndex = 0;
            listBoxStudents.MouseDoubleClick += listBoxStudents_MouseDoubleClick;
            // 
            // manageClasses_tab
            // 
            manageClasses_tab.Controls.Add(addClass_btn);
            manageClasses_tab.Controls.Add(listBoxClasses);
            manageClasses_tab.Location = new Point(4, 24);
            manageClasses_tab.Name = "manageClasses_tab";
            manageClasses_tab.Size = new Size(764, 464);
            manageClasses_tab.TabIndex = 2;
            manageClasses_tab.Text = "Manage Classes";
            manageClasses_tab.UseVisualStyleBackColor = true;
            // 
            // addClass_btn
            // 
            addClass_btn.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            addClass_btn.Location = new Point(429, 394);
            addClass_btn.Name = "addClass_btn";
            addClass_btn.Size = new Size(332, 61);
            addClass_btn.TabIndex = 1;
            addClass_btn.Text = "Add a Class";
            addClass_btn.UseVisualStyleBackColor = true;
            addClass_btn.Click += addClass_btn_Click;
            // 
            // listBoxClasses
            // 
            listBoxClasses.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            listBoxClasses.FormattingEnabled = true;
            listBoxClasses.ItemHeight = 28;
            listBoxClasses.Location = new Point(3, 3);
            listBoxClasses.Name = "listBoxClasses";
            listBoxClasses.Size = new Size(420, 452);
            listBoxClasses.TabIndex = 0;
            listBoxClasses.MouseDoubleClick += listBoxClasses_MouseDoubleClick;
            // 
            // manageFeedbacks_tab
            // 
            manageFeedbacks_tab.Controls.Add(listBoxFeedbacks);
            manageFeedbacks_tab.Location = new Point(4, 24);
            manageFeedbacks_tab.Name = "manageFeedbacks_tab";
            manageFeedbacks_tab.Size = new Size(764, 464);
            manageFeedbacks_tab.TabIndex = 1;
            manageFeedbacks_tab.Text = "Feedback Tickets";
            manageFeedbacks_tab.UseVisualStyleBackColor = true;
            // 
            // listBoxFeedbacks
            // 
            listBoxFeedbacks.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            listBoxFeedbacks.FormattingEnabled = true;
            listBoxFeedbacks.ItemHeight = 28;
            listBoxFeedbacks.Location = new Point(3, 3);
            listBoxFeedbacks.Name = "listBoxFeedbacks";
            listBoxFeedbacks.Size = new Size(758, 452);
            listBoxFeedbacks.TabIndex = 0;
            listBoxFeedbacks.MouseDoubleClick += listBoxFeedbacks_MouseDoubleClick;
            // 
            // connectedUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(791, 511);
            Controls.Add(tabControlManager);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "connectedUser";
            Text = "connectedUser";
            tabControlManager.ResumeLayout(false);
            manageUsers_tab.ResumeLayout(false);
            manageClasses_tab.ResumeLayout(false);
            manageFeedbacks_tab.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlManager;
        private TabPage manageUsers_tab;
        private ListBox listBoxStudents;
        private ListBox listBoxTeachers;
        private TabPage manageFeedbacks_tab;
        private ListBox listBoxFeedbacks;
        private TabPage manageClasses_tab;
        private ListBox listBoxClasses;
        private Button addClass_btn;
    }
}
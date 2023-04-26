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
            searchByName_lbl = new Label();
            searchByName_txt = new TextBox();
            addUser_btn = new Button();
            teachers_lbl = new Label();
            students_lbl = new Label();
            listBoxTeachers = new ListBox();
            listBoxStudents = new ListBox();
            manageClasses_tab = new TabPage();
            search_lbl = new Label();
            search_txt = new TextBox();
            addClass_btn = new Button();
            listBoxClasses = new ListBox();
            manageFeedbacks_tab = new TabPage();
            label3 = new Label();
            label2 = new Label();
            listBoxFeedbacksClosed = new ListBox();
            status3_lbl = new Label();
            listBoxFeedbacksInProgress = new ListBox();
            status2_lbl = new Label();
            label1 = new Label();
            status1_lbl = new Label();
            listBoxFeedbacksOpen = new ListBox();
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
            manageUsers_tab.Controls.Add(searchByName_lbl);
            manageUsers_tab.Controls.Add(searchByName_txt);
            manageUsers_tab.Controls.Add(addUser_btn);
            manageUsers_tab.Controls.Add(teachers_lbl);
            manageUsers_tab.Controls.Add(students_lbl);
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
            // searchByName_lbl
            // 
            searchByName_lbl.AutoSize = true;
            searchByName_lbl.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            searchByName_lbl.Location = new Point(3, 16);
            searchByName_lbl.Name = "searchByName_lbl";
            searchByName_lbl.Size = new Size(150, 28);
            searchByName_lbl.TabIndex = 6;
            searchByName_lbl.Text = "Search by name";
            // 
            // searchByName_txt
            // 
            searchByName_txt.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            searchByName_txt.Location = new Point(3, 47);
            searchByName_txt.Name = "searchByName_txt";
            searchByName_txt.Size = new Size(758, 34);
            searchByName_txt.TabIndex = 5;
            searchByName_txt.TextChanged += searchByName_txt_TextChanged;
            // 
            // addUser_btn
            // 
            addUser_btn.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            addUser_btn.Location = new Point(6, 411);
            addUser_btn.Name = "addUser_btn";
            addUser_btn.Size = new Size(236, 48);
            addUser_btn.TabIndex = 4;
            addUser_btn.Text = "Add a new user";
            addUser_btn.UseVisualStyleBackColor = true;
            addUser_btn.Click += addUser_btn_Click;
            // 
            // teachers_lbl
            // 
            teachers_lbl.AutoSize = true;
            teachers_lbl.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            teachers_lbl.Location = new Point(324, 258);
            teachers_lbl.Name = "teachers_lbl";
            teachers_lbl.Size = new Size(94, 28);
            teachers_lbl.TabIndex = 3;
            teachers_lbl.Text = "Teachers";
            // 
            // students_lbl
            // 
            students_lbl.AutoSize = true;
            students_lbl.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            students_lbl.Location = new Point(324, 89);
            students_lbl.Name = "students_lbl";
            students_lbl.Size = new Size(95, 28);
            students_lbl.TabIndex = 2;
            students_lbl.Text = "Students";
            // 
            // listBoxTeachers
            // 
            listBoxTeachers.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            listBoxTeachers.FormattingEnabled = true;
            listBoxTeachers.ItemHeight = 28;
            listBoxTeachers.Location = new Point(5, 289);
            listBoxTeachers.Name = "listBoxTeachers";
            listBoxTeachers.Size = new Size(753, 116);
            listBoxTeachers.TabIndex = 1;
            listBoxTeachers.MouseClick += listBoxTeachers_MouseClick;
            listBoxTeachers.MouseDoubleClick += listBoxTeachers_MouseDoubleClick;
            // 
            // listBoxStudents
            // 
            listBoxStudents.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            listBoxStudents.FormattingEnabled = true;
            listBoxStudents.ItemHeight = 28;
            listBoxStudents.Location = new Point(6, 129);
            listBoxStudents.Name = "listBoxStudents";
            listBoxStudents.Size = new Size(753, 116);
            listBoxStudents.TabIndex = 0;
            listBoxStudents.MouseClick += listBoxStudents_MouseClick;
            listBoxStudents.MouseDoubleClick += listBoxStudents_MouseDoubleClick;
            // 
            // manageClasses_tab
            // 
            manageClasses_tab.Controls.Add(search_lbl);
            manageClasses_tab.Controls.Add(search_txt);
            manageClasses_tab.Controls.Add(addClass_btn);
            manageClasses_tab.Controls.Add(listBoxClasses);
            manageClasses_tab.Location = new Point(4, 24);
            manageClasses_tab.Name = "manageClasses_tab";
            manageClasses_tab.Size = new Size(764, 464);
            manageClasses_tab.TabIndex = 2;
            manageClasses_tab.Text = "Manage Classes";
            manageClasses_tab.UseVisualStyleBackColor = true;
            // 
            // search_lbl
            // 
            search_lbl.AutoSize = true;
            search_lbl.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            search_lbl.Location = new Point(3, 16);
            search_lbl.Name = "search_lbl";
            search_lbl.Size = new Size(150, 28);
            search_lbl.TabIndex = 4;
            search_lbl.Text = "Search by name";
            // 
            // search_txt
            // 
            search_txt.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            search_txt.Location = new Point(3, 47);
            search_txt.Name = "search_txt";
            search_txt.Size = new Size(758, 34);
            search_txt.TabIndex = 2;
            search_txt.TextChanged += search_txt_TextChanged;
            // 
            // addClass_btn
            // 
            addClass_btn.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            addClass_btn.Location = new Point(3, 404);
            addClass_btn.Name = "addClass_btn";
            addClass_btn.Size = new Size(327, 57);
            addClass_btn.TabIndex = 1;
            addClass_btn.Text = "Add a new class";
            addClass_btn.UseVisualStyleBackColor = true;
            addClass_btn.Click += addClass_btn_Click;
            // 
            // listBoxClasses
            // 
            listBoxClasses.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            listBoxClasses.FormattingEnabled = true;
            listBoxClasses.ItemHeight = 28;
            listBoxClasses.Location = new Point(3, 87);
            listBoxClasses.Name = "listBoxClasses";
            listBoxClasses.Size = new Size(758, 312);
            listBoxClasses.TabIndex = 0;
            listBoxClasses.MouseDoubleClick += listBoxClasses_MouseDoubleClick;
            // 
            // manageFeedbacks_tab
            // 
            manageFeedbacks_tab.Controls.Add(label3);
            manageFeedbacks_tab.Controls.Add(label2);
            manageFeedbacks_tab.Controls.Add(listBoxFeedbacksClosed);
            manageFeedbacks_tab.Controls.Add(status3_lbl);
            manageFeedbacks_tab.Controls.Add(listBoxFeedbacksInProgress);
            manageFeedbacks_tab.Controls.Add(status2_lbl);
            manageFeedbacks_tab.Controls.Add(label1);
            manageFeedbacks_tab.Controls.Add(status1_lbl);
            manageFeedbacks_tab.Controls.Add(listBoxFeedbacksOpen);
            manageFeedbacks_tab.Location = new Point(4, 24);
            manageFeedbacks_tab.Name = "manageFeedbacks_tab";
            manageFeedbacks_tab.Size = new Size(764, 464);
            manageFeedbacks_tab.TabIndex = 1;
            manageFeedbacks_tab.Text = "Feedback Tickets";
            manageFeedbacks_tab.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Maroon;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ActiveCaption;
            label3.Location = new Point(148, 316);
            label3.Name = "label3";
            label3.Size = new Size(23, 21);
            label3.TabIndex = 8;
            label3.Text = "   ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Gold;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaption;
            label2.Location = new Point(191, 166);
            label2.Name = "label2";
            label2.Size = new Size(23, 21);
            label2.TabIndex = 7;
            label2.Text = "   ";
            // 
            // listBoxFeedbacksClosed
            // 
            listBoxFeedbacksClosed.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            listBoxFeedbacksClosed.FormattingEnabled = true;
            listBoxFeedbacksClosed.ItemHeight = 28;
            listBoxFeedbacksClosed.Location = new Point(3, 345);
            listBoxFeedbacksClosed.Name = "listBoxFeedbacksClosed";
            listBoxFeedbacksClosed.Size = new Size(758, 116);
            listBoxFeedbacksClosed.TabIndex = 6;
            listBoxFeedbacksClosed.MouseClick += listBoxFeedbacksClosed_MouseClick;
            listBoxFeedbacksClosed.MouseDoubleClick += listBoxFeedbacksClosed_MouseDoubleClick;
            // 
            // status3_lbl
            // 
            status3_lbl.AutoSize = true;
            status3_lbl.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            status3_lbl.Location = new Point(3, 309);
            status3_lbl.Name = "status3_lbl";
            status3_lbl.Size = new Size(139, 28);
            status3_lbl.TabIndex = 5;
            status3_lbl.Text = "Status Closed";
            // 
            // listBoxFeedbacksInProgress
            // 
            listBoxFeedbacksInProgress.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            listBoxFeedbacksInProgress.FormattingEnabled = true;
            listBoxFeedbacksInProgress.ItemHeight = 28;
            listBoxFeedbacksInProgress.Location = new Point(3, 190);
            listBoxFeedbacksInProgress.Name = "listBoxFeedbacksInProgress";
            listBoxFeedbacksInProgress.Size = new Size(758, 116);
            listBoxFeedbacksInProgress.TabIndex = 4;
            listBoxFeedbacksInProgress.MouseClick += listBoxFeedbacksInProgress_MouseClick;
            listBoxFeedbacksInProgress.MouseDoubleClick += listBoxFeedbacksInProgress_MouseDoubleClick;
            // 
            // status2_lbl
            // 
            status2_lbl.AutoSize = true;
            status2_lbl.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            status2_lbl.Location = new Point(3, 159);
            status2_lbl.Name = "status2_lbl";
            status2_lbl.Size = new Size(182, 28);
            status2_lbl.TabIndex = 3;
            status2_lbl.Text = "Status In Progress";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Green;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaption;
            label1.Location = new Point(136, 16);
            label1.Name = "label1";
            label1.Size = new Size(23, 21);
            label1.TabIndex = 2;
            label1.Text = "   ";
            // 
            // status1_lbl
            // 
            status1_lbl.AutoSize = true;
            status1_lbl.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            status1_lbl.Location = new Point(3, 9);
            status1_lbl.Name = "status1_lbl";
            status1_lbl.Size = new Size(127, 28);
            status1_lbl.TabIndex = 1;
            status1_lbl.Text = "Status Open";
            // 
            // listBoxFeedbacksOpen
            // 
            listBoxFeedbacksOpen.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            listBoxFeedbacksOpen.FormattingEnabled = true;
            listBoxFeedbacksOpen.ItemHeight = 28;
            listBoxFeedbacksOpen.Location = new Point(3, 40);
            listBoxFeedbacksOpen.Name = "listBoxFeedbacksOpen";
            listBoxFeedbacksOpen.Size = new Size(758, 116);
            listBoxFeedbacksOpen.TabIndex = 0;
            listBoxFeedbacksOpen.MouseClick += listBoxFeedbacksOpen_MouseClick;
            listBoxFeedbacksOpen.MouseDoubleClick += listBoxFeedbacks_MouseDoubleClick;
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
            manageUsers_tab.PerformLayout();
            manageClasses_tab.ResumeLayout(false);
            manageClasses_tab.PerformLayout();
            manageFeedbacks_tab.ResumeLayout(false);
            manageFeedbacks_tab.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlManager;
        private TabPage manageUsers_tab;
        private ListBox listBoxStudents;
        private ListBox listBoxTeachers;
        private TabPage manageFeedbacks_tab;
        private ListBox listBoxFeedbacksOpen;
        private TabPage manageClasses_tab;
        private ListBox listBoxClasses;
        private Button addClass_btn;
        private Label teachers_lbl;
        private Label students_lbl;
        private Label search_lbl;
        private TextBox search_txt;
        private ListBox listBoxFeedbacksClosed;
        private Label status3_lbl;
        private ListBox listBoxFeedbacksInProgress;
        private Label status2_lbl;
        private Label label1;
        private Label status1_lbl;
        private Label label3;
        private Label label2;
        private Button addUser_btn;
        private Label searchByName_lbl;
        private TextBox searchByName_txt;
    }
}
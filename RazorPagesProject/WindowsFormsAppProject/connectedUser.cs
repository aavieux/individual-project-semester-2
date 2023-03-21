using ClassLibrary.Controllers;
using ClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppProject
{
    public partial class connectedUser : Form
    {
        UserManager userManager;
        FeedbackManager feedbackManager;
        public connectedUser()
        {
            userManager = new UserManager();
            feedbackManager = new FeedbackManager();
            InitializeComponent();
            DisplayData();
        }
        private void DisplayData()
        {
            //teachers
            listBoxTeachers.Items.Clear();
            foreach (Teacher teacher in userManager.GetAllTeachers())
            {
                listBoxTeachers.Items.Add($"UserID: {teacher.Userid} - {teacher.GetFullName()} - {teacher.Role} - Class: {teacher.Class}");
            }
            //students
            listBoxStudents.Items.Clear();
            foreach (Student student in userManager.GetAllStudents())
            {
                listBoxStudents.Items.Add($"UserID: {student.Userid} - {student.GetFullName()} - {student.Role} - Class: {student.Class}");
            }
        }

        private void listBoxStudents_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int start = listBoxStudents.SelectedItem.ToString().IndexOf(":") + 2; // Adding 2 to exclude the ": " characters
            int end = listBoxStudents.SelectedItem.ToString().IndexOf(" -");
            int userId = int.Parse(listBoxStudents.SelectedItem.ToString().Substring(start, end - start));

            this.Hide();
            userView userView = new userView(userId);
            userView.ShowDialog();
            this.Show();
        }

        private void tabControlManager_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlManager.SelectedTab.Name == "viewFeedback_tab")
            {
                listBoxFeedbacks.Items.Clear();
                foreach (Feedback feedback in feedbackManager.GetAllFeedbacks())
                {
                    listBoxFeedbacks.Items.Add($"{feedback.IdTicket} - {feedback.FirstNameContact} {feedback.LastNameContact} says: {feedback.SubjectContact}");
                }
            }
        }
    }
}

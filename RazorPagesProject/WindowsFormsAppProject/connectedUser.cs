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
        ClassManager classManager;
        FeedbackManager feedbackManager;
        public connectedUser()
        {
            userManager = new UserManager();
            classManager = new ClassManager();
            feedbackManager = new FeedbackManager();
            InitializeComponent();
            DisplayUserData();
        }
        private void DisplayFeedbackData()
        {
            listBoxFeedbacks.Items.Clear();
            foreach (Feedback feedback in feedbackManager.GetAllFeedbacks())
            {
                listBoxFeedbacks.Items.Add($"{feedback.IdTicket} - {feedback.FirstNameContact} {feedback.LastNameContact}, Subject: {feedback.SubjectContact}");
            }
        }
        private void DisplayUserData()
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
        private void DisplayClassData()
        {
            listBoxClasses.Items.Clear();
            foreach (Class currentClass in classManager.GetAllClasses())
            {
                listBoxClasses.Items.Add($"Class Name: {currentClass.Name}, Class Teacher: {userManager.GetTeacherById(currentClass.TeacherID).GetFullName()}");
            }
        }

        private void listBoxStudents_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                int start = listBoxStudents.SelectedItem.ToString().IndexOf(":") + 2; // Adding 2 to exclude the ": " characters
                int end = listBoxStudents.SelectedItem.ToString().IndexOf(" -");
                int userId = int.Parse(listBoxStudents.SelectedItem.ToString().Substring(start, end - start));

                this.Hide();
                userView userView = new userView(userId);
                userView.ShowDialog();
                listBoxStudents.SelectedIndex = -1;
                listBoxTeachers.SelectedIndex = -1;
                this.Show();
            }
            catch (Exception){}
        }

        private void tabControlManager_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlManager.SelectedTab.Name == "manageUsers_tab")
            {
                DisplayUserData();
            }
            else if (tabControlManager.SelectedTab.Name == "manageClasses_tab")
            {
                DisplayClassData();
            }
            else if (tabControlManager.SelectedTab.Name == "manageFeedbacks_tab")
            {
                DisplayFeedbackData();
            }
        }

        private void listBoxFeedbacks_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                int idTicket = int.Parse(listBoxFeedbacks.SelectedItem.ToString().Substring(0, listBoxFeedbacks.SelectedItem.ToString().IndexOf(" ")));

                this.Hide();
                feedbackView feedbackView = new feedbackView(idTicket);
                feedbackView.ShowDialog();
                listBoxFeedbacks.SelectedIndex = -1;
                this.Show();
            }
            catch (Exception){}
        }

        private void listBoxClasses_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                string inputString = listBoxClasses.SelectedItem.ToString();
                string prefix = "Class Name: ";
                string suffix = ",";
                int startIndex = inputString.IndexOf(prefix) + prefix.Length;
                int endIndex = inputString.IndexOf(suffix, startIndex);
                int idClass = int.Parse(inputString.Substring(startIndex, endIndex - startIndex));

                this.Hide();

                classView classView = new classView(idClass);
                classView.ShowDialog();
                listBoxClasses.SelectedIndex = -1;
                this.Show();
            }
            catch (Exception) { }
        }
    }
}

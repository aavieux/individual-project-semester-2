using ClassLibrary.Controllers;
using ClassLibrary.Mapper;
using ClassLibrary.Models;
using DataBaseClassLibrary.DatabaseHelpers;
using Microsoft.Extensions.Configuration;
using Microsoft.VisualBasic.ApplicationServices;
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
        internal UserDatabaseHelper userDbHelper;
        internal ClassDatabaseHelper classDbHelper;
        internal GradeDatabaseHelper gradeDbHelper;
        internal FeedbackDatabaseHelper feedbackDbHelper;

        internal UserMapper userMapper;
        internal ClassMapper classMapper;
        internal GradeMapper gradeMapper;
        internal FeedbackMapper feedbackMapper;

        internal FeedbackManager feedbackManager;
        internal StatisticsManager statisticsManager;
        internal IConfiguration configuration;
        public connectedUser(Manager manager)
        {
            this.classDbHelper = new ClassDatabaseHelper();
            this.userDbHelper = new UserDatabaseHelper();
            this.gradeDbHelper = new GradeDatabaseHelper();
            this.feedbackDbHelper = new FeedbackDatabaseHelper();

            this.classMapper = new ClassMapper(classDbHelper, userDbHelper, gradeDbHelper);
            this.userMapper = new UserMapper(userDbHelper, gradeDbHelper);
            this.gradeMapper = new GradeMapper(gradeDbHelper);
            this.feedbackMapper = new FeedbackMapper(feedbackDbHelper);

            this.feedbackManager = new FeedbackManager(feedbackDbHelper,feedbackMapper);
            statisticsManager = new StatisticsManager(classDbHelper, classMapper, userDbHelper, userMapper, gradeDbHelper, gradeMapper);

            InitializeComponent();
            DisplayUserData();
            this.Text = $"Connected as {manager.GetFullName()}";
        }
        private void DisplayFeedbackData()
        {
            listBoxFeedbacksOpen.Items.Clear();
            listBoxFeedbacksInProgress.Items.Clear();
            listBoxFeedbacksClosed.Items.Clear();

            foreach (Feedback feedback in feedbackManager.GetAllFeedbacks())
            {
                if (feedback.StatusContact == ClassLibrary.Models.Enums.Status.OPEN)
                {
                    listBoxFeedbacksOpen.Items.Add($"{feedback.IdTicket} - {feedback.FirstNameContact} {feedback.LastNameContact}, Subject: {feedback.SubjectContact}");
                }
                else if (feedback.StatusContact == ClassLibrary.Models.Enums.Status.IN_PROGRESS)
                {
                    listBoxFeedbacksInProgress.Items.Add($"{feedback.IdTicket} - {feedback.FirstNameContact} {feedback.LastNameContact}, Subject: {feedback.SubjectContact}");
                }
                else if (feedback.StatusContact == ClassLibrary.Models.Enums.Status.CLOSED)
                {
                    listBoxFeedbacksClosed.Items.Add($"{feedback.IdTicket} - {feedback.FirstNameContact} {feedback.LastNameContact}, Subject: {feedback.SubjectContact}");
                }

            }
        }
        private void DisplayUserData()
        {
            //teachers
            listBoxTeachers.Items.Clear();
            foreach (Teacher teacher in statisticsManager.GetAllTeachers())
            {
                listBoxTeachers.Items.Add($"UserID: {teacher.Userid} - {teacher.GetFullName()} - {teacher.Role} - Class: {teacher.Class}");
            }
            //students
            listBoxStudents.Items.Clear();
            foreach (Student student in statisticsManager.GetAllStudents())
            {
                listBoxStudents.Items.Add($"UserID: {student.Userid} - {student.GetFullName()} - {student.Role} - Class: {student.Class}");
            }
        }
        private void DisplayClassData()
        {
            listBoxClasses.Items.Clear();
            foreach (Class currentClass in statisticsManager.GetAllClasses())
            {
                listBoxClasses.Items.Add($"Class Name: {currentClass.Name}");
            }
        }

        private void listBoxStudents_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                int start = listBoxStudents.SelectedItem.ToString().IndexOf(":") + 2; // Adding 2 to exclude the ": " characters
                int end = listBoxStudents.SelectedItem.ToString().IndexOf(" -");
                int userId = int.Parse(listBoxStudents.SelectedItem.ToString().Substring(start, end - start));
                userView userView = new userView(statisticsManager, userDbHelper, gradeDbHelper,userId);
                userView.ShowDialog();
                DisplayUserData();
                listBoxStudents.SelectedIndex = -1;
                listBoxTeachers.SelectedIndex = -1;
            }
            catch (Exception) { }
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

        private void listBoxFeedbacks_MouseDoubleClick(object sender, MouseEventArgs e) // open
        {
            try
            {
                int idTicket = int.Parse(listBoxFeedbacksOpen.SelectedItem.ToString().Substring(0, listBoxFeedbacksOpen.SelectedItem.ToString().IndexOf(" ")));

                feedbackView feedbackView = new feedbackView(feedbackDbHelper, feedbackManager, idTicket);
                feedbackView.ShowDialog();
                DisplayFeedbackData();
                listBoxFeedbacksOpen.SelectedIndex = -1;
            }
            catch (Exception) { }
        }
        private void listBoxFeedbacksInProgress_MouseDoubleClick(object sender, MouseEventArgs e) // in progress
        {
            try
            {
                int idTicket = int.Parse(listBoxFeedbacksInProgress.SelectedItem.ToString().Substring(0, listBoxFeedbacksInProgress.SelectedItem.ToString().IndexOf(" ")));
                feedbackView feedbackView = new feedbackView(feedbackDbHelper,feedbackManager, idTicket);
                feedbackView.ShowDialog();
                DisplayFeedbackData();
                listBoxFeedbacksInProgress.SelectedIndex = -1;
            }
            catch (Exception) { }
        }

        private void listBoxFeedbacksClosed_MouseDoubleClick(object sender, MouseEventArgs e) // closed
        {
            try
            {
                int idTicket = int.Parse(listBoxFeedbacksClosed.SelectedItem.ToString().Substring(0, listBoxFeedbacksClosed.SelectedItem.ToString().IndexOf(" ")));

                feedbackView feedbackView = new feedbackView(feedbackDbHelper, feedbackManager, idTicket);
                feedbackView.ShowDialog();
                DisplayFeedbackData();
                listBoxFeedbacksClosed.SelectedIndex = -1;
            }
            catch (Exception) { }
        }

        private void listBoxClasses_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                string inputString = listBoxClasses.SelectedItem.ToString();

                int index = inputString.IndexOf(':'); // Find the index of the colon
                string result = inputString.Substring(index + 2);

                int idClass = int.Parse(result);

                classView classView = new classView(statisticsManager, idClass);
                classView.ShowDialog();
                DisplayClassData();
                listBoxClasses.SelectedIndex = -1;
                search_txt.Text = string.Empty;
            }
            catch (Exception) { }
        }

        private void listBoxTeachers_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                int start = listBoxTeachers.SelectedItem.ToString().IndexOf(":") + 2; // Adding 2 to exclude the ": " characters
                int end = listBoxTeachers.SelectedItem.ToString().IndexOf(" -");
                int userId = int.Parse(listBoxTeachers.SelectedItem.ToString().Substring(start, end - start));

                userView userView = new userView(statisticsManager, userDbHelper, gradeDbHelper, userId);
                userView.ShowDialog();
                DisplayUserData();
                listBoxStudents.SelectedIndex = -1;
                listBoxTeachers.SelectedIndex = -1;
            }
            catch (Exception) { }
        }

        private void addClass_btn_Click(object sender, EventArgs e)
        {
            addClass addClass = new addClass(statisticsManager, classDbHelper, userDbHelper, gradeDbHelper);
            addClass.ShowDialog();
            DisplayClassData();
            DisplayUserData();
        }

        private void listBoxTeachers_MouseClick(object sender, MouseEventArgs e)
        {
            listBoxStudents.SelectedIndex = -1;
        }

        private void listBoxStudents_MouseClick(object sender, MouseEventArgs e)
        {
            listBoxTeachers.SelectedIndex = -1;
        }

        private void showAll_btn_Click(object sender, EventArgs e)
        {
            DisplayClassData();
        }

        private void search_txt_TextChanged(object sender, EventArgs e)
        {
            listBoxClasses.Items.Clear();
            string search = search_txt.Text;
            foreach (Class @class in statisticsManager.GetAllClasses())
            {
                if (@class.Name.ToString().Contains(search))
                {
                    listBoxClasses.Items.Add($"Class Name: {@class.Name}");
                }
            }
        }

        private void listBoxFeedbacksOpen_MouseClick(object sender, MouseEventArgs e)
        {
            listBoxFeedbacksInProgress.SelectedIndex = -1;
            listBoxFeedbacksClosed.SelectedIndex = -1;
        }

        private void listBoxFeedbacksInProgress_MouseClick(object sender, MouseEventArgs e)
        {
            listBoxFeedbacksOpen.SelectedIndex = -1;
            listBoxFeedbacksClosed.SelectedIndex = -1;
        }

        private void listBoxFeedbacksClosed_MouseClick(object sender, MouseEventArgs e)
        {
            listBoxFeedbacksOpen.SelectedIndex = -1;
            listBoxFeedbacksInProgress.SelectedIndex = -1;
        }

        private void addUser_btn_Click(object sender, EventArgs e)
        {
            addUser addUser = new addUser(statisticsManager,userDbHelper,gradeDbHelper,userMapper);
            addUser.ShowDialog();
            DisplayUserData();
        }

        private void searchByName_txt_TextChanged(object sender, EventArgs e)
        {
            listBoxStudents.Items.Clear();
            listBoxTeachers.Items.Clear();

            string search = searchByName_txt.Text;

            foreach (Student student in statisticsManager.GetAllStudents())
            {
                if (student.GetFullName().ToLower().Contains(search.ToLower()))
                {
                    listBoxStudents.Items.Add($"UserID: {student.Userid} - {student.GetFullName()} - {student.Role} - Class: {student.Class}");
                }
            }

            foreach (Teacher teacher in statisticsManager.GetAllTeachers())
            {
                if (teacher.GetFullName().ToLower().Contains(search.ToLower()))
                {
                    listBoxTeachers.Items.Add($"UserID: {teacher.Userid} - {teacher.GetFullName()} - {teacher.Role} - Class: {teacher.Class}");
                }
            }

        }
    }
}

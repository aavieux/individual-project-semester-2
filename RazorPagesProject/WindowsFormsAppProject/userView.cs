using ClassLibrary.Controllers;
using ClassLibrary.Models;
using ClassLibrary.Models.Enums;
using DataBaseClassLibrary.DatabaseHelpers;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsAppProject
{
    public partial class userView : Form
    {
        private StatisticsManager statisticsManager;
        private UserManager userManager;
        private UserDatabaseHelper userDbHelper;
        private GradeDatabaseHelper gradeDbHelper;
        int userId;

        public userView(StatisticsManager statisticsManager, UserDatabaseHelper userDatabaseHelper, GradeDatabaseHelper gradeDatabaseHelper, int userId)
        {
            this.statisticsManager = statisticsManager;
            //this.userManager = userManager;
            this.userDbHelper = userDatabaseHelper;
            this.gradeDbHelper = gradeDatabaseHelper;
            this.userId = userId;

            InitializeComponent();
            GenerateDropdowns();
            ClearFields();
            DisplayContent();
        }
        private void DisplayError()
        {

        }
        private void GenerateDropdowns()
        {
            foreach (Class currentClass in statisticsManager.GetAllClasses())
            {
                class_comboBox.Items.Add(currentClass.Name);
            }
            foreach (Role role in Enum.GetValues(typeof(Role)))
            {
                role_comboBox.Items.Add(role.ToString());
            }
            if (statisticsManager.GetUserById(userId).Role == Role.STUDENT)
            {
                subject_clb.Items.Clear();

                //Get available subjects that can be added (excluding the existing ones)
                Subject[] availableSubjectsToAdd = (Subject[])Enum.GetValues(typeof(Subject));
                foreach (Subject subject in Enum.GetValues(typeof(Subject)))
                {
                    foreach (SubjectGrades subjectGrades in statisticsManager.GetStudentById(userId).GetGradeBook())
                    {
                        if (subjectGrades.Subject == subject)
                        {
                            availableSubjectsToAdd = availableSubjectsToAdd.Where(x => x != subject).ToArray(); // remove the ones that already exist

                        }
                    }
                }
                foreach (Subject subject1 in availableSubjectsToAdd)
                {
                    subject_clb.Items.Add(subject1.ToString());
                }
            }

        }
        private void ClearFields()
        {
            firstName_txt.Text = string.Empty;
            lastName_txt.Text = string.Empty;
            role_comboBox.SelectedIndex = -1;
            class_comboBox.SelectedIndex = -1;
            email_txt.Text = string.Empty;
            phone_txt.Text = string.Empty;
            userId_txt.Text = string.Empty;
        }
        private void DisplayContent()
        {
            ClassLibrary.Models.User user = statisticsManager.GetUserById(userId);

            firstName_txt.Text = user.Firstname;
            lastName_txt.Text = user.Lastname;
            role_comboBox.SelectedItem = user.Role.ToString();
            class_comboBox.SelectedItem = user.Class;
            email_txt.Text = user.Email;
            phone_txt.Text = user.PhoneNumber;
            userId_txt.Text = user.Userid.ToString();

            firstName_txt.Enabled = false;
            lastName_txt.Enabled = false;
            role_comboBox.Enabled = false;
            class_comboBox.Enabled = false;
            email_txt.Enabled = false;
            phone_txt.Enabled = false;
            userId_txt.Enabled = false;

            saveChanges_btn.Visible = false;
            updateDetails_btn.Visible = true;
            deleteUser_btn.Visible = true;
            promoteUser_btn.Visible = true;

            if (statisticsManager.GetUserById(userId).Role == Role.STUDENT)
            {
                addSG_btn.Visible = true;
            }
            else
            {
                addSG_btn.Visible = false;
            }
            subject_clb.Visible = false;
            saveSG_btn.Visible = false;
            cancel_btn.Visible = false;

        }

        private void updateDetails_btn_Click(object sender, EventArgs e)
        {
            firstName_txt.Enabled = true;
            lastName_txt.Enabled = true;
            role_comboBox.Enabled = true;
            class_comboBox.Enabled = true;
            email_txt.Enabled = true;
            phone_txt.Enabled = true;
            //userId_txt.Enabled = true;

            updateDetails_btn.Visible = false;
            deleteUser_btn.Visible = false;
            promoteUser_btn.Visible = false;

            saveChanges_btn.Visible = true;
            addSG_btn.Visible = false;
        }

        private void saveChanges_btn_Click(object sender, EventArgs e)
        {
            if (firstName_txt.Text != string.Empty &&
                lastName_txt.Text != string.Empty &&
                role_comboBox.SelectedIndex != -1 &&
                email_txt.Text != string.Empty &&
                phone_txt.Text != string.Empty)
            {
                int classId = 0;
                if (class_comboBox.SelectedIndex != -1)
                {
                    classId = int.Parse(class_comboBox.SelectedItem.ToString());
                }
                ClassLibrary.Models.User currentUser = new ClassLibrary.Models.User(
                    userDbHelper,
                    gradeDbHelper,
                    firstName_txt.Text,
                    lastName_txt.Text,
                    Enum.Parse<Role>(role_comboBox.Text),
                    classId,
                    email_txt.Text, phone_txt.Text,
                    int.Parse(userId_txt.Text));

                if (currentUser.Update() == false)
                {
                    DisplayError();
                }
                DisplayContent();
            }
        }

        private void deleteUser_btn_Click(object sender, EventArgs e)
        {
            if (role_comboBox.SelectedItem.ToString() == Role.STUDENT.ToString())
            {
                if (statisticsManager.GetStudentById(int.Parse(userId_txt.Text)).DeleteAllSubjectGradesWithGrades() == false)
                {
                    MessageBox.Show("Could not delete this user's Subject Grades!");
                    DisplayError();
                }
                else
                {
                    MessageBox.Show("Successfully deleted this user's SubjectGrades!");

                }
                if (userManager.Delete(statisticsManager.GetStudentById(int.Parse(userId_txt.Text))) == false)//USERMANAGER_CREATE
                {
                    MessageBox.Show("Could not delete this user!");
                    DisplayError();
                }
                else
                {
                    MessageBox.Show("Successfully deleted this user!");
                    this.Close();
                }
            }
            else
            {
                if (userManager.Delete(statisticsManager.GetTeacherById(int.Parse(userId_txt.Text))) == false)//USERMANAGER_CREATE
                {
                    MessageBox.Show("Could not delete this user!");
                    DisplayError();
                }
                else
                {
                    MessageBox.Show("Successfully deleted this user!");
                    this.Close();

                }
            }

        }

        private void promoteUser_btn_Click(object sender, EventArgs e)
        {
            var user = statisticsManager.GetUserById(userId);
            user.PromoteRole();
            MessageBox.Show("Successfully promoted user!");
            DisplayContent();
        }

        private void addSG_btn_Click(object sender, EventArgs e)
        {
            firstName_txt.Enabled = false;
            lastName_txt.Enabled = false;
            role_comboBox.Enabled = false;
            class_comboBox.Enabled = false;
            email_txt.Enabled = false;
            phone_txt.Enabled = false;
            userId_txt.Enabled = false;

            saveChanges_btn.Visible = false;
            updateDetails_btn.Visible = false;
            deleteUser_btn.Visible = false;
            promoteUser_btn.Visible = false;
            addSG_btn.Visible = false;

            saveSG_btn.Visible = true;
            cancel_btn.Visible = true;
            subject_clb.Visible = true;
        }

        private void saveSG_btn_Click(object sender, EventArgs e)
        {
            try
            {
                List<Subject> subjectsToAdd = new List<Subject>();
                for (int i = 0; i < subject_clb.CheckedItems.Count; i++) // get student names
                {
                    subjectsToAdd.Add(Enum.Parse<Subject>(subject_clb.CheckedItems[i].ToString()));
                }
                foreach (Subject subject in subjectsToAdd)
                {
                    SubjectGrades subjectGrades = new SubjectGrades(gradeDbHelper, subject, userId);
                    statisticsManager.GetStudentById(userId).AddEmptySubjectGrades(subjectGrades);
                }
                MessageBox.Show("Successfully added the Subjects to the Gradebook!");
                GenerateDropdowns();

            }
            catch (Exception)
            {
                DisplayError();
            }
            finally
            {
                DisplayContent();
            }

        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            DisplayContent();
        }
    }
}

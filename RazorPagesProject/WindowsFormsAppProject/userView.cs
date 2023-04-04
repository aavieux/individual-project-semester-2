using ClassLibrary.Controllers;
using ClassLibrary.Models;
using ClassLibrary.Models.Enums;
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
    public partial class userView : Form
    {
        private StatisticsManager statisticsManager;
        int userId;

        public userView(int userId)
        {
            this.statisticsManager = new StatisticsManager();
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

            saveChanges_btn.Visible = true;
        }

        private void saveChanges_btn_Click(object sender, EventArgs e)
        {
            if (firstName_txt.Text != string.Empty &&
                lastName_txt.Text != string.Empty &&
                role_comboBox.SelectedIndex != -1 &&
                class_comboBox.SelectedIndex != -1 &&
                email_txt.Text != string.Empty &&
                phone_txt.Text != string.Empty)
            {
                ClassLibrary.Models.User currentUser = new ClassLibrary.Models.User(
                    firstName_txt.Text,
                    lastName_txt.Text,
                    Enum.Parse<Role>(role_comboBox.Text),
                    int.Parse(class_comboBox.Text),
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
            if (statisticsManager.GetUserById(int.Parse(userId_txt.Text)).Delete() == false)
            {
                DisplayError();
            }
            else
            {
                this.Close();
            }


        }
    }
}

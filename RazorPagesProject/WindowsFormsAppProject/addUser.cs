using ClassLibrary.Controllers;
using ClassLibrary.Models;
using ClassLibrary.Models.Enums;
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
    public partial class addUser : Form
    {
        private StatisticsManager statisticsManager;
        public addUser()
        {
            statisticsManager = new StatisticsManager();
            InitializeComponent();
            GenerateDropdowns();
        }
        private void GenerateDropdowns()
        {
            subject_clb.Visible = false;
            subject_lbl.Visible = false;

            subject_clb.Items.Clear();
            foreach (Subject subjectEnum in Enum.GetValues(typeof(Subject)))
            {
                subject_clb.Items.Add(subjectEnum.ToString());
            }

            role_comboBox.Items.Clear();
            foreach (Role role in Enum.GetValues(typeof(Role)))
            {
                role_comboBox.Items.Add(role.ToString());
            }

            class_comboBox.Items.Clear();
            foreach (Class @class in statisticsManager.GetAllClasses())
            {
                class_comboBox.Items.Add(@class.Name);
            }
        }
        private void addUsesr_btn_Click(object sender, EventArgs e)
        {
            if (firstName_txt.Text != string.Empty &&
                lastName_txt.Text != string.Empty &&
                role_comboBox.SelectedIndex != -1 &&
                class_comboBox.SelectedIndex != -1 &&
                email_txt.Text != string.Empty &&
                phone_txt.Text != string.Empty)
            {
                try
                {
                    if (role_comboBox.SelectedItem.ToString() == Role.STUDENT.ToString())
                    {
                        Student currentStudent = new Student(
                        firstName_txt.Text,
                        lastName_txt.Text,
                        Enum.Parse<Role>(role_comboBox.SelectedIndex.ToString()),
                        int.Parse(class_comboBox.SelectedItem.ToString()),
                        email_txt.Text,
                        phone_txt.Text);

                        currentStudent.Create();

                        List<SubjectGrades> checkedSubjectGrades = new List<SubjectGrades>();
                        for (int i = 0; i < subject_clb.CheckedItems.Count; i++) // get student names
                        {
                            SubjectGrades subjectGrades = new SubjectGrades(Enum.Parse<Subject>(subject_clb.CheckedItems[i].ToString()), currentStudent.Userid);
                            checkedSubjectGrades.Add(subjectGrades);
                        }
                        foreach (SubjectGrades subjectGrades1 in checkedSubjectGrades)
                        {
                            currentStudent.AddEmptySubjectGrades(subjectGrades1);
                        }
                        MessageBox.Show("User created successfully!");

                    }
                    else
                    {
                        Teacher currentTeacher = new Teacher(
                        firstName_txt.Text,
                        lastName_txt.Text,
                        Enum.Parse<Role>(role_comboBox.SelectedIndex.ToString()),
                        int.Parse(class_comboBox.SelectedItem.ToString()),
                        email_txt.Text,
                        phone_txt.Text);

                        currentTeacher.Create();
                        MessageBox.Show("User created successfully!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    firstName_txt.Text = string.Empty;
                    lastName_txt.Text = string.Empty;
                    email_txt.Text = string.Empty;
                    phone_txt.Text = string.Empty;
                    role_comboBox.SelectedIndex = -1;
                    class_comboBox.SelectedIndex = -1;
                    subject_clb.SelectedIndex = -1;

                    subject_clb.Visible = false;
                    subject_lbl.Visible = false;

                    for (int i = 0; i < subject_clb.Items.Count; i++)
                    {
                        subject_clb.SetItemChecked(i, false);
                    }
                }

            }
            else
            {
                MessageBox.Show("Check your input!");
            }
        }

        private void role_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (role_comboBox.SelectedItem.ToString() == Role.STUDENT.ToString())
                {
                    subject_clb.Visible = true;
                    subject_lbl.Visible = true;
                }
                else
                {
                    subject_clb.Visible = false; subject_lbl.Visible = false;
                }
            }
            catch (Exception)
            {
            }

        }
    }
}

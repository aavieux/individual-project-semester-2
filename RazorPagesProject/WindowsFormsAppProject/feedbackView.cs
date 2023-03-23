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
    public partial class feedbackView : Form
    {
        private int idTicket;
        private FeedbackManager feedbackManager;
        public feedbackView(int idTicket)
        {
            feedbackManager = new FeedbackManager();
            this.idTicket = idTicket;
            InitializeComponent();
            LockFields();
            DisplayData();
        }
        private void DisplayError()
        {

        }
        private void GenerateDropdowns()
        {
            changeStatus_comboBox.Items.Clear();
            foreach (Status statusEnum in Enum.GetValues(typeof(Status)))
            {
                changeStatus_comboBox.Items.Add(statusEnum.ToString());
            }
        }
        private void LockFields()
        {
            firstName_txt.Enabled = false;
            lastName_txt.Enabled = false;
            school_txt.Enabled = false;
            email_txt.Enabled = false;
            subject_richTextBox.Enabled = false;
            idTicket_txt.Enabled = false;
            status_txt.Enabled = false;

            //applyChanges_btn.Visible = false;
            //changeStatus_comboBox.Visible = false;
        }
        private void DisplayData()
        {
            applyChanges_btn.Visible = false;
            changeStatus_btn.Visible = true;
            changeStatus_comboBox.Visible = false;

            Feedback feedback = feedbackManager.GetFeedbackById(idTicket);

            firstName_txt.Text = feedback.FirstNameContact;
            lastName_txt.Text = feedback.LastNameContact;
            school_txt.Text = feedback.SchoolContact;
            email_txt.Text = feedback.EmailContact;
            subject_richTextBox.Text = feedback.SubjectContact;
            idTicket_txt.Text = feedback.IdTicket.ToString();

            if (feedback.StatusContact.ToString() == "OPEN")
            {
                status_txt.BackColor = Color.DarkGreen;
            }
            else if (feedback.StatusContact.ToString() == "IN_PROGRESS")
            {
                status_txt.BackColor = Color.Gold;

            }
            else if (feedback.StatusContact.ToString() == "CLOSED")
            {
                status_txt.BackColor = Color.DarkRed;
            }

        }

        private void changeStatus_btn_Click(object sender, EventArgs e)
        {
            changeStatus_btn.Visible = false;
            applyChanges_btn.Visible = true;

            GenerateDropdowns();
            changeStatus_comboBox.Visible = true;

        }

        private void applyChanges_btn_Click(object sender, EventArgs e)
        {
            try
            {
                Feedback feedback = new Feedback(
                int.Parse(idTicket_txt.Text),
                firstName_txt.Text,
                lastName_txt.Text,
                school_txt.Text,
                email_txt.Text,
                subject_richTextBox.Text,
                Enum.Parse<Status>(changeStatus_comboBox.SelectedItem.ToString()));

                if (feedbackManager.UpdateFeedback(feedback) == false)
                {
                    DisplayError();
                }

                DisplayData();
            }
            catch (Exception)
            {
                DisplayData();
            }
        }

        private void contactPerson_btn_Click(object sender, EventArgs e)
        {

        }
    }
}

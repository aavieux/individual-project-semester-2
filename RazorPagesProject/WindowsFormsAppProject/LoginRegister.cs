
using ClassLibrary.Controllers;
using ClassLibrary.Models;
using Microsoft.VisualBasic.ApplicationServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using System.Xml.Linq;
using WindowsFormsAppProject;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Housing_Project
{
    public partial class LoginRegister : Form
    {
        StatisticsManager statisticsManager;
        public LoginRegister()
        {
            statisticsManager = new StatisticsManager();
            InitializeComponent();
            tabControlLoginRegister.SelectTab("tabPageLogin");
            loginwrongcredentialslbl.Visible = false;
            registerlbl.Visible = false;
        }

        //Method to deserialise all managers with their specific content from the files

        //Method to reset the fields
        private void ClearFields()
        {
            //Login fields
            loginpasswordtxt.Clear();
            loginemailtxt.Clear();
            //Register fields
            fullnametxt.Clear();
            emailadresstxt.Clear();
            passwordtxt.Clear();
            phonenumbertxt.Clear();
        }

        //Method to open the specific form based on who is logging in
        private void ConnectUser(Manager manager)
        {
            this.Hide();
            connectedUser connectedUser = new connectedUser(manager);
            connectedUser.ShowDialog();
            this.Close();
        }

        private void registerbtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                string name = fullnametxt.Text;
                string email = emailadresstxt.Text;
                string phone = phonenumbertxt.Text;
                string password = passwordtxt.Text;
                bool exists = false;

                if (!String.IsNullOrEmpty(name) && !String.IsNullOrEmpty(email) && !String.IsNullOrEmpty(phone) && !String.IsNullOrEmpty(password))
                {
                    ////check if the person is a student
                    //if (email.Contains("student.com"))
                    //{
                    //    foreach (Tenant t in userManager.GetTenants())
                    //    {
                    //        if (t.Email == email)
                    //        {
                    //            exists = true;
                    //        }

                    //    }
                    //    if(exists == false)
                    //    {
                    //        Tenant tenant = new Tenant(name, phone, email, password);
                    //        userManager.AddTenantToList(tenant);
                    //        MessageBox.Show("Account created successfully!");
                    //        userManager.SaveRecruiter(userManager, "userData.txt");
                    //        ClearFields();
                    //    }
                    //    else
                    //    {
                    //        registerlbl.Visible = true;
                    //        ClearFields();
                    //    }
                    //}
                    ////check if the person is a supervisor
                    //else if (email.Contains("supervisor.com"))
                    //{
                    //    foreach (Supervisor s in userManager.GetSupervisors())
                    //    {
                    //        if (s.Email == email)
                    //        {
                    //            exists = true;
                    //        }
                    //    }
                    //    if(exists==false)
                    //    {
                    //        Supervisor supervisor = new Supervisor(name, phone, email, password);
                    //        userManager.AddSupervisorToList(supervisor);
                    //        MessageBox.Show("Account created successfully!");
                    //        userManager.SaveRecruiter(userManager, "userData.txt");
                    //        ClearFields();
                    //    }
                    //    else
                    //    {
                    //        registerlbl.Visible = true;
                    //        ClearFields();
                    //    }
                    //}
                    //else
                    //{
                    //    MessageBox.Show("Invalid email");
                    //}
                }
                else
                {
                    registerlbl.Visible = true;
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tabControlLoginRegister_Click(object sender, EventArgs e) //CreateAccountTAB
        {
            registerlbl.Visible = false;
            registerlbl.Visible = false;
            ClearFields();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            string email = loginemailtxt.Text;
            string password = loginpasswordtxt.Text;
            bool foundUser = false;


            if (email.Contains("@managers.garkov.com"))
            {
                foreach (Manager manager in statisticsManager.GetAllManagers())
                {
                    if (manager.Email == email && manager.Password == password)
                    {
                        foundUser = true;
                        Manager foundManager = manager;
                        ConnectUser(foundManager);
                    }
                }
                if (foundUser == false)
                {
                    loginwrongcredentialslbl.Visible = true;
                }

                   
            }
            else
            {
                loginwrongcredentialslbl.Visible = true;
            }
            //else if (email.Contains("supervisor.com"))
            //{
            //    foreach (Supervisor s in userManager.GetSupervisors())
            //    {
            //        if (s.Email == email && s.Password == password)
            //        {
            //            foundUser = true;
            //            supervisor = s;
            //        }
            //    }

            //    if (foundUser == true)
            //    {
            //        OpenUser(supervisor);
            //    }
            //    else
            //        loginwrongcredentialslbl.Visible = true;
            //}
        }
    }
}
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
    public partial class classView : Form
    {
        int idClass;
        ClassManager classManager;
        UserManager userManager;
        public classView(int idClass)
        {
            this.idClass = idClass;
            classManager = new ClassManager();
            userManager = new UserManager();
            InitializeComponent();
            DisplayData();
            GenerateDropdowns();
        }
        private void GenerateDropdowns()
        {
            foreach (Class currentClass in classManager.GetAllClasses())
            {
                changeClass_comboBox.Items.Add(currentClass.Name);
            }
        }
        private void DisplayError()
        {

        }
        private void DisplayData()
        {
            changeClass_btn.Visible = true;
            changeClass_comboBox.Visible = false;
            saveChanges_btn.Visible = false;
            
            listBoxStudentsClass.Items.Clear();
            foreach (Student student in classManager.GetClassStudentsById(idClass))
            {
                listBoxStudentsClass.Items.Add($"ID: {student.Userid} Name: {student.GetFullName()}");
            }
        }

        private void changeClass_btn_Click(object sender, EventArgs e)
        {
            changeClass_btn.Visible=false;
            changeClass_comboBox.Visible = true;
            saveChanges_btn.Visible = true;
        }

        private void saveChanges_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string inputString = listBoxStudentsClass.SelectedItem.ToString();
                string prefix = "ID: ";
                string suffix = " Name:";
                int startIndex = inputString.IndexOf(prefix) + prefix.Length;
                int endIndex = inputString.IndexOf(suffix, startIndex);
                int idUser = int.Parse(inputString.Substring(startIndex, endIndex - startIndex));

                User user = userManager.GetUserById(idUser);
                foreach (Class currentClass in classManager.GetAllClasses())
                {
                    if (currentClass.Name == int.Parse(changeClass_comboBox.Text))
                    {
                        user.Class = int.Parse(changeClass_comboBox.Text);
                    }
                }
                if (userManager.UpdateUser(user))
                {
                    DisplayData();
                }
                DisplayError();
                listBoxStudentsClass.SelectedIndex = -1;

            }
            catch (Exception) { }
        }
    }
}

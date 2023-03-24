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

        string currentStudentEdit;
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
            foreach (Teacher currentTeacher in userManager.GetAllTeachers())
            {
                changeTeacher_comboBox.Items.Add(currentTeacher.GetFullName());
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
            newClass_lbl.Visible = false;

            changeTeacher_comboBox.Enabled = false;

            listBoxStudentsClass.Enabled = true;
            listBoxStudentsClass.Items.Clear();
            foreach (Student student in classManager.GetClassStudentsById(idClass))
            {
                listBoxStudentsClass.Items.Add($"ID: {student.Userid} Name: {student.GetFullName()}");
            }

            changeTeacher_comboBox.Text = userManager.GetTeacherById(classManager.GetClassById(idClass).TeacherID).GetFullName();
        }

        private void changeClass_btn_Click(object sender, EventArgs e)
        {
            if (listBoxStudentsClass.SelectedIndex != -1)
            {
                changeClass_btn.Visible = false;
                changeClass_comboBox.Visible = true;
                saveChanges_btn.Visible = true;
                newClass_lbl.Visible = true;

                currentStudentEdit = listBoxStudentsClass.SelectedItem.ToString();
                listBoxStudentsClass.Enabled = false;
            }

        }

        private void saveChanges_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string prefix = "ID: ";
                string suffix = " Name:";
                int startIndex = currentStudentEdit.IndexOf(prefix) + prefix.Length;
                int endIndex = currentStudentEdit.IndexOf(suffix, startIndex);
                int idUser = int.Parse(currentStudentEdit.Substring(startIndex, endIndex - startIndex));

                User user = userManager.GetUserById(idUser);
                foreach (Class currentClass in classManager.GetAllClasses())
                {
                    if (currentClass.Name == int.Parse(changeClass_comboBox.Text))
                    {
                        user.Class = int.Parse(changeClass_comboBox.Text);
                    }
                }
                if (userManager.UpdateUser(user) == false)
                {
                    DisplayError();
                }
                DisplayData();
                listBoxStudentsClass.SelectedIndex = -1;

            }
            catch (Exception) { }
        }
    }
}

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
        public connectedUser()
		{

            InitializeComponent();
			DisplayData();
		}
		private void DisplayData()
		{
			//teachers
			listBoxTeachers.Items.Clear();
			foreach (Teacher teacher in administration.GetTeachersFromLocal())
			{
				listBoxTeachers.Items.Add($"UserID: {teacher.Userid} - {teacher.GetFullName()} - {teacher.Role} - Class: {teacher.Class}");
			}
			//students
			listBoxStudents.Items.Clear();
			foreach (Student student in administration.GetStudentsFromLocal())
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
			userView userView= new userView(userId, administration);
			userView.ShowDialog();
			this.Show();
		}
	}
}

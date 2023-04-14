using ClassLibrary.Controllers;
using ClassLibrary.Models;
using ClassLibrary.Mapper;
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
    public partial class addClass : Form
    {
        private StatisticsManager statisticsManager;
        private DataBaseClassLibrary.DatabaseHelpers.ClassDatabaseHelper classDatabaseHelper;
        private ClassMapper classMapper;
        public addClass()
        {
            statisticsManager = new StatisticsManager();
            classDatabaseHelper = new DataBaseClassLibrary.DatabaseHelpers.ClassDatabaseHelper();
            classMapper = new ClassMapper();
            InitializeComponent();
            GenerateDropdowns();
        }
        public void GenerateDropdowns()
        {
            className_txt.Text = string.Empty;
            classteacher_cb.SelectedIndex = -1;

            checkedListBoxStudents.Items.Clear();
            foreach (Student student in statisticsManager.GetAllStudents())
            {
                if (student.Class == 0)
                {
                    checkedListBoxStudents.Items.Add(student.GetFullName());
                }
            }
            if (checkedListBoxStudents.Items.Count == 0)
            {
                checkedListBoxStudents.Items.Add("No available students");
                checkedListBoxStudents.Enabled = false;
            }
            classteacher_cb.Items.Clear();
            foreach (Teacher teacher in statisticsManager.GetAllTeachers())
            {
                if (teacher.Class == 0)
                {
                    classteacher_cb.Items.Add($"{teacher.GetFullName()}");
                }
            }
            if (classteacher_cb.Items.Count == 0)
            {
                classteacher_cb.Items.Add("No available teachers");
                classteacher_cb.SelectedIndex = 0;
                classteacher_cb.Enabled = false;
            }
        }

        private void addClass_btn_Click(object sender, EventArgs e)
        {
            if (checkedListBoxStudents.CheckedItems.Count != 0 && classteacher_cb.SelectedIndex != -1 && className_txt.Text != string.Empty)
            {
                List<string> checkedStudents = new List<string>();
                for (int i = 0; i < checkedListBoxStudents.CheckedItems.Count; i++) // get student names
                {
                    checkedStudents.Add(checkedListBoxStudents.CheckedItems[i].ToString());
                }

                List<Student> students = new List<Student>();
                foreach (Student student in statisticsManager.GetAllStudents()) // determine students to add
                {
                    foreach (string checkedStudent in checkedStudents)
                    {
                        if (student.GetFullName() == checkedStudent)
                        {
                            Student student1 = student;
                            students.Add(student1);
                        }
                    }
                }
                int teacherId = 0;
                foreach (Teacher teacher in statisticsManager.GetAllTeachers()) // determine teacher
                {
                    if (teacher.GetFullName() == classteacher_cb.SelectedItem.ToString())
                    {
                        teacherId = teacher.Userid;
                    }
                }
                Class newClass = new Class(int.Parse(className_txt.Text), teacherId);
                try
                {
                    newClass.Create(); // add class to DB

                    foreach (Student student in students)//add class to students
                    {
                        try
                        {
                            student.AddToClass(newClass.Name);
                        }
                        catch (Exception)
                        {
                        }

                    }
                    if (teacherId != 0)
                    {
                        Teacher currentTeacher = statisticsManager.GetTeacherById(teacherId);
                        currentTeacher.ChangeClass(newClass.Name);
                    }
                    MessageBox.Show("Successfully added the students to the new class!");
                    GenerateDropdowns();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


            }
        }
    }
}

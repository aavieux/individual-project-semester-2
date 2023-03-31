
using ClassLibrary.Models;
using DataBaseClassLibrary.DatabaseHelpers;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Controllers
{
    public class ClassManager
    {
        //dependancy injection
        private ClassDatabaseHelper dbHelper;

        public ClassManager()
        {
            this.dbHelper = new ClassDatabaseHelper();
        }
        public List<Class> GetAllClasses()
        {
            return dbHelper.GetClassesFromDB();
        }
        public Class GetClassById(int ClassName)
        {

            foreach (Class _class in GetAllClasses())
            {
                if (_class.Name == ClassName)
                {
                    return _class;
                }
            }
            return null;
        }

        //Move to Class
        public List<Student> GetClassStudentsById(int classId) 
        { 
            return dbHelper.GetClassStudentsFromDB(classId);
        } 
        public void ChangeTeacher(Class currentClass,int newTeacherID)
        {
            UserManager userManager = new UserManager();
            
            foreach (Teacher teacher in userManager.GetAllTeachers())
            {
                if (teacher.Userid == newTeacherID && teacher.Class == null) // if the teacher exist and it has no class
                {
                    currentClass.TeacherID = teacher.Userid;
                    teacher.Class = currentClass.Name;
                    return;
                }
                else if (teacher.Userid == newTeacherID && teacher.Class != null)// if the teacher exist and it HAS ALREADY class
                {
                    if (teacher.Class != currentClass.Name)
                    {
                        currentClass.TeacherID = teacher.Userid;
                        GetClassById((int)teacher.Class).TeacherID = 0;
                        teacher.Class = currentClass.Name;
                        return;
                    }
                    else
                    {
                        Console.WriteLine("This teacher has already been assigned to this class!");
                    }
                }
            }
            Console.WriteLine("No such UserID was found!");
        }
    }
}

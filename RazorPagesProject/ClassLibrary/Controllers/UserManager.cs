using ClassLibrary.DatabaseHelpers;
using ClassLibrary.Models;
using ClassLibrary.Models.Enums;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Controllers
{

    public class UserManager
    {
        private UserDatabaseHelper dbHelper;
        public UserManager()
        {
            this.dbHelper = new UserDatabaseHelper();
        }

        public List<Teacher> GetAllTeachers()
        {
            List<Teacher> teachers = new List<Teacher>();
            foreach (User user in dbHelper.GetAllUsersFromDB())
            {
                if (user.GetType() == typeof(Teacher))
                {
                    teachers.Add((Teacher)user);
                }
            }
            return teachers;
        }
        public List<Student> GetAllStudents()
        {
            List<Student> students = new List<Student>();
            foreach (User user in dbHelper.GetAllUsersFromDB())
            {
                if (user.GetType() == typeof(Student))
                {
                    students.Add((Student)user);
                }
            }
            return students;
        } // because there are students amongst teachers in users

        public User GetUserById(int userId)
        {
            foreach (User user in dbHelper.GetAllUsersFromDB())
            {
                if (user.Userid == userId)
                {
                    return user;
                }
            }
            return null;
        }
        public Student GetStudentById(int Userid)
        {
            foreach (Student student in GetAllStudents())
            {
                if (student.Userid == Userid)
                {
                    return student;
                }
            }
            return null;
        }
        public Teacher GetTeacherById(int Userid)
        {
            if (Userid == null)
            {
                return null;
            }
            foreach (Teacher teacher in GetAllTeachers())
            {
                if (teacher.Userid == Userid)
                {
                    return teacher;
                }
            }
            return null;

        }

        public List<Teacher> GetTeachersByPartOfName(string partOfName)
        {
            List<Teacher> teachers = new List<Teacher>();
            foreach (Teacher teacher in GetAllTeachers())
            {
                if (teacher.GetFullName().ToLower().Contains(partOfName.ToLower()))
                {
                    teachers.Add(teacher);
                }
            }
            return teachers;
        }  
        public List<Student> GetStudentsByPartOfName(string partOfName)
        {
            List<Student> students = new List<Student>();
            foreach (Student student in GetAllStudents())
            {
                if (student.GetFullName().ToLower().Contains(partOfName.ToLower()))
                {
                    students.Add(student);
                }
            }
            return students;
        }

        public bool UpdateUser(User user)
        {
            if (dbHelper.UpdateUserToDB(user))
            {
                return true;
            }
            return false;
        }
        public bool DeleteUser(int userId) 
        {
            if (dbHelper.DeleteUserFromDB(userId))
            {
                return true;
            }
            return false;
        }

        public List<Manager> GetAllManagers()
        {
            return dbHelper.GetAllManagersFromDB();
        }
    }
}

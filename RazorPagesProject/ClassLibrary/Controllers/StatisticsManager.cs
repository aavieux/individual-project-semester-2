﻿using ClassLibrary.Mapper;
using ClassLibrary.Models;
using DataBaseClassLibrary.DatabaseHelpers;
using DataBaseClassLibrary.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Controllers
{
    public class StatisticsManager
    {
        private ClassDatabaseHelper classDbHelper;
        private ClassMapper classMapper;

        private UserDatabaseHelper userDbHelper;
        private UserMapper userMapper;

        private GradeDatabaseHelper gradeDbHelper;
        private GradeMapper gradeMapper;

        public StatisticsManager()
        {
            this.classDbHelper = new ClassDatabaseHelper();
            this.classMapper = new ClassMapper();

            this.userDbHelper = new UserDatabaseHelper();
            this.userMapper = new UserMapper();

            this.gradeDbHelper = new GradeDatabaseHelper();
            this.gradeMapper = new GradeMapper();
        }

        public List<Class> GetAllClasses()
        {
            List<Class> classes = new List<Class>();
            foreach (ClassDTO currentClass in classDbHelper.GetClassesFromDB())
            {
                classes.Add(classMapper.MapClassDTOtoClass(currentClass));
            }
            return classes;
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

        public List<Grade> GetAllGrades()
        {
            List<Grade> grades = new List<Grade>();
            foreach (GradeDTO grade in gradeDbHelper.GetGradesFromDB())
            {
                grades.Add(gradeMapper.MapGradeDTOtoGrade(grade));
            }
            return grades;
        }

        public List<User> GetAllUsers()
        {
            List<User> users = new List<User>();
            foreach (UserDTO user in userDbHelper.GetAllUsersFromDB())
            {
                users.Add(userMapper.MapUserDTOtoUser(user));
            }
            return users;
        }
        public List<Teacher> GetAllTeachers()
        {
            List<Teacher> teachers = new List<Teacher>();
            foreach (UserDTO userDTO in userDbHelper.GetAllUsersFromDB())
            {
                if (userDTO.GetType() == typeof(TeacherDTO))
                {
                    teachers.Add((Teacher)userMapper.MapTeacherDTOtoTeacher(userDTO));
                }
            }
            return teachers;
        }
        public List<Student> GetAllStudents()
        {
            List<Student> students = new List<Student>();
            foreach (UserDTO userDTO in userDbHelper.GetAllUsersFromDB())
            {
                if (userDTO.GetType() == typeof(StudentDTO))
                {
                    students.Add((Student)userMapper.MapStudentDTOtoStudent(userDTO));
                }
            }
            return students;
        } // because there are students amongst teachers in users
        public List<Manager> GetAllManagers()
        {
            List<Manager> managers = new List<Manager>();
            foreach (ManagerDTO managerDTO in userDbHelper.GetAllManagersFromDB())
            {
                managers.Add((Manager)userMapper.MapUserDTOtoUser(managerDTO));
            }
            return managers;
        } // to do mapping

        public User GetUserById(int userId)
        {
            foreach (UserDTO userDTO in userDbHelper.GetAllUsersFromDB())
            {
                if (userDTO.Userid == userId)
                {
                    return userMapper.MapUserDTOtoUser(userDTO);
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
    }
}
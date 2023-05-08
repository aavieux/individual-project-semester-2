using ClassLibrary.Models;
using ClassLibrary.Models.Enums;
using DataBaseClassLibrary.DatabaseHelpers;
using DataBaseClassLibrary.DTOs;
using DataBaseClassLibrary.DTOs.DTOEnums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Mapper
{
    public class UserMapper
    {
        private UserDatabaseHelper userDatabaseHelper;
        private GradeDatabaseHelper gradeDatabaseHelper;
        public UserMapper(UserDatabaseHelper userDatabaseHelper, GradeDatabaseHelper gradeDatabaseHelper) 
        {
            this.userDatabaseHelper = userDatabaseHelper;
            this.gradeDatabaseHelper = gradeDatabaseHelper;
        }
        public User MapUserDTOtoUser(UserDTO userDTO)
        {
            User user = new User(userDatabaseHelper, gradeDatabaseHelper, userDTO.Firstname, userDTO.Lastname, Enum.Parse<ClassLibrary.Models.Enums.Role>(userDTO.Role.ToString()), userDTO.Class, userDTO.Email, userDTO.PhoneNumber,userDTO.Userid);
            return user;
        }
        public UserDTO MapUserToUserDTO(User user)
        {
            UserDTO userDTO = new UserDTO(user.Firstname,user.Lastname, Enum.Parse<DataBaseClassLibrary.DTOs.DTOEnums.Role>(user.Role.ToString()), user.Class, user.Email, user.PhoneNumber, user.Userid);
            return userDTO;
        }

        public Student MapStudentDTOtoStudent(UserDTO userDTO)
        {
            Student student = new Student(userDatabaseHelper,gradeDatabaseHelper, userDTO.Firstname, userDTO.Lastname, Enum.Parse<ClassLibrary.Models.Enums.Role>(userDTO.Role.ToString()), userDTO.Class, userDTO.Email, userDTO.PhoneNumber, userDTO.Userid);
            return student;
        }
        //
        public Teacher MapTeacherDTOtoTeacher(UserDTO userDTO)
        {
            Teacher teacher = new Teacher(userDatabaseHelper,gradeDatabaseHelper,userDTO.Firstname, userDTO.Lastname, Enum.Parse<ClassLibrary.Models.Enums.Role>(userDTO.Role.ToString()), userDTO.Class, userDTO.Email, userDTO.PhoneNumber, userDTO.Userid);
            return teacher;
        }
        //
        public Manager MapManagerDTOtoManager(ManagerDTO managerDTO)
        {
            Manager manager = new Manager(managerDTO.Userid,managerDTO.Firstname, managerDTO.Lastname, managerDTO.Email, managerDTO.Password);
            return manager;
        }



    }
}

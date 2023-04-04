using ClassLibrary.Models;
using ClassLibrary.Models.Enums;
using DataBaseClassLibrary.DTOs;
using DataBaseClassLibrary.DTOs.DTOEnums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Mapper
{
    internal class UserMapper
    {
        internal User MapUserDTOtoUser(UserDTO userDTO)
        {
            User user = new User(userDTO.Firstname, userDTO.Lastname, Enum.Parse<ClassLibrary.Models.Enums.Role>(userDTO.Role.ToString()), userDTO.Class, userDTO.Email, userDTO.PhoneNumber,userDTO.Userid);
            return user;
        }
        internal UserDTO MapUserToUserDTO(User user)
        {
            UserDTO userDTO = new UserDTO(user.Firstname,user.Lastname, Enum.Parse<DataBaseClassLibrary.DTOs.DTOEnums.Role>(user.Role.ToString()), user.Class, user.Email, user.PhoneNumber, user.Userid);
            return userDTO;
        }

        internal Student MapStudentDTOtoStudent(UserDTO userDTO)
        {
            Student student = new Student(userDTO.Firstname, userDTO.Lastname, Enum.Parse<ClassLibrary.Models.Enums.Role>(userDTO.Role.ToString()), userDTO.Class, userDTO.Email, userDTO.PhoneNumber, userDTO.Userid);
            return student;
        }
        //
        internal Teacher MapTeacherDTOtoTeacher(UserDTO userDTO)
        {
            Teacher teacher = new Teacher(userDTO.Firstname, userDTO.Lastname, Enum.Parse<ClassLibrary.Models.Enums.Role>(userDTO.Role.ToString()), userDTO.Class, userDTO.Email, userDTO.PhoneNumber, userDTO.Userid);
            return teacher;
        }
        //
        internal Manager MapManagerDTOtoManager(ManagerDTO managerDTO)
        {
            Manager manager = new Manager(managerDTO.Userid,managerDTO.Firstname, managerDTO.Lastname, managerDTO.Email, managerDTO.Password);
            return manager;
        }



    }
}

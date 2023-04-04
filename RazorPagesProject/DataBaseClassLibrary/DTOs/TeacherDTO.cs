using DataBaseClassLibrary.DTOs.DTOEnums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseClassLibrary.DTOs
{
    public class TeacherDTO : UserDTO
    {
        public TeacherDTO(string FirstName, string LastName, Role Role, int? Class, string Email, string PhoneNumber, int UserID) : base(FirstName, LastName, Role, Class, Email, PhoneNumber, UserID)
        {
            Role = Role.TEACHER1;
        }
    }
}

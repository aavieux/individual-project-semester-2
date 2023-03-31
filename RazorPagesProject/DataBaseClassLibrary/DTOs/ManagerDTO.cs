using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseClassLibrary.DTOs
{
    public class ManagerDTO : UserDTO
    {
        private readonly string password;
        public string Password { get { return this.password; } }
        public ManagerDTO(int UserID, string FirstName, string LastName, string Email, string Password) : base(UserID, FirstName, LastName, Email)
        {
            this.password = Password;
        }
        public ManagerDTO() { }
    }
}

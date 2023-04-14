using ClassLibrary.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Models
{
    public class Manager : User
    {
        private string password;
        public string Password { get { return this.password; } }
        public Manager(int UserID,string FirstName ,string LastName, string Email, string Password) : base(UserID, FirstName, LastName, Email) 
        { 
            //to load
            this.password = Password;
        } 
    }
}

using DataBaseClassLibrary.DTOs.DTOEnums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseClassLibrary.DTOs
{
    public class UserDTO
    {
        private readonly string _firstname;
        private readonly string _lastname;
        private readonly Role _role;
        private readonly int? _class;
        private readonly string? _email;
        private readonly string? _phonenumber;
        private readonly int _idUser;

        public string Firstname { get { return _firstname; } }
        public string Lastname { get { return _lastname; } }
        public Role Role { get { return _role; } }
        public int? Class { get { return _class; } }
        public string Email { get { return _email; } }
        public string PhoneNumber { get { return _phonenumber; } }
        public int Userid { get { return _idUser; } }

        public UserDTO(string FirstName, string LastName, Role Role, int? Class, string Email, string PhoneNumber, int UserID)
        {
            // for everyone else load
            this._firstname = FirstName;
            this._lastname = LastName;
            this._role = Role;
            this._class = Class;
            this._email = Email;
            this._phonenumber = PhoneNumber;
            this._idUser = UserID;
        }
        public UserDTO(string FirstName, string LastName, Role Role, int? Class, string Email, string PhoneNumber)
        {
            // for everyone else write
            this._firstname = FirstName;
            this._lastname = LastName;
            this._role = Role;
            this._class = Class;
            this._email = Email;
            this._phonenumber = PhoneNumber;
        }

        public UserDTO(int userID, string firstName, string lastName, string email) 
        {
            // for manager
            this._firstname = firstName;
            this._lastname = lastName;
            this._email = email;
            this._idUser = userID;
        }
    }
}


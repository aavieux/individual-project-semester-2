using ClassLibrary.Controllers;
using ClassLibrary.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Models
{
	public class User
	{
		private string _firstname;
		private string _lastname;
		private Role _role;
		private int? _class;
		private string? _email;
		private string? _phonenumber;
		private int _idUser;

		public string Firstname { get { return _firstname; } set { this._firstname = value; } }
		public string Lastname { get { return _lastname; } set { this._lastname = value; } }
		public Role Role { get { return _role; } set { this._role = value; } }
		public int? Class { get { return _class; } set { this._class = value; } }
		public string Email { get { return _email; } set { this._email = value; } }
		public string PhoneNumber { get { return _phonenumber; } set { _phonenumber = value; } }
		public int Userid { get { return _idUser; } set { this._idUser = value; } }

		//UserManager userManager;

        public User() 
		{
			 //userManager = new UserManager();
		}
		public User(string FirstName, string LastName, Role Role, int? Class, string Email, string PhoneNumber, int UserID)
		{
			this._firstname = FirstName;
			this._lastname = LastName;
			this._role = Role;
			this._class = Class;
			this._email = Email;
			this._phonenumber = PhoneNumber;
			this._idUser = UserID;
        }

        public User(int userID, string firstName, string lastName, string email)
        {
            this._firstname = firstName;
            this._lastname = lastName;
            this._email = email;
            this.Userid = userID;
        }

        public string GetFullName()
		{
			return $"{_firstname} {_lastname}";
		}
	}
}


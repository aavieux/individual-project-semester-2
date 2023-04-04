using ClassLibrary.Controllers;
using ClassLibrary.Mapper;
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
		private DataBaseClassLibrary.DatabaseHelpers.UserDatabaseHelper dbHelper;
		private UserMapper mapper;

		private string _firstname;
		private string _lastname;
		private Role _role;
		private int? _class;
		private string? _email;
		private string? _phonenumber;
		private int _idUser;

		public string Firstname { get { return _firstname; } }
		public string Lastname { get { return _lastname; } }
		public Role Role { get { return _role; } }
		public int? Class { get { return _class; } }
		public string Email { get { return _email; } }
		public string PhoneNumber { get { return _phonenumber; } }
		public int Userid { get { return _idUser; } }

		//UserManager userManager;

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
            this._idUser = userID;
        }
		
		protected void UpdateRole(Role role) 
		{ 
			this._role = role; 

		}
        public void PromoteRole()
        {
            if (this.Role != Role.DIRECTOR)
            {
                Role newRole = Role;
                newRole++;
                UpdateRole(newRole);
            }
            else
            {
                Console.WriteLine($"Error Promoting User! The current role now is: {Role}");
            }
        }
        public bool Update()
        {

            if (dbHelper.UpdateUserToDB(mapper.MapUserToUserDTO(this)))
            {
                return true;
            }
            return false;
        }
        public bool Delete()
        {
            if (dbHelper.DeleteUserFromDB(this._idUser))
            {
                return true;
            }
            return false;
        }
        public void ChangeClass(int newClassId)
        {
            this._class = newClassId;
			//add logic
        }
        public string GetFullName()
		{
			return $"{_firstname} {_lastname}";
		}
	}
}
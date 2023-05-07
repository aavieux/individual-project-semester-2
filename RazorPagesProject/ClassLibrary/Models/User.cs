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
		private DataBaseClassLibrary.DatabaseHelpers.UserDatabaseHelper dbHelper = new DataBaseClassLibrary.DatabaseHelpers.UserDatabaseHelper();
		private UserMapper mapper = new UserMapper();

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

		public User(string FirstName, string LastName, Role Role, int? Class, string Email, string PhoneNumber, int UserID) 
		{
            // all others load
            this._firstname = FirstName;
			this._lastname = LastName;
			this._role = Role;
			this._class = Class;
			this._email = Email;
			this._phonenumber = PhoneNumber;
			this._idUser = UserID;
        }
        public User(string FirstName, string LastName, Role Role, int? Class, string Email, string PhoneNumber)
        {
            // all others write
            this._firstname = FirstName;
            this._lastname = LastName;
            this._role = Role;
            this._class = Class;
            this._email = Email;
            this._phonenumber = PhoneNumber;
        }

        public User(int userID, string firstName, string lastName, string email) 
        {
            // manager
            this._firstname = firstName;
            this._lastname = lastName;
            this._email = email;
            this._idUser = userID;
        }
        //private void SetId(int newId)
        //{
        //    this._idUser = newId;
        //}
        public void PromoteRole()
        {
            if (this.Role != Role.DIRECTOR)
            {
                Role newRole = Role;
                newRole++;
                this._role = newRole;
                Update();
            }
            else
            {
                Console.WriteLine($"Error Promoting User! The current role now is: {Role}");
            }
        }
        public bool AddToClass(int classId)
        {
            if (this._class == 0)
            {
                this._class = classId;
                Update();
                return true;
            }
            return false;

        }
        //public bool Create()
        //{
        //    if (this._idUser == 0) // check if the user is loaded or now being created(when the id is 0 means that the user exist only in the business logic)
        //    {
        //        User user = new User(this._firstname, this._lastname, this._role, this._class, this._email, this._phonenumber, this._idUser);
        //        this._idUser = dbHelper.AddUserToDB(mapper.MapUserToUserDTO(user));
        //        if (this._idUser != 0)
        //        {
        //            return true;
        //        }
        //        return false;
        //    }
        //    else
        //    {
        //        return false;
        //    }
            
            
        //}
        public bool Update()
        {
            User user = new User(this._firstname, this._lastname, this._role, this._class, this._email, this._phonenumber, this._idUser);
            if (dbHelper.UpdateUserToDB(mapper.MapUserToUserDTO(user)))
            {
                return true;
            }
            return false;
        }
        //public bool Delete()
        //{
        //    if (dbHelper.DeleteUserFromDB(this._idUser))
        //    {
        //        return true;
        //    }
        //    return false;
        //}
        public void ChangeClass(int newClassId)
        {
            this._class = newClassId;
            Update();
			//add logic
        }
        public string GetFullName()
		{
			return $"{_firstname} {_lastname}";
		}
        public void SetId(int id)
        {
            this._idUser = id;
        }
	}
}
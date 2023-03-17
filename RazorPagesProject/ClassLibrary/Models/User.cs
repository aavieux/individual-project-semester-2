using RazorPagesProject.Models.Enums;

namespace RazorPagesProject.Models
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

        public User() { }
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
        public string GetFullName()
        {
            return $"{_firstname} {_lastname}";
        }

    }
}

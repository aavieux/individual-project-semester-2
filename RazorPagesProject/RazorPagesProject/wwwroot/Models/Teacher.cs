namespace RazorPagesProject.wwwroot.Models
{
    public class Teacher
    {
        private string _firstname;
        private string _lastname;
        private string _role;
        private string _class;
        private string ?_email;
        private string ?_phonenumber;
        private string _userid;

        public string Firstname { get { return _firstname;} set { this._firstname = value; } }
        public string Lastname { get { return _lastname; }set { this._lastname = value;} }
        public string Role { get { return _role; } set { this._role = value;} }
        public string Class { get { return _class; } set { this._class = value;} }
        public string Email { get { return _email; } set { this._email = value; } }
        public string PhoneNumber { get { return _phonenumber; } set { _phonenumber= value; } }
        public string Userid { get { return _userid; }set { this._userid = value;} }

        public Teacher() { }
        public Teacher(string FirstName, string LastName, string Role, string Class,string Email, string PhoneNumber, string UserID)
        {
            this._firstname = FirstName;
            this._lastname = LastName;
            this._role = Role;
            this._class = Class;
            this._email = Email;
            this._phonenumber = PhoneNumber;
            this._userid = UserID;
        }
    }
}

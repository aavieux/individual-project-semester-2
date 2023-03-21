using ClassLibrary.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Models
{
	public class Teacher : User
	{
		public Teacher() { }
		public Teacher(string FirstName, string LastName, Role Role, int? Class, string Email, string PhoneNumber, int UserID) : base(FirstName, LastName, Role, Class, Email, PhoneNumber, UserID)
		{
			Role = Role.TEACHER1;
		}
		public void Promote()
		{
			if (Role != Role.DIRECTOR)
			{
				Role++;
			}
			else
			{
				Console.WriteLine($"Error Promoting Teacher! The current role now is: {Role}");
			}
		}
	}
}


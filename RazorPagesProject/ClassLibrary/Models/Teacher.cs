﻿using ClassLibrary.Models.Enums;
using DataBaseClassLibrary.DatabaseHelpers;
using DataBaseClassLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Models
{
	public class Teacher : User
	{
		public Teacher(IUserDbHelper userDbHelper, IGradeDbHelper gradeDbHelper, string FirstName, string LastName, Role Role, int? Class, string Email, string PhoneNumber, int UserID) 
			: base(userDbHelper, gradeDbHelper, FirstName, LastName, Role, Class, Email, PhoneNumber, UserID)
		{
			//to load
			Role = Role.TEACHER1;
		}
        public Teacher(IUserDbHelper dbHelper, IGradeDbHelper gradeDbHelper,string FirstName, string LastName, Role Role, int? Class, string Email, string PhoneNumber) : base(dbHelper, gradeDbHelper,FirstName, LastName, Role, Class, Email, PhoneNumber)
        {
            //to write
        }
        ////Mock
        //public Teacher(string FirstName, string LastName, Role Role, int? Class, string Email, string PhoneNumber, int UserID) : base(FirstName, LastName, Role, Class, Email, PhoneNumber, UserID)
        //{

        //}
    }
}


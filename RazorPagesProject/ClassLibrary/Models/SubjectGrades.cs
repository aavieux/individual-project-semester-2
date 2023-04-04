﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.Controllers;
using ClassLibrary.Models.Enums;
using DataBaseClassLibrary.DTOs;

namespace ClassLibrary.Models
{
	public class SubjectGrades

	{
		private int _idSubjectGrades;
		private Subject _subject;
		private int _idUser;

		private List<Grade> grades;
		//private GradeManager gradeManager;

		public int Id { get { return _idSubjectGrades; } }
		public Subject Subject { get { return _subject; } }
		public int IdUser { get { return _idUser; }}

        public SubjectGrades(int id, Subject subject, int idUser)
        {
            //gradeManager = new GradeManager();
            this._idSubjectGrades = id;
            this._subject = subject;
            this._idUser = idUser;
        }
        public SubjectGrades(int id, Subject subject, int idUser, List<Grade> Grades)
        {
            //gradeManager = new GradeManager();
            this._idSubjectGrades = id;
            this._subject = subject;
            this._idUser = idUser;
            this.grades = Grades;
        }
        public void AddGrade(Grade grade)
        {
            grades.Add(grade);
        }
        public List<Grade> GetGrades() { return grades; }

    }
}

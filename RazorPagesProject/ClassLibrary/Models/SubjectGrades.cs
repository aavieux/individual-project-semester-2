﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.Controllers;
using ClassLibrary.Mapper;
using ClassLibrary.Models.Enums;
using DataBaseClassLibrary.DatabaseHelpers;
using DataBaseClassLibrary.DTOs;
using DataBaseClassLibrary.Interfaces;

namespace ClassLibrary.Models
{
	public class SubjectGrades
	{
        private IGradeDbHelper gradeDbHelper;
        private GradeMapper gradeMapper;

		private int _idSubjectGrades;
		private Subject _subject;
		private int _idUser;

		private List<Grade> grades = new List<Grade>();
		//private GradeManager gradeManager;

		public int Id { get { return _idSubjectGrades; } }
		public Subject Subject { get { return _subject; } }
		public int IdUser { get { return _idUser; }}

        public SubjectGrades(IGradeDbHelper gradeDbHelper, int id, Subject subject, int idUser)
        {
            //to load  // to fix
            //gradeManager = new GradeManager();
            this.gradeMapper = new GradeMapper(gradeDbHelper);
            this._idSubjectGrades = id;
            this._subject = subject;
            this._idUser = idUser;

            this.gradeDbHelper = gradeDbHelper;
        }
        public SubjectGrades(IGradeDbHelper gradeDbHelper, Subject subject, int idUser)
        {
            //to  write // to fix
            //gradeManager = new GradeManager();
            this.gradeMapper = new GradeMapper(gradeDbHelper);
            this._subject = subject;
            this._idUser = idUser;

            this.gradeDbHelper = gradeDbHelper;          
        }

        //public SubjectGrades(int id, Subject subject, int idUser, List<Grade> Grades)
        //{
        //    //gradeManager = new GradeManager();
        //    this._idSubjectGrades = id;
        //    this._subject = subject;
        //    this._idUser = idUser;
        //    this.grades = Grades;
        //}
        public void AddGrade(Grade grade) // for display only
        {
            grades.Add(grade);
        }
        public List<Grade> GetGrades() 
        {
            this.grades = new List<Grade>();
            foreach (GradeDTO gradeDTO in gradeDbHelper.GetGradesFromDB())
            {
                if (this.Id == gradeDTO.IdSubjectGrades)
                {
                    AddGrade(gradeMapper.MapGradeDTOtoGrade(gradeDTO));
                }
            }
            return grades; 
        }

    }
}

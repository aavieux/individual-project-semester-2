﻿using ClassLibrary.Models.Enums;
using ClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.DatabaseHelpers;
using System.Diagnostics;

namespace ClassLibrary.Controllers
{
    public class GradeManager
    {
        private GradeDatabaseHelper dbHelper;
        public GradeManager() 
        {
            this.dbHelper = new GradeDatabaseHelper();
        }

        public List<Grade> GetAllGrades()
        {
            return dbHelper.GetGradesFromDB();
        }
        public List<SubjectGrades> GetGradeBookByUserId(int userId)
        {
            List<SubjectGrades> gradebook = new List<SubjectGrades>();
            foreach (SubjectGrades subjectGrades in dbHelper.GetGradeBooksFromDB())
            {
                if (subjectGrades.IdUser == userId)
                {
                    gradebook.Add(subjectGrades);
                }
            }
            return gradebook;
        }
        public List<Grade> GetGradesBySubjectGrades(SubjectGrades subjectGrades)
        {
            return dbHelper.GetGradesBySubjectGradesFromDB(subjectGrades.Id);
        }
        public void AddGradeToSubjectGrades(int idSubjectGrades, Grade grade)
        {
            dbHelper.AddGradeToDB(idSubjectGrades,grade);
            Console.WriteLine("Records Inserted Locally Successfully");
        }
        public void DeleteGradeFromSubjectGrades(int idSubjectGrades, int gradeId)
        {
            dbHelper.DeleteGradeByIdFromDB(gradeId);
            Console.WriteLine("Records Inserted Locally Successfully");
        }

        public void AddSubjectGrades(SubjectGrades subjectGrades)
        {
            dbHelper.AddSubjectGradesToDB(subjectGrades);
        }

        //public void PutGradesInGradeBooksAndThenInStudents()
        //{
        //    foreach (Grade grade in grades)
        //    {
        //        if (GetSubjectGradesById(grade.IdSubjectGrades) != null)
        //        {
        //            GetSubjectGradesById(grade.IdSubjectGrades).AddGradeToGrades(grade);
        //        }
        //    }
        //    foreach (SubjectGrades subjectGrades in subjectGrades)
        //    {
        //        if (GetStudentFromLocal(subjectGrades.IdUser) != null)
        //        {
        //            GetStudentFromLocal(subjectGrades.IdUser).AddSubjectGradesToGradeBook(subjectGrades);
        //        }
        //    }
        //}
        //public SubjectGrades GetSubjectGradesById(int subjectGradesId)
        //{
        //    foreach (SubjectGrades subjectGrades in dbHelper.GetGradeBooksFromDB())
        //    {
        //        if (subjectGrades.Id == subjectGradesId)
        //        {
        //            return subjectGrades;
        //        }
        //    }
        //    return null;
        //}
        //access
    }
}
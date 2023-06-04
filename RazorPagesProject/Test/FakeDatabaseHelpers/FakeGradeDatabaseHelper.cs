using DataBaseClassLibrary.DTOs;
using DataBaseClassLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.FakeDatabaseHelpers
{
    public class FakeGradeDatabaseHelper : IGradeDbHelper
    {
        public List<SubjectGradesDTO> GetGradeBooksFromDB()
        {
            List<SubjectGradesDTO> subjectGradesDTOs = new List<SubjectGradesDTO>();
            return subjectGradesDTOs;
        }
        public List<GradeDTO> GetGradesFromDB()
        {
            List<GradeDTO> grades = new List<GradeDTO>();
            return grades;
        }
        public List<SubjectGradesDTO> GetSubjectGradesFromDB()
        {
            List<SubjectGradesDTO> subjectGradesDTOs = new List<SubjectGradesDTO>();
            return subjectGradesDTOs;
        }
        
        public void AddSubjectGradesToDB(SubjectGradesDTO subjectGrades)
        {
            
        }
        public void AddGradeToDB(int idSubjectGrades, GradeDTO grade)
        {
            
        }

        public bool DeleteSubjectGradesFromDB(SubjectGradesDTO subjectGradesDTO)
        {
            return true;
        }
        public void DeleteGradeByIdFromDB(int GradeId)
        {
            
        }
    }
}

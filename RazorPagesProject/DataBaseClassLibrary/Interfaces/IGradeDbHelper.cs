using DataBaseClassLibrary.DTOs;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseClassLibrary.Interfaces
{
    public interface IGradeDbHelper
    {
        public List<SubjectGradesDTO> GetGradeBooksFromDB();

        public List<GradeDTO> GetGradesFromDB();

        public List<SubjectGradesDTO> GetSubjectGradesFromDB();

        public void AddSubjectGradesToDB(SubjectGradesDTO subjectGrades);

        public void AddGradeToDB(int idSubjectGrades, GradeDTO grade);

        public bool DeleteSubjectGradesFromDB(SubjectGradesDTO subjectGradesDTO);

        public void DeleteGradeByIdFromDB(int GradeId);
    }
}

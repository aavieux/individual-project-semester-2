using DataBaseClassLibrary.DTOs.DTOEnums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseClassLibrary.DTOs
{
    public class SubjectGradesDTO
    {
        private int _idSubjectGrades;
        private Subject _subject;
        private int _idUser;

        private List<GradeDTO> grades;
        //private GradeManager gradeManager;

        public int Id { get { return _idSubjectGrades; } }
        public Subject Subject { get { return _subject; } }
        public int IdUser { get { return _idUser; } }

        public List<GradeDTO> Grades { get { return grades; } set { grades = value; } }
        public SubjectGradesDTO(int id, Subject subject, int idUser)
        {
            //gradeManager = new GradeManager();
            this._idSubjectGrades = id;
            this._subject = subject;
            this._idUser = idUser;
        }
    }
}

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
        private readonly int _idSubjectGrades;
        private readonly Subject _subject;
        private readonly int _idUser;

        //private readonly List<GradeDTO> grades;
        //private GradeManager gradeManager;

        //public int Id { get { return _idSubjectGrades; } }
        //public Subject Subject { get { return _subject; } }
        //public int IdUser { get { return _idUser; } }
        public int Id { get { return _idSubjectGrades; } }
        public Subject Subject { get { return _subject; } }
        public int IdUser { get { return _idUser; } }
        //public List<GradeDTO> Grades { get { return grades; } }
        public SubjectGradesDTO(int id, Subject subject, int idUser)
        {
            //gradeManager = new GradeManager();
            this._idSubjectGrades = id;
            this._subject = subject;
            this._idUser = idUser;
        }
        //public SubjectGradesDTO(int id, Subject subject, int idUser, List<GradeDTO> Grades)
        //{
        //    //gradeManager = new GradeManager();
        //    this._idSubjectGrades = id;
        //    this._subject = subject;
        //    this._idUser = idUser;
        //    this.grades = Grades;
        //}
    }
}

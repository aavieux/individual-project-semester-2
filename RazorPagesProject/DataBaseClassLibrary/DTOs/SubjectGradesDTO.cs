using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseClassLibrary.DTOs
{
    internal class SubjectGradesDTO
    {
        private readonly int _idSubjectGrades;
        private readonly Subject _subject;
        private readonly int _idUser;

        private List<Grade> grades;
        //private GradeManager gradeManager;

        public int Id { get { return _idSubjectGrades; } }
        public Subject Subject { get { return _subject; } }
        public int IdUser { get { return _idUser; } }

        public List<Grade> Grades { get { return grades; } set { grades = value; } }
        public SubjectGradesDTO()
        {
            //gradeManager = new GradeManager();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseClassLibrary.DTOs
{
    internal class GradeDTO
    {
        private readonly int? _idGrade;
        private readonly int? _idSubjectGrades;
        private readonly GradeEnum _grade;

        public int? IdGrade { get { return _idGrade; } set { _idGrade = value; } }
        public int? IdSubjectGrades { get { return _idSubjectGrades; } set { _idSubjectGrades = value; } }
        public GradeEnum GradeEnum { get { return _grade; } set { _grade = value; } }

        public GradeDTO() { }
        public GradeDTO(int idSubjectGrades, GradeEnum grade)
        {
            this._idSubjectGrades = idSubjectGrades;
            this._grade = grade;
        }
        public GradeDTO(GradeEnum grade)
        {
            this._grade = grade;
        }
    }
}

using DataBaseClassLibrary.DTOs.DTOEnums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseClassLibrary.DTOs
{
    public class GradeDTO
    {
        private readonly int _idGrade;
        private readonly int _idSubjectGrades;
        private readonly GradeEnum _grade;

        public int IdGrade { get { return this._idGrade; } }
        public int IdSubjectGrades { get { return this._idSubjectGrades; } }
        public GradeEnum GradeEnum { get { return _grade; } }

        public GradeDTO(int idGrade,int idSubjectGrades, GradeEnum grade)
        {
            //to load
            this._idGrade = idGrade;
            this._idSubjectGrades = idSubjectGrades;
            this._grade = grade;
        }
        public GradeDTO(int idSubjectGrades, GradeEnum grade)
        {
            //to write
            this._idSubjectGrades = idSubjectGrades;
            this._grade = grade;
        }
    }
}

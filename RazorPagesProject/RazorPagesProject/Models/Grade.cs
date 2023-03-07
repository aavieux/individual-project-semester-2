using RazorPagesProject.Models.Enums;

namespace RazorPagesProject.Models
{
    public class Grade
    {
        private int _idGrade;
        private int _idSubjectGrades;
        private GradeEnum _grade;

        public int IdGrade { get { return _idGrade; } set { _idGrade = value; } }
        public int IdSubjectGrades { get { return _idSubjectGrades; } set { _idSubjectGrades = value;} }
        public GradeEnum GradeEnum { get { return _grade; }set { _grade = value; } }
    }
}

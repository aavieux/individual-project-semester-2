using RazorPagesProject.Models.Enums;

namespace RazorPagesProject.Models
{
    public class SubjectGrades

    {
        private int _idSubjectGrades;
        private Subject _subject;
        private int _idUser;

        private List<Grade> grades = new List<Grade>();

        public int Id { get { return _idSubjectGrades; } set { _idSubjectGrades = value; } }
        public Subject Subject { get { return _subject; } set { _subject = value; } }
        public int IdUser { get { return _idUser; } set { _idUser = value;} }

        public List<Grade> Grades { get { return grades; } set { grades = value; } }

        public void AddGradeToGrades(Grade grade)
        {
            grades.Add(grade);
        }
    }
}
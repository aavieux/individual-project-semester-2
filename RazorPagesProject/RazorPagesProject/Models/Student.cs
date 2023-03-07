using RazorPagesProject.Models.Enums;

namespace RazorPagesProject.Models
{
    public class Student : User
    {
        private List<SubjectGrades> _gradebook = new List<SubjectGrades>();
        public List<SubjectGrades> GradeBook { get { return _gradebook; }set { this._gradebook = value; } }
        public Student() { }
        public Student(string FirstName, string LastName, Role Role, int Class, string Email, string PhoneNumber, int UserID) : base(FirstName, LastName, Role, Class, Email, PhoneNumber, UserID)
        {
            Role = Role.STUDENT;
        }
        //public List<SubjectGrades> GetGradeBook()
        //{
        //    return _gradebook;
        //}
        public List<Grade> GetGradesBySubject(Subject subject)
        {
            foreach (SubjectGrades subjectGrades in _gradebook)
            {
                if (subjectGrades.Subject == subject)
                {
                    return subjectGrades.Grades;
                }
            }
            return null;
            
        }
    }
}

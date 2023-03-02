using RazorPagesProject.Models.Enums;

namespace RazorPagesProject.Models
{
    public class Student : User
    {
        private Dictionary<Subject, List<Grade>> grades;
        public Student() { }
        public Student(string FirstName, string LastName, Role Role, int Class, string Email, string PhoneNumber, int UserID) : base(FirstName, LastName, Role, Class, Email, PhoneNumber, UserID)
        {
            Role = Role.STUDENT;
        }
        public Dictionary<Subject, List<Grade>> GetGradeList()
        {
            return grades;
        }
        public List<Grade> GetGradesBySubject(Subject subject)
        {
            if (grades.ContainsKey(subject))
            {
                List<Grade> subjectGrades = grades[subject];
                return subjectGrades;
            }
            return null;
        }
    }
}

using ClassLibrary.Controllers;
using ClassLibrary.Models.Enums;

namespace ClassLibrary.Models
{
    public class Student : User
    {
        private List<SubjectGrades> _gradebook = new List<SubjectGrades>();
        public List<SubjectGrades> GradeBook { get { return _gradebook; }set { this._gradebook = value; } }
        //UserManager userManager;
        //GradeManager gradeManager;
        public Student() 
        {
            //userManager = new UserManager();
            //gradeManager = new GradeManager();
        }
        public Student(string FirstName, string LastName, Role Role, int Class, string Email, string PhoneNumber, int UserID) : base(FirstName, LastName, Role, Class, Email, PhoneNumber, UserID){}
		//public List<SubjectGrades> GetGradeBook() 
  //      { 
  //          return gradeManager.GetGradeBookByUserId(Userid); 
  //      }

  //      public void AddSubjectGradesToGradeBook(SubjectGrades subjectGrades)
  //      {
  //          gradeManager.AddSubjectGrades(subjectGrades);
  //      }
  //      public List<Grade> GetGradesBySubject(Subject subject)
  //      {
  //          foreach (SubjectGrades subjectGrades in GetGradeBook())
  //          {
  //              if (subjectGrades.Subject == subject)
  //              {
  //                  return subjectGrades.GetGrades();
  //              }
  //          }
  //          return null;
  //      }
    }
}

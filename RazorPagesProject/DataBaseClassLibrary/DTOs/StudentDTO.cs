using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseClassLibrary.DTOs
{
    internal class StudentDTO : UserDTO
    {

        private readonly List<SubjectGrades> _gradebook = new List<SubjectGrades>();

        public readonly List<SubjectGrades> GradeBook
        {
            get { return _gradebook; }
            set { /* do nothing */ }
        }

        public StudentDTO()
        {
            //userManager = new UserManager();
            //gradeManager = new GradeManager();
        }

        public StudentDTO(string FirstName, string LastName, Role Role, int Class, string Email, string PhoneNumber, int UserID)
            : base(FirstName, LastName, Role, Class, Email, PhoneNumber, UserID)
        {

        }
        
    }
}

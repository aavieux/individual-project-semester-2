using DataBaseClassLibrary.DTOs.DTOEnums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseClassLibrary.DTOs
{
    public class StudentDTO : UserDTO
    {

        private List<SubjectGradesDTO> _gradebook = new List<SubjectGradesDTO>();

        public List<SubjectGradesDTO> GradeBook
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

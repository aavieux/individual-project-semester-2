using ClassLibrary.Controllers;
using ClassLibrary.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesProject.Pages
{
    public class _SubjectGradesViewModel : PageModel
    {
        
        [BindProperty(SupportsGet = true)]
        internal int studentid { get; set; }
        internal Student currentStudent { get; set; }

        internal GradeManager gradeManager { get; set; }
        internal UserManager UserManager { get; set; }
        public _SubjectGradesViewModel()
        {
            gradeManager = new GradeManager();
            UserManager = new UserManager();
        }
        public void OnGet()
        {
            studentid = int.Parse(Request.Query["userId"]);
            currentStudent = UserManager.GetStudentById(studentid);
        }
        public List<SubjectGrades> GetGradeBookByStudent(Student student)
        {
            return gradeManager.GetGradeBookByUserId(student.Userid);
        }

    }
}

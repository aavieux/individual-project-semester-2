using ClassLibrary.Controllers;
using ClassLibrary.DatabaseHelpers;
using ClassLibrary.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesProject.Pages
{
    public class GradesModel : PageModel
    {
        internal UserManager userManager { get; set; }
        internal GradeManager gradeManager { get; set; }

        internal List<Student> currentStudents;
        public GradesModel()
        {
            userManager = new UserManager();
            gradeManager = new GradeManager();
        }
        public void OnGet()
        {
            
        }
        public async Task<IActionResult> OnPostSearchByName()
        {
            string partOfName = Request.Form["search"];
            currentStudents = new List<Student>();
            currentStudents = userManager.GetStudentsByPartOfName(partOfName);
            return Page();
        }
        public List<SubjectGrades> GetGradeBookByStudentId(int studentId)
        {
            return gradeManager.GetGradeBookByUserId(studentId);
        }
    }
}

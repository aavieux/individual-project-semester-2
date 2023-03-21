using ClassLibrary.Controllers;
using ClassLibrary.DatabaseHelpers;
using ClassLibrary.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesProject.Pages
{
    public class StudentsModel : PageModel
    {
        internal List<Student> students { get; set; }
        internal List<Student> foundStudents { get; set; }
        internal List<Student> pastebinList { get; set; }
        internal bool foundUsers { get; set; }

        private UserManager userManager { get; set; }

        public StudentsModel()
        {
            userManager = new UserManager();
        }
        public void OnGet()
        {
            students = userManager.GetAllStudents();
        }
        public async Task<IActionResult> OnPostSearchByName()
        {
            foundUsers = false;

            students = userManager.GetAllStudents();
            string partOfName = Request.Form["search"];
            foundStudents = new List<Student>();
            foundStudents = userManager.GetStudentsByPartOfName(partOfName);
            if (foundStudents.Count != 0)
            {
                foundUsers = true;
            }
            return Page();
        }
        internal string? GetTeacherNameById(int Id)
        {
            if (Id == null)
            {
                return null;
            }
            else
            {
                string? teacherFullName = userManager.GetTeacherById(Id).GetFullName();
                return teacherFullName;
            }
        }
    }
}

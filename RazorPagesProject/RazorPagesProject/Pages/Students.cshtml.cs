using ClassLibrary.Controllers;
using ClassLibrary.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesProject.Pages
{
    public class StudentsModel : PageModel
    {
        internal List<Student> students;
        internal List<Student> foundStudents { get; set; }
        internal List<Student> pastebinList { get; set; }
        internal bool foundUsers { get; set; }

        private StatisticsManager statisticsManager;
        public StudentsModel()
        {
            this.statisticsManager = new StatisticsManager();
        }
        public void OnGet()
        {
            students = statisticsManager.GetAllStudents();
        }
        public async Task<IActionResult> OnPostSearchByName()
        {
            foundUsers = false;

            students = statisticsManager.GetAllStudents();
            string partOfName = Request.Form["search"];
            foundStudents = new List<Student>();
            foundStudents = statisticsManager.GetStudentsByPartOfName(partOfName);
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
                string? teacherFullName = statisticsManager.GetTeacherById(Id).GetFullName();
                return teacherFullName;
            }
        }
    }
}

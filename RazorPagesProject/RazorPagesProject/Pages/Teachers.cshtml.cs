using ClassLibrary.Controllers;
using ClassLibrary.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesProject.Pages
{
    public class TeachersModel : PageModel
    {
        internal List<Teacher> teachers { get; set; }
        internal List<Teacher> foundTeachers { get; set; }
        internal List<Teacher> pastebinList { get; set; }
        internal bool foundUsers { get; set; }

        private StatisticsManager statisticsManager;

        public TeachersModel()
        {
            statisticsManager = new StatisticsManager();
        }
        public void OnGet()
        {
            teachers = statisticsManager.GetAllTeachers();
        }
        public async Task<IActionResult> OnPostSearchByName()
        {
            foundUsers = false;

            teachers = statisticsManager.GetAllTeachers();
            string partOfName = Request.Form["search"];
            foundTeachers = new List<Teacher>();
            foundTeachers = statisticsManager.GetTeachersByPartOfName(partOfName);
            if (foundTeachers.Count != 0)
            {
                foundUsers = true;
            }
            return Page();
        }
    }
}

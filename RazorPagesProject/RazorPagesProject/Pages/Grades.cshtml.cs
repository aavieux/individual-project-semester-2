using ClassLibrary.Controllers;
using ClassLibrary.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesProject.Pages
{
    public class GradesModel : PageModel
    {
        [BindProperty]
        internal string search { get; set; }

        StatisticsManager statisticsManager;
        internal List<Student> currentStudents;
        public GradesModel()
        {
            statisticsManager = new StatisticsManager();
        }
        public void OnGet()
        {
            
        }
        public async Task<IActionResult> OnPostSearchByName()
        {
            string search = Request.Form["search"];
            currentStudents = new List<Student>();
            currentStudents = statisticsManager.GetStudentsByPartOfName(search);
            return Page();
        }
    }
}

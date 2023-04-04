using ClassLibrary.Controllers;
using ClassLibrary.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesProject.Pages
{
    public class _ClassroomViewModel : PageModel
    {
        [BindProperty]
        public int className { get; set; }
        internal List<Student> students { get; set; }

        internal StatisticsManager statisticsManager;

        public _ClassroomViewModel()
        {
            statisticsManager = new StatisticsManager();
            students = new List<Student>();
        }

        public void OnGet()
        {
            className = int.Parse(Request.Query["className"]);
            students = statisticsManager.GetClassById(className).GetStudents();// add exception check
        }
    }
}

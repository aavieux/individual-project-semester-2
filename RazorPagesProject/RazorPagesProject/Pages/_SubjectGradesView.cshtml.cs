using ClassLibrary.Controllers;
using ClassLibrary.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesProject.Pages
{
    public class _SubjectGradesViewModel : PageModel
    {
        
        [BindProperty]
        public int userId { get; set; }
        internal Student currentStudent { get; set; }

        private StatisticsManager statisticsManager;
        public _SubjectGradesViewModel()
        {
           statisticsManager = new StatisticsManager();
        }
        public void OnGet()
        {
            currentStudent = statisticsManager.GetStudentById(userId);
        }
    }
}

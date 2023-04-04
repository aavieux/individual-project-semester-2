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

        internal StatisticsManager statisticsManager;
        public _SubjectGradesViewModel()
        {
           statisticsManager = new StatisticsManager();
        }
        public void OnGet()
        {
            studentid = int.Parse(Request.Query["userId"]);
            currentStudent = statisticsManager.GetStudentById(studentid);
        }
    }
}

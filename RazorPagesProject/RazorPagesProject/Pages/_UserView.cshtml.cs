using ClassLibrary.Controllers;
using ClassLibrary.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesProject.Pages
{
    public class _UserViewModel : PageModel
    {
        [BindProperty]
        internal int userId { get; set; }

        internal User currentUser { get; set; }

        private StatisticsManager statisticsManager;

        public _UserViewModel()
        {
            statisticsManager = new StatisticsManager();
        }
        public void OnGet()
        {
            userId = int.Parse(Request.Query["userId"]);
            currentUser = statisticsManager.GetUserById(userId);
        }
    }
}

using ClassLibrary.Controllers;
using ClassLibrary.DatabaseHelpers;
using ClassLibrary.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesProject.Pages
{
    public class _UserViewModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        internal int userId { get; set; }
        internal User currentUser { get; set; }

        private UserManager userManager { get; set; }

        public _UserViewModel()
        {
            userManager = new UserManager();
        }
        public void OnGet()
        {
            userId = int.Parse(Request.Query["userId"]);
            currentUser = userManager.GetUserById(userId);
        }
    }
}

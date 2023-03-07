using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesProject.Models;

namespace RazorPagesProject.Pages
{
    public class _UserViewModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public int userId { get; set; }
        public User currentUser { get; set; }
        public void OnGet()
        {
            userId = int.Parse(Request.Query["userId"]);
            currentUser = Administration.GetUserFromLocal(userId);
        }
    }
}

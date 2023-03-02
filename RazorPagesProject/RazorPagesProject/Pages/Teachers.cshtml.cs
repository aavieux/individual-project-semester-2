using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesProject.Models;

namespace RazorPagesProject.Pages
{
    public class TeachersModel : PageModel
    {
        internal List<Teacher> teachers { get; set; }

        public void OnGet()
        {
            teachers = Administration.GetTeachersFromLocal();
        }
    }
}

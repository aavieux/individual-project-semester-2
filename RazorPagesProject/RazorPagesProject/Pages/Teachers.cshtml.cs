using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesProject.wwwroot.Models;

namespace RazorPagesProject.Pages
{
    public class TeachersModel : PageModel
    {
        public List<Teacher> teachers { get; set; }

        public void OnGet()
        {
            teachers = Administration.teachers;
        }

    }
}

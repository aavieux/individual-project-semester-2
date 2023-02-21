using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesProject.wwwroot.Models;

namespace RazorPagesProject.Pages
{
    public class _UserViewModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public string userIdTeacher { get; set; }
        public Teacher currentTeacher { get; set; }
        public void OnGet()
        {
            userIdTeacher = Request.Query["userIdTeacher"];
            currentTeacher = Administration.GetTeacherFromLocal(userIdTeacher);
        }
    }
}

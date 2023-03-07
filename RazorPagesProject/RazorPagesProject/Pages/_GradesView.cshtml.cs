using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesProject.Models;

namespace RazorPagesProject.Pages
{
    public class _GradesViewModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        internal int studentid { get; set; }
        internal Student currentStudent { get; set; }
        public void OnGet()
        {
            studentid = int.Parse(Request.Query["userId"]);
            currentStudent = Administration.GetStudentFromLocal(studentid);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesProject.Models;

namespace RazorPagesProject.Pages
{
    public class GradesModel : PageModel
    {
        internal List<Student> currentStudents;
        public void OnGet()
        {
        }
        public async Task<IActionResult> OnPostSearchByName()
        {
            string partOfName = Request.Form["search"];
            currentStudents = new List<Student>();
            currentStudents = Administration.GetStudentsFromLocalByPartOfName(partOfName);

            return Page();
        }
    }
}

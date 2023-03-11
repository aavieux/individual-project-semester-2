using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesProject.Models;

namespace RazorPagesProject.Pages
{
    public class StudentsModel : PageModel
    {
        internal List<Student> students { get; set; }
        internal List<Student> foundStudents { get; set; }
        internal List<Student> pastebinList { get; set; }
        internal bool foundUsers { get; set; }
        public void OnGet()
        {
            students = Administration.GetStudentsFromLocal();
        }
        public async Task<IActionResult> OnPostSearchByName()
        {
            foundUsers = false;

            students = Administration.GetStudentsFromLocal();
            string partOfName = Request.Form["search"];
            foundStudents = new List<Student>();
            foundStudents = Administration.GetStudentsFromLocalByPartOfName(partOfName);
            if (foundStudents.Count != 0)
            {
                foundUsers = true;
            }
            return Page();
        }
    }
}

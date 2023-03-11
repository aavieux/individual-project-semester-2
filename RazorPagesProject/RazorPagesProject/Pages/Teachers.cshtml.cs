using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesProject.Models;

namespace RazorPagesProject.Pages
{
    public class TeachersModel : PageModel
    {
        internal List<Teacher> teachers { get; set; }
        internal List<Teacher> foundTeachers { get; set; }
        internal List<Teacher> pastebinList { get; set; }
        internal bool foundUsers { get; set; }

        public void OnGet()
        {
            teachers = Administration.GetTeachersFromLocal();
        }
        public async Task<IActionResult> OnPostSearchByName()
        {
            foundUsers= false;

            teachers = Administration.GetTeachersFromLocal();
            string partOfName = Request.Form["search"];
            foundTeachers = new List<Teacher>();
            foundTeachers = Administration.GetTeachersFromLocalByPartOfName(partOfName);
            if (foundTeachers.Count != 0)
            {
                foundUsers = true;
            }
            return Page();
        }
    }
}

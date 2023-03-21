using ClassLibrary.Controllers;
using ClassLibrary.DatabaseHelpers;
using ClassLibrary.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesProject.Pages
{
    public class TeachersModel : PageModel
    {
        internal List<Teacher> teachers { get; set; }
        internal List<Teacher> foundTeachers { get; set; }
        internal List<Teacher> pastebinList { get; set; }
        internal bool foundUsers { get; set; }

        private UserManager userManager { get; set; }

        public TeachersModel()
        {
            userManager = new UserManager();
        }
        public void OnGet()
        {
            teachers = userManager.GetAllTeachers();
        }
        public async Task<IActionResult> OnPostSearchByName()
        {
            foundUsers = false;

            teachers = userManager.GetAllTeachers();
            string partOfName = Request.Form["search"];
            foundTeachers = new List<Teacher>();
            foundTeachers = userManager.GetTeachersByPartOfName(partOfName);
            if (foundTeachers.Count != 0)
            {
                foundUsers = true;
            }
            return Page();
        }
    }
}

using ClassLibrary.Controllers;
using ClassLibrary.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesProject.Pages
{
    public class _ClassroomViewModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public int className { get; set; }
        internal List<Student> students { get; set; }

        //private UserManager userManager { get; set; }
        //private GradeManager gradeManager { get; set; }
        internal ClassManager classManager { get; set; }

        public _ClassroomViewModel()
        {
            //gradeManager = new GradeManager();
            classManager = new ClassManager();
            //userManager = new UserManager();
        }

        public void OnGet()
        {
            className = int.Parse(Request.Query["className"]);
            students = classManager.GetClassStudentsById(className);// add exception check
        }
    }
}

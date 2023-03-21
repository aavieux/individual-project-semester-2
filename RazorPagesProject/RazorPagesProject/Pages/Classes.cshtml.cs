using ClassLibrary.Controllers;
using ClassLibrary.DatabaseHelpers;
using ClassLibrary.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesProject.Pages
{
    
    public class ClassesModel : PageModel
    {
        internal List<Class> classes { get; set; }

        internal ClassManager classManager { get; set; }
        internal UserManager UserManager { get; set; }

        public ClassesModel()
        {
            classManager = new ClassManager();
            UserManager = new UserManager();
        }

        public void OnGet()
        {
            classes = classManager.GetAllClasses();
        }
        public string GetTeacherNameById(int teacherId)
        {
            return UserManager.GetTeacherById(teacherId).GetFullName();
        }
        
    }
}

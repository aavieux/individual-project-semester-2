using ClassLibrary.Controllers;

using ClassLibrary.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesProject.Pages
{
    
    public class ClassesModel : PageModel
    {
        internal List<Class> classes { get; set; }

        internal StatisticsManager statisticsManager;

        public ClassesModel()
        {
            statisticsManager = new StatisticsManager();
        }

        public void OnGet()
        {
            classes = statisticsManager.GetAllClasses();
        }
        public string GetTeacherNameById(int teacherId)
        {
            return statisticsManager.GetTeacherById(teacherId).GetFullName();
        }
        
    }
}

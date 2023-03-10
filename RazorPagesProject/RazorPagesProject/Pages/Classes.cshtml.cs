using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesProject.Models;

namespace RazorPagesProject.Pages
{
    public class ClassesModel : PageModel
    {
        internal List<Class> classes { get; set; }
        internal string? GetTeacherById(int? Id)
        {
            if (Id == null)
            {
                return null;
            }
            else
            {
                string? teacherFullName = Administration.GetTeacherFromLocal(Id).GetFullName();
                return teacherFullName;
            }
        }
        public void OnGet()
        {
            classes = Administration.GetClassesFromLocal();
        }
    }
}

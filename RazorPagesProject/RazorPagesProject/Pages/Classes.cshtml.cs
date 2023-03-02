using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesProject.Models;

namespace RazorPagesProject.Pages
{
    public class ClassesModel : PageModel
    {
        internal List<Class> classes { get; set; }

        public void OnGet()
        {
            classes = Administration.GetClassesFromLocal();
        }
    }
}

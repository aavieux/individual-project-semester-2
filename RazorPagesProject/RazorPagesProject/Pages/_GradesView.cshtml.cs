using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesProject.Models;

namespace RazorPagesProject.Pages
{
    public class _GradesViewModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        internal int subjectGradesId { get; set; }
        internal List<Grade> grades;
        public void OnGet()
        {
            grades = new List<Grade>();
            subjectGradesId = int.Parse(Request.Query["subjectGradesId"]);

            grades = Administration.GetSubjectGradesById(subjectGradesId).Grades;
        }
    }
}

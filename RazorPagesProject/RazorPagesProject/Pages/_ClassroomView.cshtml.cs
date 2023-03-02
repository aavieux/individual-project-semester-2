using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesProject.Models;

namespace RazorPagesProject.Pages
{
    public class _ClassroomViewModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public int className { get; set; }
        internal List<Student> students { get; set; }
        public void OnGet()
        {
            className = int.Parse(Request.Query["className"]);

            try
            {
                foreach (int studentID in Administration.GetClassFromLocal(className).GetStudentsIds())
                {
                    students.Add(Administration.GetStudentFromLocal(studentID));
                }
            }
            catch (Exception)
            {
                Console.WriteLine("StudentsIds was null or smth");

            }
           
        }
    }
}

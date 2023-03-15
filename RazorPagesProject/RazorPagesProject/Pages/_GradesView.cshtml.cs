using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesProject.Models;
using RazorPagesProject.Models.Enums;

namespace RazorPagesProject.Pages
{
    public class _GradesViewModel : PageModel
    {
		[BindProperty(SupportsGet = true)]
		internal int studentid { get; set; }
		internal Student currentStudent { get; set; }
		public void OnGet()
		{
			studentid = int.Parse(Request.Query["userId"]);//tuka e problema nisht one mu se puska sled kato cukna da addna grade
			currentStudent = Administration.GetStudentFromLocal(studentid);
		}
		public async Task<IActionResult> OnPostAddGrade(string Button1, string Button2, string Button3, string Button4,int subjectGradesId) 
		{
			string buttonClicked = null;
			int currentSubjectGradesId = subjectGradesId;

			if (Button1 != null)
			{
				buttonClicked = "UNDEFINED";
			}
			else if (Button2 != null)
			{
				buttonClicked = "SUFFICIENT";
			}
			else if (Button3 != null)
			{
				buttonClicked = "GOOD";
			}
			else if (Button4 != null)
			{
				buttonClicked = "OUTSTANDING";
			}

			Grade currentGrade = new Grade(Administration.GetLastIdForGrades() + 1,currentSubjectGradesId, Enum.Parse<GradeEnum>(buttonClicked));
			Administration.GetSubjectGradesById(currentSubjectGradesId).AddGradeToGrades(currentGrade);

			return RedirectToPage("/_GradesView");
		}
	}
}

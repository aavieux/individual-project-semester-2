using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesProject.Models;
using RazorPagesProject.Models.Enums;
using System.Diagnostics;
using System.Reflection;

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
		public async Task<IActionResult> OnPostAddGrade(string Button1, string Button2, string Button3, string Button4,int SubjectGradesId, int UserId) 
		{
			string buttonClicked = null;
			int currentSubjectGradesId = SubjectGradesId;

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

			try
			{
				Grade currentGrade = new Grade(Administration.GetNextAvailableId(), currentSubjectGradesId, Enum.Parse<GradeEnum>(buttonClicked));
				Administration.GetSubjectGradesById(currentSubjectGradesId).AddNewGradeToGradesAndDB(currentGrade);
			}
			catch (Exception)
			{
				Console.WriteLine("Error saving changes!");
			}
			

			return RedirectToPage("/_GradesView", new { userId = UserId });// passes the user id from the previous page
		}
		public async Task<IActionResult> OnPostDeleteGrade(int GradeId, int SubjectGradesId, int UserId)
		{
			int currentSubjectGradesId = SubjectGradesId;

			try
			{
				Administration.GetSubjectGradesById(currentSubjectGradesId).DeleteGradeFromGradesAndDBById(GradeId);
			}
			catch (Exception)
			{
				Console.WriteLine("Error saving changes!");
			}

			return RedirectToPage("/_GradesView", new { userId = UserId });
		}
	}
}

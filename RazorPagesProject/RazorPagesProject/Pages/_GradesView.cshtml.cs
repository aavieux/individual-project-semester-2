using ClassLibrary.Controllers;
using ClassLibrary.Models;
using ClassLibrary.Models.Enums;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Diagnostics;
using System.Reflection;

namespace RazorPagesProject.Pages
{
    public class _GradesViewModel : PageModel
    {
		[BindProperty(SupportsGet = true)]
        internal int userId { get; set; }

		internal Student currentStudent { get; set; }
        private StatisticsManager statisticsManager;

        public _GradesViewModel()
        {
			this.statisticsManager = new StatisticsManager();
        }
        public void OnGet()
		{
            userId = int.Parse(Request.Query["userId"]);
            currentStudent = statisticsManager.GetStudentById(userId);
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
				Grade currentGrade = new Grade(Enum.Parse<GradeEnum>(buttonClicked));
				statisticsManager.GetStudentById(UserId).AddGrade(currentSubjectGradesId, currentGrade);
			}
			catch (Exception)
			{
				Console.WriteLine("Error saving changes!");
			}
			

			return RedirectToPage("/_GradesView", new { userId = UserId });// passes the user id from the previous page
		}
		public async Task<IActionResult> OnPostDeleteGrade(int GradeId, int SubjectGradesId, int UserId)
		{
			int currentSubjectGradesId = SubjectGradesId; // to be removed
			try
			{
                statisticsManager.GetStudentById(UserId).DeleteGrade(GradeId);
			}
			catch (Exception)
			{
				Console.WriteLine("Error saving changes!");
			}

			return RedirectToPage("/_GradesView", new { userId = UserId });
		}

		public List<Grade>? GetGradesFromSubjectGrades(SubjectGrades subjectGrades)
		{
			foreach (SubjectGrades subjectGrades1 in currentStudent.GetGradeBook())
			{
				if (subjectGrades.Id == subjectGrades1.Id)
				{
					return (subjectGrades.GetGrades());
				}
			}
			return null;

		}
	}
}

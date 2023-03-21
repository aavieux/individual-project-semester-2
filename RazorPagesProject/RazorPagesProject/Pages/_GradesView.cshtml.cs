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
        internal int studentid { get; set; }
		internal Student currentStudent { get; set; }

        internal GradeManager gradeManager { get; set; }
        internal UserManager UserManager { get; set; }
        public _GradesViewModel()
        {
            gradeManager = new GradeManager();
            UserManager = new UserManager();
        }
        public void OnGet()
		{
            studentid = int.Parse(Request.Query["userId"]);//tuka e problema nisht one mu se puska sled kato cukna da addna grade
			currentStudent = UserManager.GetStudentById(studentid);
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
				gradeManager.AddGradeToSubjectGrades(currentSubjectGradesId, currentGrade);
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
                gradeManager.DeleteGradeFromSubjectGrades(currentSubjectGradesId, GradeId);
			}
			catch (Exception)
			{
				Console.WriteLine("Error saving changes!");
			}

			return RedirectToPage("/_GradesView", new { userId = UserId });
		}

		public List<SubjectGrades> GetGradeBookFromStudent(Student currentStudent)
		{
			return gradeManager.GetGradeBookByUserId(currentStudent.Userid);
		}
		public List<Grade>? GetGradesFromSubjectGrades(SubjectGrades subjectGrades)
		{
			return gradeManager.GetGradesBySubjectGrades(subjectGrades);
		}
		public void PutGradesIntoSubjectGradesAndToStudent(List<Grade> grades, List<SubjectGrades> subjectGrades, Student student)
		{
			foreach (Grade grade in grades)
			{
				
			}
		}

	}
}

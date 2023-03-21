using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.Controllers;
using ClassLibrary.Models.Enums;

namespace ClassLibrary.Models
{
	public class SubjectGrades

	{
		private int _idSubjectGrades;
		private Subject _subject;
		private int _idUser;

		private List<Grade> grades;
		//private GradeManager gradeManager;

		public int Id { get { return _idSubjectGrades; } set { _idSubjectGrades = value; } }
		public Subject Subject { get { return _subject; } set { _subject = value; } }
		public int IdUser { get { return _idUser; } set { _idUser = value; } }

		public List<Grade> Grades { get { return grades; } set { grades = value; } }
		public SubjectGrades()
		{
			//gradeManager = new GradeManager();
		}

		//public List<Grade> GetGrades()
		//{
		//	return gradeManager.GetGrades(_idSubjectGrades);
		//}
		//public void AddGradeToGrades(Grade grade)
		//{
		//	gradeManager.AddGradeToSubjectGrades(_idSubjectGrades,grade);
		//}
  //      public void DeleteGrade(int gradeId)
  //      {
  //          gradeManager.DeleteGradeFromSubjectGrades(_idSubjectGrades, gradeId);
  //      }
    }
}

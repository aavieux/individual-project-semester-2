using RazorPagesProject.Models.Enums;
using System.Data.SqlClient;

namespace RazorPagesProject.Models
{
    public class SubjectGrades

    {
        private int _idSubjectGrades;
        private Subject _subject;
        private int _idUser;

        private List<Grade> grades = new List<Grade>();

        public int Id { get { return _idSubjectGrades; } set { _idSubjectGrades = value; } }
        public Subject Subject { get { return _subject; } set { _subject = value; } }
        public int IdUser { get { return _idUser; } set { _idUser = value;} }

        //public List<Grade> Grades { get { return grades; } set { grades = value; } }

        public List <Grade> GetGrades() 
        { 
            return grades; 
        }
		public void AddGradeToGrades(Grade grade)
		{
			grades.Add(grade);
		}

		public void AddNewGradeToGradesAndDB(Grade grade)
        {
			using (SqlConnection connection =
				   new SqlConnection("Server=localhost;Database=individual_project_semester2;Trusted_Connection=True;"))
			{
				connection.Open();
				string query = $"INSERT INTO Grades (id_grade, id_subjectGrades, grade) VALUES ({grade.IdGrade}, {_idSubjectGrades}, '{grade.GradeEnum.ToString()}');";

				using (SqlCommand command = new SqlCommand(query, connection))
				{
					try
					{
                        command.ExecuteNonQuery();
						Console.WriteLine("Records Inserted in DB Successfully");

						grades.Add(grade);
						Administration.AddGrade(grade);
						Console.WriteLine("Records Inserted Locally Successfully");

					}
					catch (SqlException e)
					{
						Console.WriteLine("Error Generated. Details: " + e.ToString());
					}
					finally
					{
						connection.Close();
					}
				}
			}
			
        }
		public void DeleteGradeFromGradesAndDBById(int GradeId)
		{
			using (SqlConnection connection =
				   new SqlConnection("Server=localhost;Database=individual_project_semester2;Trusted_Connection=True;"))
			{
				connection.Open();
				string query = $"DELETE FROM Grades WHERE id_grade LIKE '{GradeId}'";

				using (SqlCommand command = new SqlCommand(query, connection))
				{
					try
					{
						command.ExecuteNonQuery();
						Console.WriteLine("Records Deleted From DB Successfully");

						grades.RemoveAll(grade => grade.IdGrade == GradeId);
						Administration.GetGrades().RemoveAll(grade => grade.IdGrade == GradeId);

						Console.WriteLine("Records Deleted From Local Successfully");

					}
					catch (SqlException e)
					{
						Console.WriteLine("Error Generated. Details: " + e.ToString());
					}
					finally
					{
						connection.Close();
					}
				}
			}

		}

	}
}
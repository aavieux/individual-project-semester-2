//using ClassLibrary.Models.Enums;
//using ClassLibrary.Models;
using DataBaseClassLibrary.DTOs;
using DataBaseClassLibrary.DTOs.DTOEnums;
using DataBaseClassLibrary.Interfaces;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseClassLibrary.DatabaseHelpers
{
    public class GradeDatabaseHelper : IGradeDbHelper
    {
        private readonly IConfiguration _configuration;
        private readonly string connectionString;

        public GradeDatabaseHelper(IConfiguration configuration)
        {
            _configuration = configuration;
            connectionString = _configuration.GetConnectionString("DefaultConnectionString");
        }
        public List<SubjectGradesDTO> GetGradeBooksFromDB()
        {
            using (SqlConnection connection =
                   new SqlConnection(connectionString))
            {

                try
                {
                    connection.Open();
                    string query = "SELECT * FROM SubjectGrades";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            try
                            {
                                List<SubjectGradesDTO> inSubjectGrades = new List<SubjectGradesDTO>();
                                while (reader.Read())
                                { 
                                    try
                                    {
                                        SubjectGradesDTO _subjectGrades = new SubjectGradesDTO(
                                            (int)reader["id_subjectGrades"], 
                                            Enum.Parse<Subject>(reader["subject"].ToString()), 
                                            (int)reader["id_user"]);

                                        inSubjectGrades.Add(_subjectGrades);
                                    }
                                    catch (Exception)
                                    {
                                        Console.WriteLine("Error getting subjectgrades from database!");
                                    }
                                }
                                return inSubjectGrades;
                            }
                            catch (SqlException xException)
                            {
                                Console.WriteLine("Error loading subjectgrades from database!");
                                return null;
                            }
                            finally
                            {
                                reader.Close();
                                connection.Close();
                            }
                        }
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("There was a problem in making a connection with the database!");
                    return null;
                }
            }
        }
        public List<GradeDTO> GetGradesFromDB()
        {
            using (SqlConnection connection =
                   new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM Grade";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            try
                            {
                                List<GradeDTO> inGrades = new List<GradeDTO>();
                                while (reader.Read())
                                {
                                    try
                                    {
                                        GradeDTO grade = new GradeDTO(
                                            (int)reader["id_grade"], 
                                            (int)reader["id_subjectGrades"], 
                                            Enum.Parse<GradeEnum>(reader["grade"].ToString()));


                                        inGrades.Add(grade);
                                    }
                                    catch (Exception)
                                    {
                                        Console.WriteLine("Error getting grades from database!");
                                    }
                                }
                                return inGrades;
                            }
                            catch (SqlException xException)
                            {
                                Console.WriteLine("Error loading grades from database!");
                                return null;
                            }
                            finally
                            {
                                reader.Close();
                                connection.Close();
                            }
                        }
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("There was a problem in making a connection with the database!");
                    return null;
                }
            }
        }
        public List<SubjectGradesDTO> GetSubjectGradesFromDB()
        {
            using (SqlConnection connection =
                   new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM SubjectGrades";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            try
                            {
                                List<SubjectGradesDTO> inGrades = new List<SubjectGradesDTO>();
                                while (reader.Read())
                                {
                                    try
                                    {
                                        SubjectGradesDTO grade = new SubjectGradesDTO(
                                            (int)reader["id_subjectGrades"],
                                            Enum.Parse<Subject>((string)reader["subject"]),
                                            (int)reader["id_user"]);

                                        inGrades.Add(grade);
                                    }
                                    catch (Exception)
                                    {
                                        Console.WriteLine("Error getting grades from database!");
                                    }
                                }
                                return inGrades;
                            }
                            catch (SqlException xException)
                            {
                                Console.WriteLine("Error loading grades from database!");
                                return null;
                            }
                            finally
                            {
                                reader.Close();
                                connection.Close();
                            }
                        }
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("There was a problem in making a connection with the database!");
                    return null;
                }
            }
        }
  //      public List<GradeDTO> GetGradesBySubjectGradesFromDB(int subjectGradesId)
  //      {
		//	using (SqlConnection connection =
		//		   new SqlConnection("Server=localhost;Database=individual_project_semester2;Trusted_Connection=True;"))
		//	{
		//		try
		//		{
		//			connection.Open();
		//			string query = $"SELECT * FROM Grades WHERE id_subjectGrades LIKE '{subjectGradesId}'";

		//			using (SqlCommand command = new SqlCommand(query, connection))
		//			{
		//				using (SqlDataReader reader = command.ExecuteReader())
		//				{
		//					try
		//					{
		//						List<GradeDTO> inGrades = new List<GradeDTO>();
		//						while (reader.Read())
		//						{
  //                                  try 
  //                                  {
  //                                      GradeDTO grade = new GradeDTO(
  //                                          (int)reader["id_grade"], 
  //                                          (int)reader["id_subjectGrades"], 
  //                                          Enum.Parse<GradeEnum>(reader["grade"].ToString()));

  //                                      inGrades.Add(grade);
		//							}
		//							catch (Exception)
		//							{
		//								Console.WriteLine("Error getting grades from database!");
		//							}
		//						}
		//						return inGrades;
		//					}
		//					catch (SqlException xException)
		//					{
		//						Console.WriteLine("Error loading grades from database!");
		//						return null;
		//					}
		//					finally
		//					{
		//						reader.Close();
		//						connection.Close();
		//					}
		//				}
		//			}
		//		}
		//		catch (Exception)
		//		{
		//			Console.WriteLine("There was a problem in making a connection with the database!");
		//			return null;
		//		}
		//	}
		//}
		public void AddSubjectGradesToDB(SubjectGradesDTO subjectGrades)
        {
            using (SqlConnection connection =
                   new SqlConnection(connectionString))
            {
                connection.Open();
                string query = $"INSERT INTO SubjectGrades (subject, id_user) VALUES ('{subjectGrades.Subject.ToString()}', '{subjectGrades.IdUser}');";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        command.ExecuteNonQuery();
                        Console.WriteLine("-----------------------------------");
                        Console.WriteLine("Records Inserted in DB Successfully");
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
        public void AddGradeToDB(int idSubjectGrades , GradeDTO grade)
        {
            using (SqlConnection connection =
                   new SqlConnection(_configuration.GetConnectionString("DefaultConnectionString")))
            {
                connection.Open();
                string query = $"INSERT INTO Grade (id_subjectGrades, grade) VALUES ('{idSubjectGrades}', '{grade.GradeEnum.ToString()}');";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        command.ExecuteNonQuery();
                        Console.WriteLine("-----------------------------------");
                        Console.WriteLine("Records Inserted in DB Successfully");
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

        public bool DeleteSubjectGradesFromDB(SubjectGradesDTO subjectGradesDTO)
        {
            using (SqlConnection connection =
                   new SqlConnection(connectionString))
            {
                connection.Open();
                string query = $"DELETE FROM SubjectGrades WHERE id_subjectGrades LIKE '{subjectGradesDTO.Id}'";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        command.ExecuteNonQuery();
                        Console.WriteLine("-----------------------------------");
                        Console.WriteLine("Records Deleted From DB Successfully");
                        return true;
                    }
                    catch (SqlException e)
                    {
                        Console.WriteLine("Error Generated. Details: " + e.ToString());
                        return false;
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }
        public void DeleteGradeByIdFromDB(int GradeId)
        {
            using (SqlConnection connection =
                   new SqlConnection(connectionString))
            {
                connection.Open();
                string query = $"DELETE FROM Grade WHERE id_grade LIKE '{GradeId}'";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        command.ExecuteNonQuery();
                        Console.WriteLine("-----------------------------------");
                        Console.WriteLine("Records Deleted From DB Successfully");
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

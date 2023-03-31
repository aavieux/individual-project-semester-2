//using ClassLibrary.Models;
//using ClassLibrary.Models.Enums;
using DataBaseClassLibrary.DTOs;
using DataBaseClassLibrary.DTOs.DTOEnums;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseClassLibrary.DatabaseHelpers
{
    public class ClassDatabaseHelper
    {
        internal List<ClassDTO> GetClassesFromDB()
        {
            using (SqlConnection connection =
                   new SqlConnection("Server=localhost;Database=individual_project_semester2;Trusted_Connection=True;"))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM Classes";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            try
                            {
                                List<ClassDTO> inClasses = new List<ClassDTO>();
                                while (reader.Read())
                                {
                                    ClassDTO _class = new ClassDTO((int)reader["name_class"]);
                                    try
                                    {
                                        _class.TeacherID = (int)reader["user_class"];
                                    }
                                    catch (Exception)
                                    {
                                        _class.TeacherID = 0;
                                    }
                                    inClasses.Add(_class);
                                }
                                return inClasses;
                            }
                            catch (SqlException xException)
                            {
                                Console.WriteLine("Error loading teachers from database!");
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
        internal List<StudentDTO> GetClassStudentsFromDB(int classId)
        {
            using (SqlConnection connection =
                   new SqlConnection("Server=localhost;Database=individual_project_semester2;Trusted_Connection=True;"))
            {
                try
                {
                    connection.Open();
                    string query = $"SELECT * FROM Users WHERE class_user = (SELECT class_user FROM Classes WHERE name_class = '{classId}') AND role_user = 'STUDENT';";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            List<StudentDTO> students = new List<StudentDTO>();
                            while (reader.Read())
                            {
                                StudentDTO student = new StudentDTO();
                                student.Firstname = (string)reader["first_name_user"];
                                student.Lastname = (string)reader["last_name_user"];

                                student.Role = Enum.Parse<Role>(reader["role_user"].ToString());
                                try
                                {
                                    student.Class = (int)reader["class_user"];
                                }
                                catch (Exception)
                                {
                                    student.Class = null;
                                }
                                //TODO
                                student.Email = (string)reader["email_user"];
                                student.PhoneNumber = (string)reader["phonenumber_user"];
                                student.Userid = (int)reader["id_user"];



                                students.Add(student);
                            }
                            return students;
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
    }
}

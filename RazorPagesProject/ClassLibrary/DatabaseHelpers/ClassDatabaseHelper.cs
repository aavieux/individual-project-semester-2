using ClassLibrary.Models;
using ClassLibrary.Models.Enums;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.DatabaseHelpers
{
    public class ClassDatabaseHelper
    {
        internal List<Class> GetClassesFromDB()
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
                                List<Class> inClasses = new List<Class>();
                                while (reader.Read())
                                {
                                    Class _class = new Class((int)reader["name_class"]);
                                    try
                                    {
                                        _class.TeacherID = (int)reader["teacher_id_class"];
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
        internal List<Student> GetClassStudentsFromDB(int classId)
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
                            List<Student> students = new List<Student>();
                            while (reader.Read())
                            {
                                Student student = new Student();
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

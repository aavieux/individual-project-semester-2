using System.Collections.Generic;
using System.Data.SqlClient;

namespace RazorPagesProject.wwwroot.Models
{
    public class Administration
    {
        public static List<Teacher> teachers = new List<Teacher>();
        
        
        public static void GetTeachersFromDataBase()
        {
            using (SqlConnection connection =
                   new SqlConnection("Server=localhost;Database=individual_project_semester2;Trusted_Connection=True;"))
            {
                connection.Open();
                string query = "SELECT * FROM Teachers";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        try
                        {
                            while (reader.Read())
                            {
                                Teacher teacher = new Teacher();
                                teacher.Firstname = (string)reader["first_name_teacher"];
                                teacher.Lastname = (string)reader["last_name_teacher"];
                                teacher.Role = (string)reader["role_teacher"];
                                teacher.Class = (string)reader["class_teacher"];
                                teacher.Email = (string)reader["email_teacher"];
                                teacher.PhoneNumber = (string)reader["phonenumber_teacher"];
                                teacher.Userid = (string)reader["userid_teacher"];

                                teachers.Add(teacher);
                            }
                        }
                        catch (SqlException xException)
                        {
                            Console.WriteLine("Error loading teachers from database!");
                        }
                        finally
                        {
                            reader.Close();
                            connection.Close();
                        }
                    }
                    
                }
            }
        }
        public static List<Teacher> GetTeachersFromLocal()
        {
            return teachers;
        }
        public static Teacher? GetTeacherFromLocal(string Userid)
        {
            foreach (Teacher teacher in Administration.GetTeachersFromLocal())
            {
                if (teacher.Userid == Userid)
                {
                    return teacher;
                }
            }
            return null;
        }
    }
}

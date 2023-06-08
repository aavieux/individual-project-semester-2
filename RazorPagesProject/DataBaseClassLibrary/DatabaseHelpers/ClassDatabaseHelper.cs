//using ClassLibrary.Models;
//using ClassLibrary.Models.Enums;
using DataBaseClassLibrary.DTOs;
using DataBaseClassLibrary.DTOs.DTOEnums;
using DataBaseClassLibrary.Interfaces;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseClassLibrary.DatabaseHelpers
{
    public class ClassDatabaseHelper : IClassDbHelper
    {
        private readonly IConfiguration _configuration;
        private readonly string connectionString;
        
        public ClassDatabaseHelper(IConfiguration configuration)
        {
            _configuration = configuration;
            connectionString = _configuration.GetConnectionString("DefaultConnectionString");
        }
        public List<ClassDTO> GetClassesFromDB()
        {
            using (SqlConnection connection =
                   new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM Class";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            try
                            {
                                List<ClassDTO> inClasses = new List<ClassDTO>();
                                while (reader.Read())
                                {

                                    try
                                    {
                                        int userClass = 0;

                                        if (reader["user_class"] != DBNull.Value)
                                        {
                                            userClass = (int)reader["user_class"];
                                        }
                                        ClassDTO _class = new ClassDTO((int)reader["name_class"], userClass);
                                        inClasses.Add(_class);
                                    }
                                    catch (Exception)
                                    {

                                    }

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
        public List<StudentDTO> GetClassStudentsFromDB(int classId)
        {
            using (SqlConnection connection =
                   new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = $"SELECT * FROM [User] WHERE  role_user = 'STUDENT' AND class_user = '{classId}';";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            List<StudentDTO> students = new List<StudentDTO>();
                            while (reader.Read())
                            {
                                StudentDTO student = new StudentDTO(
                                    (string)reader["first_name_user"], 
                                    (string)reader["last_name_user"], 
                                    Enum.Parse<Role>(reader["role_user"].ToString()), 
                                    (int)reader["class_user"], 
                                    (string)reader["email_user"], 
                                    (string)reader["phonenumber_user"], 
                                    (int)reader["id_user"]);

                                students.Add(student);
                            }
                            connection.Close();
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

        public bool CreateClass(ClassDTO classDTO)
        {
            using (SqlConnection connection =
                   new SqlConnection(connectionString))
            {
                connection.Open();
                string query = $"INSERT INTO Class (name_class, user_class) VALUES ('{classDTO.Name}', '{classDTO.TeacherID}');";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        command.ExecuteNonQuery();
                        Console.WriteLine("-----------------------------------");
                        Console.WriteLine("Records Inserted in DB Successfully");
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

    }
}

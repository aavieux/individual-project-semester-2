//using ClassLibrary.Models.Enums;
//using ClassLibrary.Models;
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
    public class UserDatabaseHelper
    {
        internal List<UserDTO> GetAllUsersFromDB()
        {
            using (SqlConnection connection =
                   new SqlConnection("Server=localhost;Database=individual_project_semester2;Trusted_Connection=True;"))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM Users";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            try
                            {
                                List<UserDTO> inUsers = new List<UserDTO>();
                                while (reader.Read())
                                {
                                    UserDTO user;

                                    if (Enum.Parse<Role>(reader["role_user"].ToString()).ToString() == "STUDENT")
                                    {
                                        StudentDTO student = new StudentDTO();

                                        //student.GradeBook = tva se pravi v nachaloto na programata

                                        user = student;
                                    }
                                    else
                                    {
                                        user = new TeacherDTO();
                                    }

                                    user.Firstname = (string)reader["first_name_user"];
                                    user.Lastname = (string)reader["last_name_user"];

                                    user.Role = Enum.Parse<Role>(reader["role_user"].ToString());
                                    try
                                    {
                                        user.Class = (int)reader["class_user"];
                                    }
                                    catch (Exception)
                                    {
                                        user.Class = null;
                                    }
                                    //TODO
                                    user.Email = (string)reader["email_user"];
                                    user.PhoneNumber = (string)reader["phonenumber_user"];
                                    user.Userid = (int)reader["id_user"];



                                    inUsers.Add(user);

                                }
                                return inUsers;
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
                catch
                {
                    Console.WriteLine("Could not open a connection to the database!");
                    return null;
                }

            }
        }
        internal bool UpdateUserToDB(UserDTO user)
        {
            using (SqlConnection connection =
                   new SqlConnection("Server=localhost;Database=individual_project_semester2;Trusted_Connection=True;"))
            {
                try
                {
                    connection.Open();
                    string query = $"UPDATE Users SET first_name_user = '{user.Firstname}', last_name_user = '{user.Lastname}', role_user = '{user.Role}', class_user = '{user.Class.ToString()}', email_user = '{user.Email}', phonenumber_user = '{user.PhoneNumber}' WHERE id_user = '{user.Userid}'";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            try
                            {
                                command.ExecuteNonQuery();
                                Console.WriteLine("-----------------------------------");
                                Console.WriteLine("Records Inserted in DB Successfully");
                                return true;
                            }
                            catch (SqlException xException)
                            {
                                Console.WriteLine("Error updating the database!");
                                return false;
                            }
                            finally
                            {
                                reader.Close();
                                connection.Close();
                            }
                        }
                    }
                }
                catch
                {
                    Console.WriteLine("Could not open a connection to the database!");
                    return false;
                }

            }
        }
        internal bool DeleteUserFromDB(int userId)
        {
            using (SqlConnection connection =
                   new SqlConnection("Server=localhost;Database=individual_project_semester2;Trusted_Connection=True;"))
            {
                try
                {
                    connection.Open();
                    string query = $"DELETE FROM Users WHERE id_user LIKE '{userId}';";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            try
                            {
                                command.ExecuteNonQuery();
                                Console.WriteLine("-----------------------------------");
                                Console.WriteLine("Records Inserted in DB Successfully");
                                return true;
                            }
                            catch (SqlException xException)
                            {
                                Console.WriteLine("Error updating the database!");
                                return false;
                            }
                            finally
                            {
                                reader.Close();
                                connection.Close();
                            }
                        }
                    }
                }
                catch
                {
                    Console.WriteLine("Could not open a connection to the database!");
                    return false;
                }

            }
        }

        internal List<ManagerDTO> GetAllManagersFromDB()
        {
            using (SqlConnection connection =
                  new SqlConnection("Server=localhost;Database=individual_project_semester2;Trusted_Connection=True;"))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM Managers";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            try
                            {
                                List<ManagerDTO> inManagers = new List<ManagerDTO>();
                                while (reader.Read())
                                {
                                    ManagerDTO manager = new ManagerDTO(
                                        (int)reader["id_manager"], 
                                        (string)reader["first_name_manager"], 
                                        (string)reader["last_name_manager"], 
                                        (string)reader["email_manager"], 
                                        (string)reader["password_manager"]);

                                    inManagers.Add(manager);

                                }
                                return inManagers;
                            }
                            catch (SqlException xException)
                            {
                                Console.WriteLine("Error loading managers from database!");
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
                catch
                {
                    Console.WriteLine("Could not open a connection to the database!");
                    return null;
                }

            }
        }
    }
}

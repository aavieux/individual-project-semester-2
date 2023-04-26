//using ClassLibrary.Models.Enums;
//using ClassLibrary.Models;
using DataBaseClassLibrary.DTOs;
using DataBaseClassLibrary.DTOs.DTOEnums;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseClassLibrary.DatabaseHelpers
{
    public class UserDatabaseHelper
    {
        public List<UserDTO> GetAllUsersFromDB()
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
                                    if (Enum.Parse<Role>(reader["role_user"].ToString()).ToString() == "STUDENT")
                                    {
                                        StudentDTO user = new StudentDTO(
                                            (string)reader["first_name_user"],
                                            (string)reader["last_name_user"],
                                            Enum.Parse<Role>(reader["role_user"].ToString()),
                                            (int)reader["class_user"],
                                            (string)reader["email_user"],
                                            (string)reader["phonenumber_user"],
                                            (int)reader["id_user"]
                                            );
                                        inUsers.Add(user);
                                    }
                                    else
                                    {
                                        TeacherDTO user = new TeacherDTO(
                                            (string)reader["first_name_user"],
                                            (string)reader["last_name_user"],
                                            Enum.Parse<Role>(reader["role_user"].ToString()),
                                            (int)reader["class_user"],
                                            (string)reader["email_user"],
                                            (string)reader["phonenumber_user"],
                                            (int)reader["id_user"]
                                            );
                                        inUsers.Add(user);
                                    }
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
        public int AddUserToDB(UserDTO userDTO)
        {
            using (SqlConnection connection =
                   new SqlConnection("Server=localhost;Database=individual_project_semester2;Trusted_Connection=True;"))
            {
                connection.Open();
                string query = $"INSERT INTO Users (first_name_user, last_name_user, role_user, class_user, email_user, phonenumber_user) VALUES ('{userDTO.Firstname}', '{userDTO.Lastname}', '{userDTO.Role}', '{userDTO.Class}', '{userDTO.Email}', '{userDTO.PhoneNumber}'); SELECT SCOPE_IDENTITY() as new_id;";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        //command.ExecuteNonQuery();
                        int newId = Convert.ToInt32(command.ExecuteScalar());
                        Console.WriteLine("-----------------------------------");
                        Console.WriteLine("Records Inserted in DB Successfully");
                        return newId;
                    }
                    catch (SqlException e)
                    {
                        Console.WriteLine("Error Generated. Details: " + e.ToString());
                        return 0;
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }
        public bool UpdateUserToDB(UserDTO user)
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
        public bool DeleteUserFromDB(int userId)
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
                                Console.WriteLine("-----------------------------------");
                                Console.WriteLine("Deleted user from DB Successfully");
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
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    Console.WriteLine("Could not open a connection to the database!");
                    return false;
                }

            }
        }

        public List<ManagerDTO> GetAllManagersFromDB()
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

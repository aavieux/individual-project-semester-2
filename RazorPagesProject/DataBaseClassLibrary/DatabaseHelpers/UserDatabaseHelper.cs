using ClassLibrary.Models.Enums;
using ClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.DatabaseHelpers
{
    public class UserDatabaseHelper
    {
        internal List<User> GetAllUsersFromDB()
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
                                List<User> inUsers = new List<User>();
                                while (reader.Read())
                                {
                                    User user;

                                    if (Enum.Parse<Role>(reader["role_user"].ToString()).ToString() == "STUDENT")
                                    {
                                        Student student = new Student();

                                        //student.GradeBook = tva se pravi v nachaloto na programata

                                        user = student;
                                    }
                                    else
                                    {
                                        user = new Teacher();
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
        internal bool UpdateUserToDB(User user)
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

        internal List<Manager> GetAllManagersFromDB()
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
                                List<Manager> inManagers = new List<Manager>();
                                while (reader.Read())
                                {
                                    Manager manager = new Manager(
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

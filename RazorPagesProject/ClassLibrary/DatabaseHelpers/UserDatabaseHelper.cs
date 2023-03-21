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
        internal List<User> GetUsersFromDB()
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


    }
}

using ClassLibrary.Models;
using ClassLibrary.Models.Enums;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassLibrary.DatabaseHelpers
{
    public class FeedbackDatabaseHelper
    {
        public List<Feedback> GetAllFeedbacksFromDB()
        { 
            using (SqlConnection connection =
                  new SqlConnection("Server=localhost;Database=individual_project_semester2;Trusted_Connection=True;"))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM Contact";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            try
                            {
                                List<Feedback> feedbacks = new List<Feedback>();
                                while (reader.Read())
                                {
                                    Feedback feedback = new Feedback((int)reader["id_ticket"], 
                                        (string)reader["first_name_contact"], 
                                        (string)reader["last_name_contact"],
                                        (string)reader["school_contact"], 
                                        (string)reader["email_contact"], 
                                        (string)reader["subject_contact"]);

                                    feedbacks.Add(feedback);
                                }
                                
                                return feedbacks;
                            }
                            catch (SqlException xException)
                            {
                                Console.WriteLine("Error loading feedbacks from database!");
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
        public void AddFeedbackToDB(Feedback feedback)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection("Server=localhost;Database=individual_project_semester2;Trusted_Connection=True;"))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand($"INSERT INTO Contact (first_name_contact, last_name_contact, school_contact, email_contact, subject_contact) VALUES ('{feedback.FirstNameContact}','{feedback.LastNameContact}','{feedback.SchoolContact}','{feedback.EmailContact}','{feedback.SubjectContact}')", connection);
                    command.ExecuteNonQuery();
                    connection.Close();
                    Console.WriteLine("Successfully updated the database!");


                }
            }
            catch (Exception)
            {
                Console.WriteLine("Error updating the database!");
            }
        }
        public void DeleteFeedbackFromDB(int feedbackId)
        {
            //todo
        }
    }
}

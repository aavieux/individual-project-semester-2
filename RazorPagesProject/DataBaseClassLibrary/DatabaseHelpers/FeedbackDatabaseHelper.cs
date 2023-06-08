//using ClassLibrary.Models;
//using ClassLibrary.Models.Enums;
using DataBaseClassLibrary.DTOs;
using DataBaseClassLibrary.DTOs.DTOEnums;
using DataBaseClassLibrary.Interfaces;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataBaseClassLibrary.DatabaseHelpers
{
    public class FeedbackDatabaseHelper : IFeedbackDbHelper
    {
        private readonly IConfiguration _configuration;
        private readonly string connectionString;

        public FeedbackDatabaseHelper(IConfiguration configuration)
        {
            _configuration = configuration;
            connectionString = _configuration.GetConnectionString("DefaultConnectionString");
        }
        public List<FeedbackDTO> GetAllFeedbacksFromDB()
        { 
            using (SqlConnection connection =
                  new SqlConnection(connectionString))
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
                                List<FeedbackDTO> feedbacks = new List<FeedbackDTO>();
                                while (reader.Read())
                                {
                                    FeedbackDTO feedback = new FeedbackDTO((int)reader["id_ticket"], 
                                        (string)reader["first_name_contact"], 
                                        (string)reader["last_name_contact"],
                                        (string)reader["school_contact"], 
                                        (string)reader["email_contact"], 
                                        (string)reader["subject_contact"],
                                        Enum.Parse<Status>((string)reader["status_contact"]));

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
        public FeedbackDTO GetFeedbackByIdFromDB(int feedbackId)
        {
            foreach (FeedbackDTO feedback in GetAllFeedbacksFromDB())
            {
                if (feedback.IdTicket == feedbackId)
                {
                    return feedback;
                }
            }
            return null;
        }
        public bool AddFeedbackToDB(FeedbackDTO feedbackDTO)
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand($"INSERT INTO Contact (first_name_contact, last_name_contact, school_contact, email_contact, subject_contact, status_contact) VALUES ('{feedbackDTO.FirstNameContact}','{feedbackDTO.LastNameContact}','{feedbackDTO.SchoolContact}','{feedbackDTO.EmailContact}','{feedbackDTO.SubjectContact}','{feedbackDTO.StatusContact.ToString()}')", connection);
                    command.ExecuteNonQuery();
                    Console.WriteLine("Successfully updated the database!");
                    return true;

                }
                catch (Exception)
                {
                    Console.WriteLine("Error updating the database!");
                    return false;
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        public bool UpdateFeedbackToDB(FeedbackDTO feedbackDTO)
        {
            
            using (SqlConnection connection =
                    new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = $"UPDATE Contact SET first_name_contact = '{feedbackDTO.FirstNameContact}', last_name_contact = '{feedbackDTO.LastNameContact}', school_contact = '{feedbackDTO.SchoolContact}', email_contact = '{feedbackDTO.EmailContact}', subject_contact = '{feedbackDTO.SubjectContact}', status_contact = '{feedbackDTO.StatusContact.ToString()}' WHERE id_ticket = '{feedbackDTO.IdTicket}'";

                    using (SqlCommand command = new SqlCommand(query, connection))
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
                            connection.Close();
                        }
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Could not open a connection to the database!");
                    return false;
                }

            
            }
        }
        public void DeleteFeedbackFromDB(int feedbackId)
        {
            //todo
        }
    }
}

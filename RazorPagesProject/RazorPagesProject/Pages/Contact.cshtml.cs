using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;

namespace RazorPagesProject.Pages
{
    public class ContactModel : PageModel
    {
        public void OnPost()
        {
            // Retrieve the data from the form
            string firstname = Request.Form["firstname"];
            string lastname = Request.Form["lastname"];
            string school = Request.Form["school_select"];
            string email = Request.Form["email"];
            string subject = Request.Form["subject"];

            // Save the data to the database
            try
            {
                using (SqlConnection connection = new SqlConnection("Server=localhost;Database=individual_project_semester2;Trusted_Connection=True;"))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand($"INSERT INTO Contact (first_name_contact, last_name_contact, school_contact, email_contact, subject_contact) VALUES ('{firstname}','{lastname}','{school}','{email}','{subject}')", connection);
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
    }
}

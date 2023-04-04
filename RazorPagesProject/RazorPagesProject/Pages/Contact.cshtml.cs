using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;
using System.ComponentModel.DataAnnotations;
using ClassLibrary.Controllers;
using ClassLibrary.Models;
using ClassLibrary.Models.Enums;

namespace RazorPagesProject.Pages
{
    public class ContactModel : PageModel
    {
        private FeedbackManager feedbackManager { get; set; }
        public ContactModel() 
        { 
            feedbackManager = new FeedbackManager();
        }
        //bool messageBox = false;
        [BindProperty]
        [Required(ErrorMessage = "Please enter your first name.")]
        public string firstname { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "Please enter your last name.")]
        public string lastname { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "Please enter your school name.")]
        public string school_select { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "Please enter your email adress.")]
        public string email { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "Please enter a subject.")]
        public string subject { get; set; }

        public void OnPost()
        {
            if (ModelState.IsValid)
            {
                try
                {
                    Feedback feedback = new Feedback(firstname,lastname,school_select,email,subject, Status.OPEN);
                    feedbackManager.AddFeedback(feedback);
                    DisplayMessage();
                }
                catch (Exception)
                {
                    Console.WriteLine("Error updating the database!");
                }
            }
        }
        public void DisplayMessage()
        {
            TempData["SuccessMessage"] = "Successfully sent the feedback! Thank you!";
            Redirect("/Contact");
        }
    }
}

using ClassLibrary.DatabaseHelpers;
using ClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Controllers
{
    public class FeedbackManager
    {
        FeedbackDatabaseHelper databaseHelper;
        public FeedbackManager() 
        { 
            databaseHelper = new FeedbackDatabaseHelper();
        }
        public List<Feedback> GetAllFeedbacks()
        {
            return databaseHelper.GetAllFeedbacksFromDB();
        }
        public Feedback GetFeedbackById(int feedbackId) 
        {
            var result = databaseHelper.GetFeedbackByIdFromDB(feedbackId);
            if (result != null)
            {
                return result;
            }
            return null;
        }
        public void AddFeedback(Feedback feedback)
        {
            databaseHelper.AddFeedbackToDB(feedback);
        }
        public bool UpdateFeedback(Feedback feedback)
        {
            if (databaseHelper.UpdateFeedbackToDB(feedback))
            {
                return true;
            }
            return false;
        }
        public void DeleteFeedback(Feedback feedback)
        {
            databaseHelper.DeleteFeedbackFromDB(feedback.IdTicket);
        }
    }
}

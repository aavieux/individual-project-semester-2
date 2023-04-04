
using ClassLibrary.Mapper;
using ClassLibrary.Models;
using DataBaseClassLibrary.DatabaseHelpers;
using DataBaseClassLibrary.DTOs;
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
        FeedbackMapper mapper;
        public FeedbackManager() 
        {
            databaseHelper = new FeedbackDatabaseHelper();
        }
        public List<Feedback> GetAllFeedbacks()
        {
            List<Feedback> feedbacks = new List<Feedback>();
            foreach (FeedbackDTO feedbackDTO in databaseHelper.GetAllFeedbacksFromDB())
            {
                feedbacks.Add(mapper.MapFeedbackDTOtoFeedback(feedbackDTO));
            }
            return feedbacks;
        }
        public Feedback GetFeedbackById(int feedbackId)
        {
            var result = databaseHelper.GetFeedbackByIdFromDB(feedbackId);
            if (result != null)
            {
                return mapper.MapFeedbackDTOtoFeedback(result);
            }
            return null;
        }
        public void AddFeedback(Feedback feedback)
        {
            databaseHelper.AddFeedbackToDB(mapper.MapFeedbackToFeedbackDTO(feedback));
        }
        public bool UpdateFeedback(Feedback feedback)
        {
            if (databaseHelper.UpdateFeedbackToDB(mapper.MapFeedbackToFeedbackDTO(feedback)))
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

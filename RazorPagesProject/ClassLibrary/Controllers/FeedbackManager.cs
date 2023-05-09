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
        private FeedbackDatabaseHelper feedbackDbHelper;
        private FeedbackMapper feedbackMapper;

        public FeedbackManager(FeedbackDatabaseHelper feedbackDbHelper)
        {
            this.feedbackDbHelper = feedbackDbHelper;
            this.feedbackMapper = new FeedbackMapper(feedbackDbHelper);
        }
        public List<Feedback> GetAllFeedbacks()
        {
            List<Feedback> feedbacks = new List<Feedback>();
            foreach (FeedbackDTO feedbackDTO in feedbackDbHelper.GetAllFeedbacksFromDB())
            {
                feedbacks.Add(feedbackMapper.MapFeedbackDTOtoFeedback(feedbackDTO));
            }
            return feedbacks;
        }
        public Feedback GetFeedbackById(int feedbackId)
        {
            var result = feedbackDbHelper.GetFeedbackByIdFromDB(feedbackId);
            if (result != null)
            {
                return feedbackMapper.MapFeedbackDTOtoFeedback(result);
            }
            return null;
        }
    }
}

using DataBaseClassLibrary.DTOs;
using DataBaseClassLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.FakeDatabaseHelpers
{
    public class FakeFeedbackDatabaseHelper : IFeedbackDbHelper
    {
        List<FeedbackDTO> feedbacks = new List<FeedbackDTO>();
        public List<FeedbackDTO> GetAllFeedbacksFromDB()
        {
            return feedbacks;
        }
        
        public FeedbackDTO GetFeedbackByIdFromDB(int feedbackId)
        {
            FeedbackDTO feedback = new FeedbackDTO(1, "alex", "garkov", "Fontys", "aleksandargarkov0@gmail.com", "Subject", DataBaseClassLibrary.DTOs.DTOEnums.Status.CLOSED);
            return feedback;
        }
        
        public bool AddFeedbackToDB(FeedbackDTO feedbackDTO)
        {
            return true;
        }
        
        public bool UpdateFeedbackToDB(FeedbackDTO feedbackDTO)
        {
            return true;
        }
        
        public void DeleteFeedbackFromDB(int feedbackId)
        {
            //todo
        }
    }
}

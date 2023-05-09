using DataBaseClassLibrary.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseClassLibrary.Interfaces
{
    public interface IFeedbackDbHelper
    {
        public List<FeedbackDTO> GetAllFeedbacksFromDB();

        public FeedbackDTO GetFeedbackByIdFromDB(int feedbackId);

        public bool AddFeedbackToDB(FeedbackDTO feedbackDTO);

        public bool UpdateFeedbackToDB(FeedbackDTO feedbackDTO);

        public void DeleteFeedbackFromDB(int feedbackId);

    }
}

using ClassLibrary.Models;
using ClassLibrary.Models.Enums;
using DataBaseClassLibrary.DatabaseHelpers;
using DataBaseClassLibrary.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Mapper
{
    public class FeedbackMapper
    {
        private FeedbackDatabaseHelper feedbackDatabaseHelper;
        public FeedbackMapper(FeedbackDatabaseHelper feedbackDbHelper) { this.feedbackDatabaseHelper = feedbackDbHelper; }
        public Feedback MapFeedbackDTOtoFeedback(FeedbackDTO feedbackDTO)
        {
            Feedback feedback = new Feedback(feedbackDatabaseHelper,feedbackDTO.IdTicket, feedbackDTO.FirstNameContact, feedbackDTO.LastNameContact,feedbackDTO.SchoolContact,feedbackDTO.EmailContact, feedbackDTO.SubjectContact,Enum.Parse<Status>(feedbackDTO.StatusContact.ToString()));
            return feedback;
        }
        public FeedbackDTO MapFeedbackToFeedbackDTO(Feedback feedback)
        {
            FeedbackDTO feedbackDTO = new FeedbackDTO(feedback.IdTicket,feedback.FirstNameContact, feedback.LastNameContact, feedback.SchoolContact, feedback.EmailContact, feedback.SubjectContact, Enum.Parse<DataBaseClassLibrary.DTOs.DTOEnums.Status>(feedback.StatusContact.ToString()));
            return feedbackDTO;
        }
    }
}
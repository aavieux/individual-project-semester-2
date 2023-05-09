using ClassLibrary.Mapper;
using ClassLibrary.Models.Enums;
using DataBaseClassLibrary.DatabaseHelpers;
using DataBaseClassLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Models
{
    public  class Feedback
    {
        private IFeedbackDbHelper feedbackDbHelper;
        private FeedbackMapper feedbackMapper;

        private int id_ticket;
        private string first_name_contact;
        private string last_name_contact;
        private string school_contact;
        private string email_contact;
        private string subject_contact;
        private Status status_contact;

        public int IdTicket {get { return this.id_ticket;}}
        public string FirstNameContact { get { return this.first_name_contact; } }
        public string LastNameContact { get { return this.last_name_contact; } }
        public string SchoolContact { get { return this.school_contact; } }
        public string EmailContact { get { return this.email_contact; } }
        public string SubjectContact { get { return this.subject_contact; } }
        public Status StatusContact { get { return this.status_contact; } }


        public Feedback(IFeedbackDbHelper databaseHelper, string first_name_contact,string last_name_contact,string school_contact,string email_contact,string subject_contact, Status status_contact)
        {
            //to create
            this.feedbackDbHelper = databaseHelper;
            feedbackMapper = new FeedbackMapper(feedbackDbHelper);
            

            this.first_name_contact = first_name_contact;
            this.last_name_contact =last_name_contact;
            this.school_contact = school_contact;
            this.email_contact = email_contact;
            this.subject_contact = subject_contact;
            this.status_contact = status_contact;
        }
        public Feedback(IFeedbackDbHelper databaseHelper, int id_ticket,string first_name_contact, string last_name_contact, string school_contact, string email_contact, string subject_contact, Status status_contact)
        {
            //to load
            
            this.feedbackDbHelper = databaseHelper;
            feedbackMapper = new FeedbackMapper(feedbackDbHelper);
            this.id_ticket = id_ticket;
            this.first_name_contact = first_name_contact;
            this.last_name_contact = last_name_contact;
            this.school_contact = school_contact;
            this.email_contact = email_contact;
            this.subject_contact = subject_contact;
            this.status_contact = status_contact;
        }
        public bool Create()
        {
            Feedback currentFeedback = new Feedback(feedbackDbHelper,this.first_name_contact, this.last_name_contact, this.school_contact, this.email_contact, this.subject_contact, this.status_contact);
            if (feedbackDbHelper.AddFeedbackToDB(feedbackMapper.MapFeedbackToFeedbackDTO(currentFeedback)))
            {
                return true;
            }
            return false;
            
        }
        public bool Update()
        {
            Feedback currentFeedback = new Feedback(feedbackDbHelper, this.id_ticket, this.first_name_contact, this.last_name_contact, this.school_contact, this.email_contact, this.subject_contact, this.status_contact);
            if (feedbackDbHelper.UpdateFeedbackToDB(feedbackMapper.MapFeedbackToFeedbackDTO(currentFeedback)))
            {
                return true;
            }
            return false;
        }
        public void Delete(Feedback feedback)
        {
            feedbackDbHelper.DeleteFeedbackFromDB(feedback.IdTicket);
        }
    }
}

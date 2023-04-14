using DataBaseClassLibrary.DTOs.DTOEnums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseClassLibrary.DTOs
{
    public class FeedbackDTO
    {
        private readonly int _idTicket;
        private readonly string _firstNameContact;
        private readonly string _lastNameContact;
        private readonly string _schoolContact;
        private readonly string _emailContact;
        private readonly string _subjectContact;
        private readonly Status _statusContact;

        public int IdTicket { get { return _idTicket; } }
        public string FirstNameContact { get { return _firstNameContact; } }
        public string LastNameContact { get { return _lastNameContact; } }
        public string SchoolContact { get { return _schoolContact; } }
        public string EmailContact { get { return _emailContact; } }
        public string SubjectContact { get { return _subjectContact; } }
        public Status StatusContact { get { return _statusContact; } }

        public FeedbackDTO(int idTicket, string firstNameContact, string lastNameContact, string schoolContact, string emailContact, string subjectContact, Status statusContact)
        {
            //to load
            _idTicket = idTicket;
            _firstNameContact = firstNameContact;
            _lastNameContact = lastNameContact;
            _schoolContact = schoolContact;
            _emailContact = emailContact;
            _subjectContact = subjectContact;
            _statusContact = statusContact;
        }
        public FeedbackDTO(string firstNameContact, string lastNameContact, string schoolContact, string emailContact, string subjectContact, Status statusContact)
        {
            // to write
            _firstNameContact = firstNameContact;
            _lastNameContact = lastNameContact;
            _schoolContact = schoolContact;
            _emailContact = emailContact;
            _subjectContact = subjectContact;
            _statusContact = statusContact;
        }

    }
}

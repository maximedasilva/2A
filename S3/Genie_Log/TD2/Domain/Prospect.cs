using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Prospect
    {
       public string email { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public DateTime lastContact { get; set; }
        public string notes { get; set; }
      public  Prospect()
        {
        }
        public Prospect(string _lastName,string _firstname,string _email,DateTime _lastContact)
        {
            lastName = _lastName;
            firstName = _firstname;
            email = _email;
            lastContact = _lastContact;
            notes = "";
        }

       public  Prospect(string _lastName, string _firstname, string _email, DateTime _lastContact,string _notes)
            :this(_lastName,_firstname,_email,_lastContact)
        {
            notes = _notes;
        }
        public override string ToString()
        {
            return (lastName + " " + firstName);
        }
    }
}

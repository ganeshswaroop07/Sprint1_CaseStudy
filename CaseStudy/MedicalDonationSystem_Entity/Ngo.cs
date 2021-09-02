using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalDonationSystem_Entity
{
    class NGO
    {
        double contact_no;
        int medicine_code;
        string org_name;
        string mail_id;
        string location;
        string feedback;
        int ngo_id;

        public double Contact_no { get => contact_no; set => contact_no = value; }
        public int Medicine_code { get => medicine_code; set => medicine_code = value; }
        public string Org_name { get => org_name; set => org_name = value; }
        public string Mail_id { get => mail_id; set => mail_id = value; }
        public string Location { get => location; set => location = value; }
        public string Feedback { get => feedback; set => feedback = value; }
        public int Ngo_id { get => ngo_id; set => ngo_id = value; }
    }
}

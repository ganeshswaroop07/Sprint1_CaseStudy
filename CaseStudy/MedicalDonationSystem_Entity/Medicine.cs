using System;

namespace MedicalDonationSystem_Entity
{
    public class Medicine
    {
        int medicine_code;
        bool availability;
        int quantity;
        DateTime exp_date;

        public int Medicine_code { get; set; }
        public bool Availability { get; set; }
        public int Quantity { get; set; }
        public DateTime Exp_date { get; set; }
    }
}

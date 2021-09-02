using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalDonationSystem_Entity
{
    class Shipping
    {
        int ship_id;
        DateTime date_arrival;

        public DateTime Date_arrival { get => date_arrival; set => date_arrival = value; }
        public int Ship_id { get => ship_id; set => ship_id = value; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONChallenge
{
    public class Event : ObjectForJson
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string EventTitle { get; set; }
        public int EventCapacity { get; set; }
        public decimal PriceOfAdmission { get; set; }
    }
}

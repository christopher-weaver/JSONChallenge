using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONChallenge
{
    public class Badge : ObjectForJson
    {
        public int BadgeID { get; set; }
        public List<string> ListOfDoors { get; set; } = new List<string>();
        public bool HasSecurityClearance { get; set; }
        public string EmployeeId { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}

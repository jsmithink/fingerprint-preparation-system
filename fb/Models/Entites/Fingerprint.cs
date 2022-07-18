using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fb.Models.Entites
{
    public class Fingerprint
    {
        public int Id { get; set; }
        public string Period_Name { get; set; }
        public int Time_Departure { get; set; }
        public int Start_Time { get; set; }
        public int Letting_Time { get; set; }
        public int Closure_Time { get; set; }
        public int Time_Required { get; set; }
        public int Fingerprint_date { get; set; }
        public int EmployeeId { get; set; }
        public int FingerprintDevicesId { get; set; }
        public Employee Employee { get; set; }
        public FingerprintDevices FingerprintDevices { get; set; }
    }
}

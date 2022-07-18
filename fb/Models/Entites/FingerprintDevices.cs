using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fb.Models.Entites
{
    public class FingerprintDevices
    {
        public int Id { get; set; }
        public string Network_Address { get; set; }
        public string Site_Device { get; set; }
       
        public string Contact_Type { get; set; }
        public int Speed { get; set; }
        public string Serial_Port { get; set; }
        public DateTime Collection_start_Data_date { get; set; }
        public DateTime Last_WithdrawalData_date { get; set; }
        public string Safety_Number { get; set; }
        public string Website { get; set; }
        public bool Internet_Connection { get; set; }
        public string Manufacturer_Number { get; set; }
        public string Device_Name { get; set; }
        public int Device_Number { get; set; }
        public ICollection<Fingerprint> Fingerprints { get; set; }
    }
}

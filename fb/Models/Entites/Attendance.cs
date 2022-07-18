using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fb.Models.Entites
{
    public class Attendance
    {
        public int Id { get; set; }
        public string Name_Period { get; set; }
        public bool D1 { get; set; }
        public bool D2 { get; set; }
        public bool D3 { get; set; }
        public bool D4 { get; set; }
        public bool D5 { get; set; }
        public bool D6 { get; set; }
        public bool D7 { get; set; }
        public DateTime Time_Departure { get; set; }
        public int Start_Time { get; set; }
        public int Letting_Time { get; set; }
        public int Closure_Time { get; set; }
        public int Time_Required { get; set; }
        public bool Customize { get; set; }
        public int ShiftId { get; set; }
        public Shift Shift { get; set; }
        // public ICollection<Holidays> Holiday { get; set; }
        public ICollection<OfficialHolidays> OfficialHolidays { get; set; }
       
    }
}

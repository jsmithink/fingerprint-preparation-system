using Azure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fb.Models.Entites
{
    public class Holidays
    {
        public int ID { get; set; }
        public string CauseOfHol { get; set; }
        public int LiabilitiesOfBalance { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public DateTime added { get; set; }
        public int AdministrativeNumber { get; set; }
        public int Duration { get; set; }
        public int TypeHolidayId { get; set; }
        public TypeHoliday TypeHoliday { get; set; }

        // public int EmployeeId { get; set; }
        // public int AttendanceId { get; set; }
        // public Employee Employee { get; set; }
        // public Attendance Attendance { get; set; }


        // public ICollection<HolidayRequist> HolidayRequists { get; set; }

        //public int GetDuration()
        //{
        //    Duration = (ToDate.Date - FromDate.Date).Days + 1;
        //    return Duration;
        //}
        public int GetToDate()
        {
            ToDate = FromDate.AddDays(Duration);
            return 0;
        }
        public int GetLiabilitiesOfBalance()
        {
            if (TypeHoliday.HoliName == "ولادة طبيعية")
                LiabilitiesOfBalance = 60;
            if (TypeHoliday.HoliName == "ولادة قيصرية")
                LiabilitiesOfBalance = 75;
            if (TypeHoliday.HoliName == "")
                LiabilitiesOfBalance = 30;
            if (TypeHoliday.HoliName == "")
                LiabilitiesOfBalance = 3;
            return 0;

        }


    }
}

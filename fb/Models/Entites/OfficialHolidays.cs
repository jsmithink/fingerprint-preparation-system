using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fb.Models.Entites
{
    public class OfficialHolidays
    {
      
        public int Id { get; set; }
        public string NameOfHol { get; set; }
        public string Symbol { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public bool Isfixed { get; set; }
        public int AttendanceId { get; set; }
        public Attendance Attendance { get; set; }

        public bool IsHoliday()
        {
            if (Isfixed == true)
            {
                string CurrentDate = DateTime.Now.ToString("dd-MM-yyyy");
                if (CurrentDate == FromDate.ToString("dd-MM-yyyy"))

                {
                    return true;

                }
                else
                {
                    return false;
                }
            }
           else { return false; }
          
        }

    }
}

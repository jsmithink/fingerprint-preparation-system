using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fb.Models.Entites
{
    public class HolidayRequist
    {
        public int Id { get; set; }
        public int AdminsterId { get; set; }
        public string NameEmp { get; set; }
        public DateTime Date { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public string Job { get; set; }
        public string Management { get; set; }
        public bool TypeHoliday { get; set; }

        public int EmpNumber { get; set; }
        public string DurationHoliday { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public int HolidaysID { get; set; }
       // public Holidays Holidays { get; set; }
    }
}
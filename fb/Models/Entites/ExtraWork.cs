using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fb.Models.Entites
{
    public class ExtraWork
    {
        public int Id { get; set; }
       
        public string NameEmp { get; set; }
       
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public DateTime FromTime { get; set; }
        public DateTime ToTime { get; set; }

        public string WorksRequired { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
       
    }
}
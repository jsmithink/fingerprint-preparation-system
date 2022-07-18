using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace fb.Models.Entites
{
    public class OfficialHolidaysDynamic
    {
        public int Id { get; set; }
        [Required]
        public string NameOfHol { get; set; }
        [Required]
        public string Symbol { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy", ApplyFormatInEditMode = true)]
        public DateTime FromDate { get; set; }
        [DataType(DataType.Date)]
        [Required]
        public DateTime ToDate { get; set; }
        public int AttendanceId { get; set; }
        public Attendance Attendance { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fb.Models.Entites
{
    public class Balance
    {
        public int Id { get; set; }
        public int Balances { get; set; }
        public int Year { get; set; }
        public Employee Employee { get; set; }

       

       
       // public TypeHoliday TypeHoliday { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fb.Models.Entites
{
    public class Discount
    {
        public int ID { get; set; }
        public int Month { get; set; }
        public int Discounted { get; set; }
        public int Total_Discount { get; set; }
       public Employee Employee { get; set; }
    }
}

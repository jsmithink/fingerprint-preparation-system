using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace fb.Models.Entites
{
    public class TypeExemption
    {
        public int Id { get; set; }
        public string TypeOfExemption { get; set; }
        public string Symbol { get; set; }
       
        public ICollection<Exemption> Exemptions { get; set; }
    }
  
}

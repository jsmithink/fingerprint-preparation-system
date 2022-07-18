using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace fb.Models.Entites
{
    public class Exemption
    {
        [Display]
        public int Id { get; set; }
        public string Notes { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public int AdministrativeNumber { get; set; }
        public DateTime From_Time { get; set; }
        public DateTime To_Time { get; set; }
        public DateTime Added { get; set; }
       
        public int TypeExemptionId { get; set; }
        public TypeExemption TypeExemption { get; set; }
        public ICollection<Employee> Employees { get; set; }

    }
}

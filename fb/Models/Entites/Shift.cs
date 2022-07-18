using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fb.Models.Entites
{
    public class Shift
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Attendance> Attendances { get; set; }
        
        public ICollection<Employee> Employees { get; set; }
    }
}

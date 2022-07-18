using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fb.Models.Entites
{
    public class UserRoles
    {
        public int ID { get; set; }
       
        public bool View { get; set; }
        public bool Insert { get; set; }
        public bool Print { get; set; }
        public bool Edit { get; set; }
        public bool Delete { get; set; }
        public int EmployeeId { get; set; }
        public int RolesId { get; set; }
        public Employee Employee { get; set; }
        public Roles Roles { get; set; }
    }
}

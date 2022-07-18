using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fb.Models.Entites
{
    public class Roles
    {
        public int Id { get; set; }
        public string Screen_Name { get; set; }
        public ICollection<UserRoles> UserRole { get; set; }
    }
}

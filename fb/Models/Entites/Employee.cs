using fb.Models.Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace fb.Models.Entites
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public bool DEL_MARK { get; set; }

      [ DataType(DataType.Date)]
        public int DateAdded { get; set; }
        public int DateOfDeletion { get; set; }
        public int ShiftId { get; set; }

        public Shift Shift { get; set; }
        public int BalanceId { get; set; }

        public Balance Balance { get; set; }
        public int DiscountId { get; set; }
        public Discount Discount { get; set; }
        public ICollection<Holidays> Holiday { get; set; }
       
        public ICollection<Fingerprint> Fingerprints { get; set; }
        public ICollection<HolidayRequist> HolidayRequists { get; set; }
        //public ICollection<JobAssignment> JobAssignment { get; set; }
        public ICollection<ExtraWork> ExtraWorks { get; set; }
        public ICollection<UserRoles> UserRole { get; set; }
        //modelBuilder.Entity<Employee>()
        //      .HasOne(s => s.Balance)
        //      .WithOne(s =>s.Employee)
        //      .HasForeignKey(s => s.BalanceId)
        //public int ExemptionId { get; set; }

        //public Exemption Exemption { get; set; }
        //ModelBuilder.Entity<Employee>()
        //                .HasMany(s => s.HolidayRequist)
        //                .WithOne(s => s.Employee)
        //                .HasForeignKey(s=>s.EmployeeId);
        public Hr_Employee Hr_Employee { get; set; }

    }
}

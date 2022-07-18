using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using fb.Models.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
namespace fb.Models.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }
        public DbSet<Employee> Employees { get; set; }
        /*  protected override void OnModelCreating(ModelBuilder modelBuilder)
          {
              modelBuilder.Entity<Employee>()
                          .HasKey(s => s.Id);
          }
        */
        public DbSet<Attendance> Attendances { get; set; }
      
        public DbSet<Balance> Balances { get; set; }
        public DbSet<Exemption> Exemptions { get; set; }
        //public DbSet<Fingerprint> Fingerprints { get; set; }
        public DbSet<FingerprintDevices> FingerprintDevices { get; set; }
        public DbSet<Holidays> Holidays { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<OfficialHolidays> OfficialHolidays { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<Shift> Shifts { get; set; }
        public DbSet<TypeExemption> TypeExemptions { get; set; }
        public DbSet<TypeHoliday> TypeHolidays { get; set; }
        public DbSet<UserRoles> UserRoles { get; set; }
        public DbSet<OfficialHolidaysDynamic> OfficialHolidaysDynamics { get; set; }
        public DbSet<HolidayRequist> HolidayRequists { get; set; }
        public DbSet<JobAssignment> JobAssignments { get; set; }
        public DbSet<ExtraWork> ExtraWorks { get; set; }
        public DbSet<Hr_Employee> Hr_Employees { get; set; }
        public object Employee { get; internal set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        { }

    }

    }

﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using fb.Models.Data;

namespace Fingerprin.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220421091446_CreateHr_Emp")]
    partial class CreateHr_Emp
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.0-preview.2.20120.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Fingerprin.Models.Entites.Hr_Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Administration")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Branch")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<string>("Job")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Job_Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameEmp")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId")
                        .IsUnique();

                    b.ToTable("Hr_Employees");
                });

            modelBuilder.Entity("fb.Models.Entites.Attendance", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Closure_Time")
                        .HasColumnType("int");

                    b.Property<bool>("Customize")
                        .HasColumnType("bit");

                    b.Property<bool>("D1")
                        .HasColumnType("bit");

                    b.Property<bool>("D2")
                        .HasColumnType("bit");

                    b.Property<bool>("D3")
                        .HasColumnType("bit");

                    b.Property<bool>("D4")
                        .HasColumnType("bit");

                    b.Property<bool>("D5")
                        .HasColumnType("bit");

                    b.Property<bool>("D6")
                        .HasColumnType("bit");

                    b.Property<bool>("D7")
                        .HasColumnType("bit");

                    b.Property<int>("Letting_Time")
                        .HasColumnType("int");

                    b.Property<string>("Name_Period")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ShiftId")
                        .HasColumnType("int");

                    b.Property<int>("Start_Time")
                        .HasColumnType("int");

                    b.Property<DateTime>("Time_Departure")
                        .HasColumnType("datetime2");

                    b.Property<int>("Time_Required")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ShiftId");

                    b.ToTable("Attendances");
                });

            modelBuilder.Entity("fb.Models.Entites.Balance", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Balances")
                        .HasColumnType("int");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Balances");
                });

            modelBuilder.Entity("fb.Models.Entites.Discount", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Discounted")
                        .HasColumnType("int");

                    b.Property<int>("Month")
                        .HasColumnType("int");

                    b.Property<int>("Total_Discount")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Discounts");
                });

            modelBuilder.Entity("fb.Models.Entites.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BalanceId")
                        .HasColumnType("int");

                    b.Property<bool>("DEL_MARK")
                        .HasColumnType("bit");

                    b.Property<int>("DateAdded")
                        .HasColumnType("int");

                    b.Property<int>("DateOfDeletion")
                        .HasColumnType("int");

                    b.Property<int>("DiscountId")
                        .HasColumnType("int");

                    b.Property<int?>("ExemptionId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ShiftId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BalanceId")
                        .IsUnique();

                    b.HasIndex("DiscountId")
                        .IsUnique();

                    b.HasIndex("ExemptionId");

                    b.HasIndex("ShiftId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("fb.Models.Entites.Exemption", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Added")
                        .HasColumnType("datetime2");

                    b.Property<int>("AdministrativeNumber")
                        .HasColumnType("int");

                    b.Property<DateTime>("FromDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("From_Time")
                        .HasColumnType("datetime2");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ToDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("To_Time")
                        .HasColumnType("datetime2");

                    b.Property<int>("TypeExemptionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TypeExemptionId");

                    b.ToTable("Exemptions");
                });

            modelBuilder.Entity("fb.Models.Entites.ExtraWork", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("FromDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FromTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("NameEmp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ToDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ToTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("WorksRequired")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("ExtraWorks");
                });

            modelBuilder.Entity("fb.Models.Entites.Fingerprint", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Closure_Time")
                        .HasColumnType("int");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<int>("FingerprintDevicesId")
                        .HasColumnType("int");

                    b.Property<int>("Fingerprint_date")
                        .HasColumnType("int");

                    b.Property<int>("Letting_Time")
                        .HasColumnType("int");

                    b.Property<string>("Period_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Start_Time")
                        .HasColumnType("int");

                    b.Property<int>("Time_Departure")
                        .HasColumnType("int");

                    b.Property<int>("Time_Required")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("FingerprintDevicesId");

                    b.ToTable("Fingerprints");
                });

            modelBuilder.Entity("fb.Models.Entites.FingerprintDevices", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Collection_start_Data_date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Contact_Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Device_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Device_Number")
                        .HasColumnType("int");

                    b.Property<bool>("Internet_Connection")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Last_WithdrawalData_date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Manufacturer_Number")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Network_Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Safety_Number")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Serial_Port")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Site_Device")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Speed")
                        .HasColumnType("int");

                    b.Property<string>("Website")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("FingerprintDevices");
                });

            modelBuilder.Entity("fb.Models.Entites.HolidayRequist", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AdminsterId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("DurationHoliday")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EmpNumber")
                        .HasColumnType("int");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("FromDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("HolidaysID")
                        .HasColumnType("int");

                    b.Property<string>("Job")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Management")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameEmp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ToDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("TypeHoliday")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("HolidayRequists");
                });

            modelBuilder.Entity("fb.Models.Entites.Holidays", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AdministrativeNumber")
                        .HasColumnType("int");

                    b.Property<string>("CauseOfHol")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<int?>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("FromDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("LiabilitiesOfBalance")
                        .HasColumnType("int");

                    b.Property<DateTime>("ToDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("TypeHolidayId")
                        .HasColumnType("int");

                    b.Property<DateTime>("added")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("TypeHolidayId");

                    b.ToTable("Holidays");
                });

            modelBuilder.Entity("fb.Models.Entites.JobAssignment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("FromDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FromTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ToDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ToTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("JobAssignments");
                });

            modelBuilder.Entity("fb.Models.Entites.OfficialHolidays", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AttendanceId")
                        .HasColumnType("int");

                    b.Property<DateTime>("FromDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Isfixed")
                        .HasColumnType("bit");

                    b.Property<string>("NameOfHol")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Symbol")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ToDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("AttendanceId");

                    b.ToTable("OfficialHolidays");
                });

            modelBuilder.Entity("fb.Models.Entites.OfficialHolidaysDynamic", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AttendanceId")
                        .HasColumnType("int");

                    b.Property<DateTime>("FromDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("NameOfHol")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Symbol")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ToDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("AttendanceId");

                    b.ToTable("OfficialHolidaysDynamics");
                });

            modelBuilder.Entity("fb.Models.Entites.Roles", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Screen_Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("fb.Models.Entites.Shift", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Shifts");
                });

            modelBuilder.Entity("fb.Models.Entites.TypeExemption", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Symbol")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TypeOfExemption")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TypeExemptions");
                });

            modelBuilder.Entity("fb.Models.Entites.TypeHoliday", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Balances")
                        .HasColumnType("int");

                    b.Property<string>("DaysNotDeducted")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HoliName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NoMoreThan")
                        .HasColumnType("int");

                    b.Property<string>("Renewal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Symbol")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TypeHolidays");
                });

            modelBuilder.Entity("fb.Models.Entites.UserRoles", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Delete")
                        .HasColumnType("bit");

                    b.Property<bool>("Edit")
                        .HasColumnType("bit");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<bool>("Insert")
                        .HasColumnType("bit");

                    b.Property<bool>("Print")
                        .HasColumnType("bit");

                    b.Property<int>("RolesId")
                        .HasColumnType("int");

                    b.Property<bool>("View")
                        .HasColumnType("bit");

                    b.HasKey("ID");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("RolesId");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("Fingerprin.Models.Entites.Hr_Employee", b =>
                {
                    b.HasOne("fb.Models.Entites.Employee", "Employee")
                        .WithOne("Hr_Employee")
                        .HasForeignKey("Fingerprin.Models.Entites.Hr_Employee", "EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("fb.Models.Entites.Attendance", b =>
                {
                    b.HasOne("fb.Models.Entites.Shift", "Shift")
                        .WithMany("Attendances")
                        .HasForeignKey("ShiftId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("fb.Models.Entites.Employee", b =>
                {
                    b.HasOne("fb.Models.Entites.Balance", "Balance")
                        .WithOne("Employee")
                        .HasForeignKey("fb.Models.Entites.Employee", "BalanceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("fb.Models.Entites.Discount", "Discount")
                        .WithOne("Employee")
                        .HasForeignKey("fb.Models.Entites.Employee", "DiscountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("fb.Models.Entites.Exemption", null)
                        .WithMany("Employees")
                        .HasForeignKey("ExemptionId");

                    b.HasOne("fb.Models.Entites.Shift", "Shift")
                        .WithMany("Employees")
                        .HasForeignKey("ShiftId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("fb.Models.Entites.Exemption", b =>
                {
                    b.HasOne("fb.Models.Entites.TypeExemption", "TypeExemption")
                        .WithMany("Exemptions")
                        .HasForeignKey("TypeExemptionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("fb.Models.Entites.ExtraWork", b =>
                {
                    b.HasOne("fb.Models.Entites.Employee", "Employee")
                        .WithMany("ExtraWorks")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("fb.Models.Entites.Fingerprint", b =>
                {
                    b.HasOne("fb.Models.Entites.Employee", "Employee")
                        .WithMany("Fingerprints")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("fb.Models.Entites.FingerprintDevices", "FingerprintDevices")
                        .WithMany("Fingerprints")
                        .HasForeignKey("FingerprintDevicesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("fb.Models.Entites.HolidayRequist", b =>
                {
                    b.HasOne("fb.Models.Entites.Employee", "Employee")
                        .WithMany("HolidayRequists")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("fb.Models.Entites.Holidays", b =>
                {
                    b.HasOne("fb.Models.Entites.Employee", null)
                        .WithMany("Holiday")
                        .HasForeignKey("EmployeeId");

                    b.HasOne("fb.Models.Entites.TypeHoliday", "TypeHoliday")
                        .WithMany("Holiday")
                        .HasForeignKey("TypeHolidayId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("fb.Models.Entites.OfficialHolidays", b =>
                {
                    b.HasOne("fb.Models.Entites.Attendance", "Attendance")
                        .WithMany("OfficialHolidays")
                        .HasForeignKey("AttendanceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("fb.Models.Entites.OfficialHolidaysDynamic", b =>
                {
                    b.HasOne("fb.Models.Entites.Attendance", "Attendance")
                        .WithMany()
                        .HasForeignKey("AttendanceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("fb.Models.Entites.UserRoles", b =>
                {
                    b.HasOne("fb.Models.Entites.Employee", "Employee")
                        .WithMany("UserRole")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("fb.Models.Entites.Roles", "Roles")
                        .WithMany("UserRole")
                        .HasForeignKey("RolesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}

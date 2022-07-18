using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Fingerprin.Migrations
{
    public partial class fingerprintCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Balances",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Balances = table.Column<int>(nullable: false),
                    Year = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Balances", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Discounts",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Month = table.Column<int>(nullable: false),
                    Discounted = table.Column<int>(nullable: false),
                    Total_Discount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Discounts", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "FingerprintDevices",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Network_Address = table.Column<string>(nullable: true),
                    Site_Device = table.Column<string>(nullable: true),
                    Contact_Type = table.Column<string>(nullable: true),
                    Speed = table.Column<int>(nullable: false),
                    Serial_Port = table.Column<string>(nullable: true),
                    Collection_start_Data_date = table.Column<DateTime>(nullable: false),
                    Last_WithdrawalData_date = table.Column<DateTime>(nullable: false),
                    Safety_Number = table.Column<string>(nullable: true),
                    Website = table.Column<string>(nullable: true),
                    Internet_Connection = table.Column<bool>(nullable: false),
                    Manufacturer_Number = table.Column<string>(nullable: true),
                    Device_Name = table.Column<string>(nullable: true),
                    Device_Number = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FingerprintDevices", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JobAssignments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    FromDate = table.Column<DateTime>(nullable: false),
                    ToDate = table.Column<DateTime>(nullable: false),
                    FromTime = table.Column<DateTime>(nullable: false),
                    ToTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobAssignments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Screen_Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Shifts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shifts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TypeExemptions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeOfExemption = table.Column<string>(nullable: true),
                    Symbol = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeExemptions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TypeHolidays",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HoliName = table.Column<string>(nullable: true),
                    Balances = table.Column<int>(nullable: false),
                    Renewal = table.Column<string>(nullable: true),
                    DaysNotDeducted = table.Column<string>(nullable: true),
                    NoMoreThan = table.Column<int>(nullable: false),
                    Symbol = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeHolidays", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Attendances",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name_Period = table.Column<string>(nullable: true),
                    D1 = table.Column<bool>(nullable: false),
                    D2 = table.Column<bool>(nullable: false),
                    D3 = table.Column<bool>(nullable: false),
                    D4 = table.Column<bool>(nullable: false),
                    D5 = table.Column<bool>(nullable: false),
                    D6 = table.Column<bool>(nullable: false),
                    D7 = table.Column<bool>(nullable: false),
                    Time_Departure = table.Column<DateTime>(nullable: false),
                    Start_Time = table.Column<int>(nullable: false),
                    Letting_Time = table.Column<int>(nullable: false),
                    Closure_Time = table.Column<int>(nullable: false),
                    Time_Required = table.Column<int>(nullable: false),
                    Customize = table.Column<bool>(nullable: false),
                    ShiftId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attendances", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Attendances_Shifts_ShiftId",
                        column: x => x.ShiftId,
                        principalTable: "Shifts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Exemptions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Notes = table.Column<string>(nullable: true),
                    FromDate = table.Column<DateTime>(nullable: false),
                    ToDate = table.Column<DateTime>(nullable: false),
                    AdministrativeNumber = table.Column<int>(nullable: false),
                    From_Time = table.Column<DateTime>(nullable: false),
                    To_Time = table.Column<DateTime>(nullable: false),
                    Added = table.Column<DateTime>(nullable: false),
                    TypeExemptionId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exemptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Exemptions_TypeExemptions_TypeExemptionId",
                        column: x => x.TypeExemptionId,
                        principalTable: "TypeExemptions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OfficialHolidays",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameOfHol = table.Column<string>(nullable: true),
                    Symbol = table.Column<string>(nullable: true),
                    FromDate = table.Column<DateTime>(nullable: false),
                    ToDate = table.Column<DateTime>(nullable: false),
                    Isfixed = table.Column<bool>(nullable: false),
                    AttendanceId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OfficialHolidays", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OfficialHolidays_Attendances_AttendanceId",
                        column: x => x.AttendanceId,
                        principalTable: "Attendances",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OfficialHolidaysDynamics",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameOfHol = table.Column<string>(nullable: false),
                    Symbol = table.Column<string>(nullable: false),
                    FromDate = table.Column<DateTime>(nullable: false),
                    ToDate = table.Column<DateTime>(nullable: false),
                    AttendanceId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OfficialHolidaysDynamics", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OfficialHolidaysDynamics_Attendances_AttendanceId",
                        column: x => x.AttendanceId,
                        principalTable: "Attendances",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    DEL_MARK = table.Column<bool>(nullable: false),
                    DateAdded = table.Column<int>(nullable: false),
                    DateOfDeletion = table.Column<int>(nullable: false),
                    ShiftId = table.Column<int>(nullable: false),
                    BalanceId = table.Column<int>(nullable: false),
                    DiscountId = table.Column<int>(nullable: false),
                    ExemptionId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employees_Balances_BalanceId",
                        column: x => x.BalanceId,
                        principalTable: "Balances",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Employees_Discounts_DiscountId",
                        column: x => x.DiscountId,
                        principalTable: "Discounts",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Employees_Exemptions_ExemptionId",
                        column: x => x.ExemptionId,
                        principalTable: "Exemptions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Employees_Shifts_ShiftId",
                        column: x => x.ShiftId,
                        principalTable: "Shifts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExtraWorks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameEmp = table.Column<string>(nullable: true),
                    FromDate = table.Column<DateTime>(nullable: false),
                    ToDate = table.Column<DateTime>(nullable: false),
                    FromTime = table.Column<DateTime>(nullable: false),
                    ToTime = table.Column<DateTime>(nullable: false),
                    WorksRequired = table.Column<string>(nullable: true),
                    EmployeeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExtraWorks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExtraWorks_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Fingerprints",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Period_Name = table.Column<string>(nullable: true),
                    Time_Departure = table.Column<int>(nullable: false),
                    Start_Time = table.Column<int>(nullable: false),
                    Letting_Time = table.Column<int>(nullable: false),
                    Closure_Time = table.Column<int>(nullable: false),
                    Time_Required = table.Column<int>(nullable: false),
                    Fingerprint_date = table.Column<int>(nullable: false),
                    EmployeeId = table.Column<int>(nullable: false),
                    FingerprintDevicesId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fingerprints", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Fingerprints_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Fingerprints_FingerprintDevices_FingerprintDevicesId",
                        column: x => x.FingerprintDevicesId,
                        principalTable: "FingerprintDevices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HolidayRequists",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdminsterId = table.Column<int>(nullable: false),
                    NameEmp = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    FromDate = table.Column<DateTime>(nullable: false),
                    ToDate = table.Column<DateTime>(nullable: false),
                    Job = table.Column<string>(nullable: true),
                    Management = table.Column<string>(nullable: true),
                    TypeHoliday = table.Column<bool>(nullable: false),
                    EmpNumber = table.Column<int>(nullable: false),
                    DurationHoliday = table.Column<string>(nullable: true),
                    EmployeeId = table.Column<int>(nullable: false),
                    HolidaysID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HolidayRequists", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HolidayRequists_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Holidays",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CauseOfHol = table.Column<string>(nullable: true),
                    LiabilitiesOfBalance = table.Column<int>(nullable: false),
                    FromDate = table.Column<DateTime>(nullable: false),
                    ToDate = table.Column<DateTime>(nullable: false),
                    added = table.Column<DateTime>(nullable: false),
                    AdministrativeNumber = table.Column<int>(nullable: false),
                    Duration = table.Column<int>(nullable: false),
                    TypeHolidayId = table.Column<int>(nullable: false),
                    EmployeeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Holidays", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Holidays_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Holidays_TypeHolidays_TypeHolidayId",
                        column: x => x.TypeHolidayId,
                        principalTable: "TypeHolidays",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    View = table.Column<bool>(nullable: false),
                    Insert = table.Column<bool>(nullable: false),
                    Print = table.Column<bool>(nullable: false),
                    Edit = table.Column<bool>(nullable: false),
                    Delete = table.Column<bool>(nullable: false),
                    EmployeeId = table.Column<int>(nullable: false),
                    RolesId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => x.ID);
                    table.ForeignKey(
                        name: "FK_UserRoles_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRoles_Roles_RolesId",
                        column: x => x.RolesId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Attendances_ShiftId",
                table: "Attendances",
                column: "ShiftId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_BalanceId",
                table: "Employees",
                column: "BalanceId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DiscountId",
                table: "Employees",
                column: "DiscountId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_ExemptionId",
                table: "Employees",
                column: "ExemptionId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_ShiftId",
                table: "Employees",
                column: "ShiftId");

            migrationBuilder.CreateIndex(
                name: "IX_Exemptions_TypeExemptionId",
                table: "Exemptions",
                column: "TypeExemptionId");

            migrationBuilder.CreateIndex(
                name: "IX_ExtraWorks_EmployeeId",
                table: "ExtraWorks",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Fingerprints_EmployeeId",
                table: "Fingerprints",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Fingerprints_FingerprintDevicesId",
                table: "Fingerprints",
                column: "FingerprintDevicesId");

            migrationBuilder.CreateIndex(
                name: "IX_HolidayRequists_EmployeeId",
                table: "HolidayRequists",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Holidays_EmployeeId",
                table: "Holidays",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Holidays_TypeHolidayId",
                table: "Holidays",
                column: "TypeHolidayId");

            migrationBuilder.CreateIndex(
                name: "IX_OfficialHolidays_AttendanceId",
                table: "OfficialHolidays",
                column: "AttendanceId");

            migrationBuilder.CreateIndex(
                name: "IX_OfficialHolidaysDynamics_AttendanceId",
                table: "OfficialHolidaysDynamics",
                column: "AttendanceId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_EmployeeId",
                table: "UserRoles",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RolesId",
                table: "UserRoles",
                column: "RolesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExtraWorks");

            migrationBuilder.DropTable(
                name: "Fingerprints");

            migrationBuilder.DropTable(
                name: "HolidayRequists");

            migrationBuilder.DropTable(
                name: "Holidays");

            migrationBuilder.DropTable(
                name: "JobAssignments");

            migrationBuilder.DropTable(
                name: "OfficialHolidays");

            migrationBuilder.DropTable(
                name: "OfficialHolidaysDynamics");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "FingerprintDevices");

            migrationBuilder.DropTable(
                name: "TypeHolidays");

            migrationBuilder.DropTable(
                name: "Attendances");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Balances");

            migrationBuilder.DropTable(
                name: "Discounts");

            migrationBuilder.DropTable(
                name: "Exemptions");

            migrationBuilder.DropTable(
                name: "Shifts");

            migrationBuilder.DropTable(
                name: "TypeExemptions");
        }
    }
}

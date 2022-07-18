using Microsoft.EntityFrameworkCore.Migrations;

namespace Fingerprin.Migrations
{
    public partial class CreateHr_Emp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hr_Employees",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameEmp = table.Column<string>(nullable: true),
                    Job = table.Column<string>(nullable: true),
                    Age = table.Column<int>(nullable: false),
                    Branch = table.Column<string>(nullable: true),
                    Job_Title = table.Column<string>(nullable: true),
                    Administration = table.Column<string>(nullable: true),
                    EmployeeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hr_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Hr_Employees_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Hr_Employees_EmployeeId",
                table: "Hr_Employees",
                column: "EmployeeId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hr_Employees");
        }
    }
}

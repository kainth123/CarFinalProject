using Microsoft.EntityFrameworkCore.Migrations;
using System.IO;

namespace CarFinalProject.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Car",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Car_Name = table.Column<string>(nullable: true),
                    Car_Make = table.Column<string>(nullable: true),
                    Car_Price = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Car", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Staff",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Staff_Name = table.Column<string>(nullable: true),
                    Staff_Address = table.Column<string>(nullable: true),
                    Staff_Contact = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staff", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Customer_Name = table.Column<string>(nullable: true),
                    Customer_Address = table.Column<string>(nullable: true),
                    Customer_Contact = table.Column<string>(nullable: true),
                    StaffID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customer_Staff_StaffID",
                        column: x => x.StaffID,
                        principalTable: "Staff",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Customer_StaffID",
                table: "Customer",
                column: "StaffID");
            var sqlFile = Path.Combine(".\\DatabaseScript", @"data.sql");
            migrationBuilder.Sql(File.ReadAllText(sqlFile));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Car");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Staff");
        }
    }
}

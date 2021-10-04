using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApiEmployes.Migrations
{
    public partial class AddEmployee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", nullable: true),
                    Lastname = table.Column<string>(type: "nvarchar(150)", nullable: true),
                    GenderId = table.Column<int>(type: "int", nullable: false),
                    MaritalStatusId = table.Column<int>(type: "int", nullable: false),
                    BirthdayDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Dpi = table.Column<int>(type: "int", nullable: false),
                    NIT = table.Column<string>(type: "nvarchar(15)", nullable: true),
                    SocialSecurity = table.Column<int>(type: "int", nullable: false),
                    Irtra = table.Column<int>(type: "int", nullable: false),
                    passport = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(150)", nullable: true),
                    JobPositonID = table.Column<int>(type: "int", nullable: false),
                    JobPositionId = table.Column<int>(type: "int", nullable: true),
                    Salary = table.Column<float>(type: "real", nullable: false),
                    Bonus = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employee_Genders_GenderId",
                        column: x => x.GenderId,
                        principalTable: "Genders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Employee_JobPositions_JobPositionId",
                        column: x => x.JobPositionId,
                        principalTable: "JobPositions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Employee_MaritalStatus_MaritalStatusId",
                        column: x => x.MaritalStatusId,
                        principalTable: "MaritalStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employee_GenderId",
                table: "Employee",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_JobPositionId",
                table: "Employee",
                column: "JobPositionId");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_MaritalStatusId",
                table: "Employee",
                column: "MaritalStatusId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employee");
        }
    }
}

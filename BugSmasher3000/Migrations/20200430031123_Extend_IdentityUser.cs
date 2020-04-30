using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BugSmasher3000.Migrations
{
    public partial class Extend_IdentityUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BugTicket");

            migrationBuilder.AddColumn<string>(
                name: "FName",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LName",
                table: "AspNetUsers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LName",
                table: "AspNetUsers");


            migrationBuilder.CreateTable(
                name: "BugTicket",
                columns: table => new
                {
                    BugID = table.Column<int>(type: "int", nullable: false),
                    BugDesc = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    CompDate = table.Column<DateTime>(type: "date", nullable: true),
                    EmpID = table.Column<int>(type: "int", nullable: true),
                    Severity = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "date", nullable: true),
                    Title = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__BugTicke__7812D742C4586518", x => x.BugID);
                    table.ForeignKey(
                        name: "FK__BugTicket__EmpID__29572725",
                        column: x => x.EmpID,
                        principalTable: "Employee",
                        principalColumn: "EmpID",
                        onDelete: ReferentialAction.Restrict);
                });


            migrationBuilder.CreateIndex(
                name: "IX_BugTicket_EmpID",
                table: "BugTicket",
                column: "EmpID");

        }
    }
}

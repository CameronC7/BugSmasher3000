using Microsoft.EntityFrameworkCore.Migrations;

namespace BugSmasher3000.Migrations
{
    public partial class RemovedPositionTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK__Employee__Positi__2A4B4B5E",
                table: "Employee");

            migrationBuilder.DropForeignKey(
                name: "FK__LoginInfo__Posit__2C3393D0",
                table: "LoginInfo");

            migrationBuilder.DropTable(
                name: "Position");

            migrationBuilder.DropIndex(
                name: "IX_LoginInfo_PositionID",
                table: "LoginInfo");

            migrationBuilder.DropIndex(
                name: "IX_Employee_PositionID",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "PositionID",
                table: "LoginInfo");

            migrationBuilder.DropColumn(
                name: "PositionID",
                table: "Employee");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PositionID",
                table: "LoginInfo",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PositionID",
                table: "Employee",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Position",
                columns: table => new
                {
                    PositionID = table.Column<int>(type: "int", nullable: false),
                    PosTitle = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Position", x => x.PositionID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LoginInfo_PositionID",
                table: "LoginInfo",
                column: "PositionID");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_PositionID",
                table: "Employee",
                column: "PositionID");

            migrationBuilder.AddForeignKey(
                name: "FK__Employee__Positi__2A4B4B5E",
                table: "Employee",
                column: "PositionID",
                principalTable: "Position",
                principalColumn: "PositionID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK__LoginInfo__Posit__2C3393D0",
                table: "LoginInfo",
                column: "PositionID",
                principalTable: "Position",
                principalColumn: "PositionID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

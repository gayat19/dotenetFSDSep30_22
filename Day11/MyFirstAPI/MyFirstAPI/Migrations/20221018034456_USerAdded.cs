using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyFirstAPI.Migrations
{
    public partial class USerAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Username",
                table: "Employees",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Username = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Username);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Username", "Password", "Role", "Status" },
                values: new object[] { "ramu", "1234", "admin", "Active" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 101,
                column: "Username",
                value: "ramu");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_Username",
                table: "Employees",
                column: "Username");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Users_Username",
                table: "Employees",
                column: "Username",
                principalTable: "Users",
                principalColumn: "Username");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Users_Username",
                table: "Employees");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Employees_Username",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Username",
                table: "Employees");
        }
    }
}

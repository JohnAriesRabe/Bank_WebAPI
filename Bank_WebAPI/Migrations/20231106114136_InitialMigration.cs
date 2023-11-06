using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bank_WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "b_Savings",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_b_Savings", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "b_Transactions",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_b_Transactions", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "b_Users",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fullName = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    mobile = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    password = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    password_salt = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    pin = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    pin_salt = table.Column<string>(type: "nvarchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_b_Users", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "b_Savings");

            migrationBuilder.DropTable(
                name: "b_Transactions");

            migrationBuilder.DropTable(
                name: "b_Users");
        }
    }
}

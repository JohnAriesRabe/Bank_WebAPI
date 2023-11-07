using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bank_WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "_DepositRequest",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    userID = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(16,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__DepositRequest", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "_TransferRequest",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    userID = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    SenderUserId = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    ReceiverUserId = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(16,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__TransferRequest", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "_User",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    userID = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    fullName = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    mobile = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Balance = table.Column<decimal>(type: "decimal(16,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__User", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "_WithdrawRequest",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    userID = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(16,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__WithdrawRequest", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "_DepositRequest");

            migrationBuilder.DropTable(
                name: "_TransferRequest");

            migrationBuilder.DropTable(
                name: "_User");

            migrationBuilder.DropTable(
                name: "_WithdrawRequest");
        }
    }
}

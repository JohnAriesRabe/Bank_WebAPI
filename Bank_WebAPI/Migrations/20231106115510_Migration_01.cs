using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bank_WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class Migration_01 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "userID",
                table: "b_Users",
                type: "nvarchar(100)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "credit_amount",
                table: "b_Transactions",
                type: "decimal(16,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "debit_amount",
                table: "b_Transactions",
                type: "decimal(16,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "tf_userID",
                table: "b_Transactions",
                type: "nvarchar(100)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "userID",
                table: "b_Transactions",
                type: "nvarchar(100)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "credit_amount",
                table: "b_Savings",
                type: "decimal(16,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "userID",
                table: "b_Savings",
                type: "nvarchar(100)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "userID",
                table: "b_Users");

            migrationBuilder.DropColumn(
                name: "credit_amount",
                table: "b_Transactions");

            migrationBuilder.DropColumn(
                name: "debit_amount",
                table: "b_Transactions");

            migrationBuilder.DropColumn(
                name: "tf_userID",
                table: "b_Transactions");

            migrationBuilder.DropColumn(
                name: "userID",
                table: "b_Transactions");

            migrationBuilder.DropColumn(
                name: "credit_amount",
                table: "b_Savings");

            migrationBuilder.DropColumn(
                name: "userID",
                table: "b_Savings");
        }
    }
}

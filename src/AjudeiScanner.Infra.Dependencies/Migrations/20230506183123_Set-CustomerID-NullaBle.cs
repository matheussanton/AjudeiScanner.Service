using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AjudeiScanner.Infra.Dependencies.Migrations
{
    /// <inheritdoc />
    public partial class SetCustomerIDNullaBle : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CustomerRegistrationNumber",
                table: "Coupons",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CustomerRegistrationNumber",
                table: "Coupons",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);
        }
    }
}

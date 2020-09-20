using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityFrameworkCodeFirstConsole.Migrations
{
    public partial class UpdatedCustomer_Id : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Customer_Id",
                table: "Customers",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Customer_Id",
                table: "Customers");
        }
    }
}

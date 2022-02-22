using Microsoft.EntityFrameworkCore.Migrations;

namespace yad2_clone_server.Migrations
{
    public partial class AddPropType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PropertyType",
                table: "Listings",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 1,
                column: "PropertyType",
                value: "דירת גן");

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 2,
                column: "PropertyType",
                value: "בית פרטי/קוטג'");

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 3,
                column: "PropertyType",
                value: "דירה");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PropertyType",
                table: "Listings");
        }
    }
}

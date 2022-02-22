using Microsoft.EntityFrameworkCore.Migrations;

namespace yad2_clone_server.Migrations
{
    public partial class AddImg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImgUrl",
                table: "Listings",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImgUrl",
                value: "https://img.yad2.co.il/Pic/202107/04/2_1/o/y2_1_06907_20210704140752.jpeg");

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImgUrl",
                value: "https://img.yad2.co.il/Pic/202201/19/2_1/o/y2_2_02198_20220119201822.jpeg");

            migrationBuilder.UpdateData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImgUrl",
                value: "https://img.yad2.co.il/Pic/202112/16/2_1/o/y2_1_01883_20211216115430.jpeg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImgUrl",
                table: "Listings");
        }
    }
}

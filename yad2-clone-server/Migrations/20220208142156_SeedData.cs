using Microsoft.EntityFrameworkCore.Migrations;

namespace yad2_clone_server.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Listings",
                columns: new[] { "Id", "Area", "BuiltArea", "City", "Description", "Floor", "FloorsInTheBuilding", "HasAirConditioning", "HasBars", "HasDisabledAccess", "HasElevator", "HasFurniture", "HasKosherKitchen", "HasMamad", "HasStorage", "HasTadiranAC", "HasWaterHeater", "IsPriceFlexible", "IsRenovated", "Neighborhood", "NumOfBalconies", "NumOfParkingSpots", "NumOfRooms", "Price", "PropertyState", "Street", "YardArea" },
                values: new object[] { 1, 420, 0, "הרצליה", "בבניין יוקרתי הממוקם על הגבעה בלב שכונת הרצליה ב', דירת דופלקס-גן נדירה ומיוחדת. הדירה חדשה ובנויה ברמת גימור גבוהה ובמפרט עשיר. חללי הבית מאוד מרווחים ומלאים באור טבעי. המיקום הטופוגרפי מקנה לדירה ולגינה הענקית שלה נוף פתוח עוצר נשימה לכיוון מזרח. הדירה משתרעת על פני שני מפלסים בשטח של 240 מר נטו פלוס גינה עם נוף בשטח של 180 מר. לדירה 2 חניות פרטיות בחניון התת-קרקעי של הבניין", 1, 0, false, false, false, false, false, false, false, false, false, false, false, false, "הרצליה ב'", 0, 0, 6, 10000000, "חדש", "נורדאו 10", 0 });

            migrationBuilder.InsertData(
                table: "Listings",
                columns: new[] { "Id", "Area", "BuiltArea", "City", "Description", "Floor", "FloorsInTheBuilding", "HasAirConditioning", "HasBars", "HasDisabledAccess", "HasElevator", "HasFurniture", "HasKosherKitchen", "HasMamad", "HasStorage", "HasTadiranAC", "HasWaterHeater", "IsPriceFlexible", "IsRenovated", "Neighborhood", "NumOfBalconies", "NumOfParkingSpots", "NumOfRooms", "Price", "PropertyState", "Street", "YardArea" },
                values: new object[] { 2, 533, 0, "הוד השרון", "מגרש פינתי בהוד השרון, במיקום הטוב והנגיש ביותר בנווה נאמן! רק 3 דקות הליכה מקניון שרונים, ו- 10 דקות הליכה מאזור תעשיית ההייטק והפארק האקולוגי. שטח המגרש 533 מטר, רשום בטאבו ומהוון. כיום בנוי במגרש בית ישן בשטח 70 מר ומחסן. במגרש זכויות לבניית מבנה בשטח 430 מטר כולל מחסן, מרתף ובריכת שחייה", 0, 0, false, false, false, false, false, false, false, false, false, false, false, false, "נווה נאמן", 0, 0, 3, 7000000, "במצב שמור", "הרקון 41", 0 });

            migrationBuilder.InsertData(
                table: "Listings",
                columns: new[] { "Id", "Area", "BuiltArea", "City", "Description", "Floor", "FloorsInTheBuilding", "HasAirConditioning", "HasBars", "HasDisabledAccess", "HasElevator", "HasFurniture", "HasKosherKitchen", "HasMamad", "HasStorage", "HasTadiranAC", "HasWaterHeater", "IsPriceFlexible", "IsRenovated", "Neighborhood", "NumOfBalconies", "NumOfParkingSpots", "NumOfRooms", "Price", "PropertyState", "Street", "YardArea" },
                values: new object[] { 3, 115, 0, "הרצליה", "בהרצליה הירוקה , בניין בוטיק ומיוחד , 2 דירות בקומה , 3 כיווני אוויר מלאים , דירה מוארת ומרווחת מאוד . מ. שמש , 2 חניות , מעלית , מחסן", 1, 0, false, false, false, false, false, false, false, false, false, false, false, false, "הרצליה הירוקה", 0, 0, 4, 3890000, "במצב שמור", "העלייה השנייה 13", 0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}

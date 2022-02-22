using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace yad2_clone_server.Models
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Listing>()
                .HasData(
                    new Listing
                    {
                        Id = 1,
                        Price = 10000000,
                        NumOfRooms = 6,
                        Floor = 1,
                        Area = 420,
                        City = "הרצליה",
                        Neighborhood = "הרצליה ב'",
                        Street = "נורדאו 10",
                        Description = "בבניין יוקרתי הממוקם על הגבעה בלב שכונת הרצליה ב', דירת דופלקס-גן נדירה ומיוחדת. הדירה חדשה ובנויה ברמת גימור גבוהה ובמפרט עשיר. חללי הבית מאוד מרווחים ומלאים באור טבעי. המיקום הטופוגרפי מקנה לדירה ולגינה הענקית שלה נוף פתוח עוצר נשימה לכיוון מזרח. הדירה משתרעת על פני שני מפלסים בשטח של 240 מר נטו פלוס גינה עם נוף בשטח של 180 מר. לדירה 2 חניות פרטיות בחניון התת-קרקעי של הבניין",
                        PropertyState = "חדש",
                        PropertyType = "דירת גן",
                        ImgUrl = "https://img.yad2.co.il/Pic/202107/04/2_1/o/y2_1_06907_20210704140752.jpeg"
                    },
                    new Listing
                    {
                        Id = 2,
                        Price = 7000000,
                        NumOfRooms = 3,
                        Floor = 0,
                        Area = 533,
                        City = "הוד השרון",
                        Neighborhood = "נווה נאמן",
                        Street = "הרקון 41",
                        Description = "מגרש פינתי בהוד השרון, במיקום הטוב והנגיש ביותר בנווה נאמן! רק 3 דקות הליכה מקניון שרונים, ו- 10 דקות הליכה מאזור תעשיית ההייטק והפארק האקולוגי. שטח המגרש 533 מטר, רשום בטאבו ומהוון. כיום בנוי במגרש בית ישן בשטח 70 מר ומחסן. במגרש זכויות לבניית מבנה בשטח 430 מטר כולל מחסן, מרתף ובריכת שחייה",
                        PropertyState = "במצב שמור",
                        PropertyType = "בית פרטי/קוטג'",
                        ImgUrl = "https://img.yad2.co.il/Pic/202201/19/2_1/o/y2_2_02198_20220119201822.jpeg"
                    },
                    new Listing
                    {
                        Id = 3,
                        Price = 3890000,
                        NumOfRooms = 4,
                        Floor = 1,
                        Area = 115,
                        City = "הרצליה",
                        Neighborhood = "הרצליה הירוקה",
                        Street = "העלייה השנייה 13",
                        Description = "בהרצליה הירוקה , בניין בוטיק ומיוחד , 2 דירות בקומה , 3 כיווני אוויר מלאים , דירה מוארת ומרווחת מאוד . מ. שמש , 2 חניות , מעלית , מחסן",
                        PropertyState = "במצב שמור",
                        PropertyType = "דירה",
                        ImgUrl = "https://img.yad2.co.il/Pic/202112/16/2_1/o/y2_1_01883_20211216115430.jpeg"
                    }
                );
        }

        public DbSet<Listing> Listings { get; set; }
    }
}

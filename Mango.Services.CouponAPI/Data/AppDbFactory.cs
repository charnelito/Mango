using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
 
namespace Mango.Services.CouponAPI.Data
{
    public class ApplicationDbFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseSqlServer("Server=CHARNEL\\SQLEXPRESS;Database=Mango_Coupon;Trusted_Connection=True;TrustServerCertificate=True;");

            return new AppDbContext(optionsBuilder.Options);
        }
    }
}
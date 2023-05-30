using Microsoft.EntityFrameworkCore;

namespace BethanyPieShop.Models
{
    public class BethanysPieShopDbContext : DbContext
    {
        public BethanysPieShopDbContext(DbContextOptions<BethanysPieShopDbContext> options) : base(options) { }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Pie> Pies { get; set; } //it's possible to load data in these dbsets and update the data and save changes in dbset
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set;}
    }
}

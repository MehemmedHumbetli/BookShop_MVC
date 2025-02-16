using Microsoft.EntityFrameworkCore;
using MiniBookShop.Domain.Entities;

namespace MiniBookShop.DataAccess.Context
{
    public class ShopDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Course> Courses { get; set; }

        public ShopDbContext()
        {

        }

        public ShopDbContext(DbContextOptions<ShopDbContext> options) : base(options) 
        {

        }

        
    }
}

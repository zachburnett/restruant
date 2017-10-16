using Microsoft.EntityFrameworkCore;

namespace resturant.Models
{
    public class resturantContext : DbContext
    {
        public resturantContext(DbContextOptions<resturantContext> options) : base(options) {}
        public DbSet<reviewer> reviewer {get; set;}

    }
}
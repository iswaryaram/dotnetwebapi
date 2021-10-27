using Microsoft.EntityFrameworkCore;

namespace dotnetwebapi.Models
{
    public class FruitContext : DbContext
    {
        public FruitContext(DbContextOptions<FruitContext> options)
            : base(options)
        {
        }

        public DbSet<Fruit> Fruits { get; set; }
    }
}
using Microsoft.EntityFrameworkCore;

namespace ToyLibrary.Models
{
    public class ToyLibraryContext : DbContext
    {
        public ToyLibraryContext(DbContextOptions<ToyLibraryContext> options)
            : base(options)
        {
        }

        public DbSet<Toy> Toys { get; set; }
    }
}
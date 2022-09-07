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

        protected override void OnModelCreating(ModelBuilder builder)
        {
          builder.Entity<Toy>()
            .HasData(
              new Toy { ToyId = 1, Name = "Oombee Cube Sorter", Description = "Shape-sorting cube with 6 rubbery shapes tethered to its corners", UserAgeMinimum = 1, UserAgeMaximum = 2 },

              new Toy { ToyId = 2, Name = "Boon Pipes Building Bath Toy", Description = "Colorful transparent pipes that easily stick to the bathtub walls to build all kinds of fascinating waterfall chains.", UserAgeMinimum = 1, UserAgeMaximum = 3 },

              new Toy { ToyId = 3, Name = "Magna Tiles", Description = "3D magnetic building tiles in bright colors and classic geometric shapes.", UserAgeMinimum = 1, UserAgeMaximum = 17 },

              new Toy { ToyId = 4, Name = "Elenco Snap Circuits Classic", Description = "60 Snap-Together parts consisting of electrical components that can be used to make circuits and learn about electricity.", UserAgeMinimum = 8, UserAgeMaximum = 17 },

              new Toy { ToyId = 5, Name = "Lifetime Hooligan Youth Paddleboard", Description = "Paddleboard designed for kids ages 5 and up or up to 130 lb. Great stability and tracking in both surf and flat water. Constructed of UV-protected High-Density Polyethylene", UserAgeMinimum = 5, UserAgeMaximum = 17 },

              new Toy { ToyId = 6, Name = "Chronicles of Crime", Description = "A board game that incorporates a smartphone app and virtual reality. Feels like a modern update to Clue for the tech-savvy teen. Players are presented with an unsolved murder or heist, and they determine who committed the crime, which weapons were used, and why.", UserAgeMinimum = 16, UserAgeMaximum = 17 },

              new Toy { ToyId = 7, Name = "Wee Baby Stella", Description = "Soft and cuddly 12-inch gender neutral baby doll. An ideal first doll that will encourage little ones to role play, nurture and care. ", UserAgeMinimum = 1, UserAgeMaximum = 4 },

              new Toy { ToyId = 8, Name = "Lillabo 3 Piece Train Set", Description = "Wood and plastic Ikea train train set. Children can load and unload the cars as they like since the upper parts are detachable.", UserAgeMinimum = 3, UserAgeMaximum = 5 },
              
              new Toy { ToyId = 9, Name = "Trails: A Parks Game", Description = "Players hike along the trail, collecting rocks, acorns and leaves; taking pictures; and encountering wildlife to gain bonuses. Game explores national parks across the US.", UserAgeMinimum = 10, UserAgeMaximum = 17 }
              
            );
        }
    }
}
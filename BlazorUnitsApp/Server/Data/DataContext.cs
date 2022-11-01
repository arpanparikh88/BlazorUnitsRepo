using BlazorUnitsApp.Shared;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace BlazorUnitsApp.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "The HitchHikers Guide To The Galaxy",
                    Description = "The original, first radio series comes from a proposal called \"The Ends of the Earth\": six self-contained episodes, all ending with Earth being destroyed in a different way. While writing the first episode, Adams realised that he needed someone on the planet who was an alien to provide some context, and that this alien needed a reason to be there. Adams finally settled on making the alien a roving researcher for a \"wholly remarkable book\" named The Hitchhiker's Guide to the Galaxy.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg",
                    Price = 9.99m
                },

                new Product
                {
                    Id = 2,
                    Title = "Ready Player One",
                    Description = "Sorrento asks mercenary i-R0k to learn Wade's true identity, intending to bribe him to win the contest on IOI's behalf. Wade and Art3mis discover from the Journals that Halliday once dated Morrow's wife Karen \"Kira\" Underwood. ",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/7/74/Ready_Player_One_%28film%29.png",
                    Price = 5.55m
                }

            );

            modelBuilder.Entity<Unit>().HasData(
                new Unit
                    { Id = 1, Name = "Unit One", Ip_Address = "162.191.107.130", Latitude = 33.55177, Longitude = -112.135 },
                new Unit
                    { Id = 2, Name = "Unit Two", Ip_Address = "162.191.107.130", Latitude = 33.55174, Longitude = -112.1135 },
                new Unit
                    { Id = 3, Name = "Unit Three", Ip_Address = "162.191.107.130", Latitude = 33.55173, Longitude = -112.1134 }
                );

        }

        public DbSet<Product> Products { get; set; }

        public DbSet<Unit> Units { get; set; }
    }
}

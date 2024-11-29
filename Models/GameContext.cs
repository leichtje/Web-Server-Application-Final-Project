using Microsoft.EntityFrameworkCore;

namespace Web_Server_Application_Final_Project.Models
{
    public class GameContext : DbContext
    {
        public GameContext(DbContextOptions<GameContext> options) : base(options)
        {
        }

        public DbSet<Game> Games { get; set; }
        public DbSet<Types> Types { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Types>().HasData(
        new Types { TypesId = "F", Name = "First Person" },
        new Types { TypesId = "M", Name = "MMO" },
        new Types { TypesId = "T", Name = "Third Person" },
		new Types { TypesId = "S", Name = "Shooter" },
		new Types { TypesId = "R", Name = "RPG" },
		new Types { TypesId = "P", Name = "Puzzle" }
        );
            modelBuilder.Entity<Game>().HasData(
        new Game
        {
            GameId = 1,
            Name = "Medal of Honor Frontline",
            Year = 2002,
            Rating = 5,
            TypesId = "S"
        }

    );
        }
    }
}

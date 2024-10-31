using Microsoft.EntityFrameworkCore;

namespace Web_Server_Application_Final_Project.Models
{
    public class GameContext : DbContext
    {
        public GameContext(DbContextOptions<GameContext> options) : base(options)
        {
        }

        public DbSet<Game> Games { get; set; }
        public DbSet<Type> Types { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Type>().HasData(
        new Type { TypeId = "F", Name = "First Person" },
        new Type { TypeId = "M", Name = "MMO" },
        new Type { TypeId = "T", Name = "Third Person" },
		new Type { TypeId = "S", Name = "Shooter" },
		new Type { TypeId = "R", Name = "RPG" },
		new Type { TypeId = "P", Name = "Puzzle" }
        );
            modelBuilder.Entity<Game>().HasData(
        new Game
        {
            GameId = 1,
            Name = "Medal of Honor Frontline",
            Year = 2002,
            Rating = 5,
            TypeId = "S"
        }

    );
        }
    }
}

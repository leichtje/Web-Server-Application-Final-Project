using Microsoft.EntityFrameworkCore;

namespace Web_Server_Application_Final_Project.Models
{
    public class FinalContext : DbContext
    {
        public FinalContext(DbContextOptions<FinalContext> options) : base(options)
        {
        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Genre> Genres { get; set; }

        public DbSet<Game> Games { get; set; }
        public DbSet<Types> Types { get; set; }

        public DbSet<Location> Locations { get; set; }
       

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Genre>().HasData(
        new Genre { GenreId = "A", Name = "Action" },
        new Genre { GenreId = "C", Name = "Comedy" },
        new Genre { GenreId = "D", Name = "Drama" },
        new Genre { GenreId = "H", Name = "Horror" },
        new Genre { GenreId = "M", Name = "Musical" },
        new Genre { GenreId = "R", Name = "RomCom" },
        new Genre { GenreId = "S", Name = "SciFi" }
        );
            modelBuilder.Entity<Movie>().HasData(
        new Movie
        {
            MovieId = 1,
            Name = "Kingsman",
            Year = 2012,
            Rating = 5,
            GenreId = "A"
        }

    );

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

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Location>().HasData(
        new Location
        {
            LocationId = 1,
            Name = "Clingmans Dome",
            Descriptor = "Bryson City, North Carolina",
            Year = 1959,
            Description = "The highest peak in the Great Smoky Mountains, offering breathtaking panoramic views.",
            Rating = 1
        }
        );

        }
    }
}

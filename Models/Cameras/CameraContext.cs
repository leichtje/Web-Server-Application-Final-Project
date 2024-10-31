using Microsoft.EntityFrameworkCore;

namespace Web_Server_Application_Final_Project.Models
{
    public class CameraContext : DbContext
    {
        public CameraContext(DbContextOptions<CameraContext> options) : base(options)
        {
        }

        public DbSet<Camera> Cameras { get; set; }
        public DbSet<Genre> Genres { get; set; }

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
        }
    }
}

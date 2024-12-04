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

        public DbSet<Camera> Cameras { get; set; }


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
        },
        new Movie
        {
            MovieId = 2,
            Name = "Batman Begins",
            Year = 2005,
            Rating = 5,
            GenreId = "A"
        },
        new Movie
        {
            MovieId = 3,
            Name = "The Sound of Music",
            Year = 1965,
            Rating = 5,
            GenreId = "M"
        },
        new Movie
        {
            MovieId = 4,
            Name = "Hacksaw Ridge",
            Year = 2016,
            Rating = 5,
            GenreId = "D"
        },
        new Movie
        {
            MovieId = 5,
            Name = "Back to the Future 2",
            Year = 1989,
            Rating = 3,
            GenreId = "S"
        },
        new Movie
        {
            MovieId = 6,
            Name = "DeadPool and Wolverine",
            Year = 2024,
            Rating = 5,
            GenreId = "R"
        },
        new Movie
        {
            MovieId = 7,
            Name = "Saw",
            Year = 2004,
            Rating = 5,
            GenreId = "H"
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
        },
        new Game
        {
            GameId = 2,
            Name = "Far Cry 6",
            Year = 2021,
            Rating = 5,
            TypesId = "F"
        },
        new Game
        {
            GameId = 3,
            Name = "Call of Duty Black Ops 2",
            Year = 2012,
            Rating = 5,
            TypesId = "S"
        },
        new Game
        {
            GameId = 4,
            Name = "HellDivers 2",
            Year = 2024,
            Rating = 4,
            TypesId = "T"
        },
        new Game
        {
            GameId = 5,
            Name = "God of War",
            Year = 2018,
            Rating = 5,
            TypesId = "R"
        },
        new Game
        {
            GameId = 6,
            Name = "Infamous",
            Year = 2010,
            Rating = 4,
            TypesId = "T"
        },
        new Game
        {
            GameId = 7,
            Name = "The Last of Us",
            Year = 2014,
            Rating = 4,
            TypesId = "R"
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
        },
        new Location
        {
            LocationId = 2,
            Name = "Gatlinburg",
            Descriptor = "Gatlinburg, Tennessee",
            Year = 1854,
            Description = "A charming town in Tennessee nestled in the Smoky Mountains, renowned for its attractions, shopping, and natural beauty.",
            Rating = 2
        },
        new Location
        {
            LocationId = 3,
            Name = "Niagara Falls",
            Descriptor = "Niagara Falls,New York",
            Year = 1678,
            Description = "One of the world's most famous natural wonders, with its powerful and majestic waterfalls.",
            Rating = 3
        },
        new Location
        {
            LocationId = 4,
            Name = "Hocking Hills State Park",
            Descriptor = "Logan, Ohio",
            Year = 1924,
            Description = "This Ohio state park is renowned for its stunning natural features including cliffs, waterfalls, and lush forest trails.",
            Rating = 4
        },
        new Location
        {
            LocationId = 5,
            Name = "Brown County State Park",
            Descriptor = "Nashville, Indiana",
            Year = 1929,
            Description = "Indiana's largest state park, known for its rolling hills, scenic vistas, and vibrant fall foliage.",
            Rating = 5
        },
        new Location
        {
            LocationId = 6,
            Name = "Museum of the Air Force",
            Descriptor = "Dayton, Ohio",
            Year = 1923,
            Description = "This museum showcases an extensive collection of historic aircraft and aviation artifacts.",
            Rating = 6
        },
        new Location
        {
            LocationId = 7,
            Name = "Spring Grove",
            Descriptor = "Cincinnati, Ohio",
            Year = 1845,
            Description = "A historic cemetery and arboretum celebrated for its beautiful landscapes and monuments.",
            Rating = 7
        },
        new Location
        {
            LocationId = 8,
            Name = "Brookville Lake",
            Descriptor = "Brookville, Indiana",
            Year = 1974,
            Description = "A popular destination for boating, fishing, and camping, surrounded by lush forests.",
            Rating = 8
        },
        new Location
        {
            LocationId = 9,
            Name = "Miami Whitewater Forest",
            Descriptor = "Harrison, Ohio",
            Year = 1949,
            Description = "This park offers picturesque hiking trails, fishing, and recreational activities.",
            Rating = 9
        }

        );

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Camera>().HasData(
        new Camera
        {
            CameraId = 1,
            Name = "Nikon Z6",
            Year = 2018,
            Sensor = "24.5MP Full Frame",
            Description = "A mirrorless-type camera. My most recent camera.",
            Rating = 1
        },
        new Camera
        {
            CameraId = 2,
            Name = "Nikon Z9",
            Year = 2021,
            Sensor = "45.7MP Full Frame",
            Description = "A mirrorless-type camera. I have tested a few times.",
            Rating = 2
        },
        new Camera
        {
            CameraId = 3,
            Name = "Nikon d5500",
            Year = 2015,
            Sensor = "24.2MP Crop Size",
            Description = "A DSLR-type camera. My second camera.",
            Rating = 3
        },
        new Camera
        {
            CameraId = 4,
            Name = "Nikon d3000",
            Year = 2007,
            Sensor = "10.2MP Crop Size",
            Description = "A DSLR-type camera. My first camera.",
            Rating = 4
        }
        );

        }
    }
}

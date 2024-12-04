using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Web_Server_Application_Final_Project.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cameras",
                columns: table => new
                {
                    CameraId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Sensor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cameras", x => x.CameraId);
                });

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    GenreId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.GenreId);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    LocationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descriptor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.LocationId);
                });

            migrationBuilder.CreateTable(
                name: "Types",
                columns: table => new
                {
                    TypesId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Types", x => x.TypesId);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    MovieId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    GenreId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.MovieId);
                    table.ForeignKey(
                        name: "FK_Movies_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "GenreId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    GameId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    TypesId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.GameId);
                    table.ForeignKey(
                        name: "FK_Games_Types_TypesId",
                        column: x => x.TypesId,
                        principalTable: "Types",
                        principalColumn: "TypesId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Cameras",
                columns: new[] { "CameraId", "Description", "Name", "Rating", "Sensor", "Year" },
                values: new object[,]
                {
                    { 1, "A mirrorless-type camera. My most recent camera.", "Nikon Z6", 1, "24.5MP Full Frame", 2018 },
                    { 2, "A mirrorless-type camera. I have tested a few times.", "Nikon Z9", 2, "45.7MP Full Frame", 2021 },
                    { 3, "A DSLR-type camera. My second camera.", "Nikon d5500", 3, "24.2MP Crop Size", 2015 },
                    { 4, "A DSLR-type camera. My first camera.", "Nikon d3000", 4, "10.2MP Crop Size", 2007 }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "GenreId", "Name" },
                values: new object[,]
                {
                    { "A", "Action" },
                    { "C", "Comedy" },
                    { "D", "Drama" },
                    { "H", "Horror" },
                    { "M", "Musical" },
                    { "R", "RomCom" },
                    { "S", "SciFi" }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "LocationId", "Description", "Descriptor", "Name", "Rating", "Year" },
                values: new object[,]
                {
                    { 1, "The highest peak in the Great Smoky Mountains, offering breathtaking panoramic views.", "Bryson City, North Carolina", "Clingmans Dome", 1, 1959 },
                    { 2, "A charming town in Tennessee nestled in the Smoky Mountains, renowned for its attractions, shopping, and natural beauty.", "Gatlinburg, Tennessee", "Gatlinburg", 2, 1854 },
                    { 3, "One of the world's most famous natural wonders, with its powerful and majestic waterfalls.", "Niagara Falls,New York", "Niagara Falls", 3, 1678 },
                    { 4, "This Ohio state park is renowned for its stunning natural features including cliffs, waterfalls, and lush forest trails.", "Logan, Ohio", "Hocking Hills State Park", 4, 1924 },
                    { 5, "Indiana's largest state park, known for its rolling hills, scenic vistas, and vibrant fall foliage.", "Nashville, Indiana", "Brown County State Park", 5, 1929 },
                    { 6, "This museum showcases an extensive collection of historic aircraft and aviation artifacts.", "Dayton, Ohio", "Museum of the Air Force", 6, 1923 },
                    { 7, "A historic cemetery and arboretum celebrated for its beautiful landscapes and monuments.", "Cincinnati, Ohio", "Spring Grove", 7, 1845 },
                    { 8, "A popular destination for boating, fishing, and camping, surrounded by lush forests.", "Brookville, Indiana", "Brookville Lake", 8, 1974 },
                    { 9, "This park offers picturesque hiking trails, fishing, and recreational activities.", "Harrison, Ohio", "Miami Whitewater Forest", 9, 1949 }
                });

            migrationBuilder.InsertData(
                table: "Types",
                columns: new[] { "TypesId", "Name" },
                values: new object[,]
                {
                    { "F", "First Person" },
                    { "M", "MMO" },
                    { "P", "Puzzle" },
                    { "R", "RPG" },
                    { "S", "Shooter" },
                    { "T", "Third Person" }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "GameId", "Name", "Rating", "TypesId", "Year" },
                values: new object[,]
                {
                    { 1, "Medal of Honor Frontline", 5, "S", 2002 },
                    { 2, "Far Cry 6", 5, "F", 2021 },
                    { 3, "Call of Duty Black Ops 2", 5, "S", 2012 },
                    { 4, "HellDivers 2", 4, "T", 2024 },
                    { 5, "God of War", 5, "R", 2018 },
                    { 6, "Infamous", 4, "T", 2010 },
                    { 7, "The Last of Us", 4, "R", 2014 }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "MovieId", "GenreId", "Name", "Rating", "Year" },
                values: new object[,]
                {
                    { 1, "A", "Kingsman", 5, 2012 },
                    { 2, "A", "Batman Begins", 5, 2005 },
                    { 3, "M", "The Sound of Music", 5, 1965 },
                    { 4, "D", "Hacksaw Ridge", 5, 2016 },
                    { 5, "S", "Back to the Future 2", 3, 1989 },
                    { 6, "R", "DeadPool and Wolverine", 5, 2024 },
                    { 7, "H", "Saw", 5, 2004 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Games_TypesId",
                table: "Games",
                column: "TypesId");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_GenreId",
                table: "Movies",
                column: "GenreId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cameras");

            migrationBuilder.DropTable(
                name: "Games");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "Types");

            migrationBuilder.DropTable(
                name: "Genres");
        }
    }
}

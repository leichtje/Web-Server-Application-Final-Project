using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Web_Server_Application_Final_Project.Migrations
{
    /// <inheritdoc />
    public partial class Camera : Migration
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

            migrationBuilder.InsertData(
                table: "Cameras",
                columns: new[] { "CameraId", "Description", "Name", "Rating", "Sensor", "Year" },
                values: new object[] { 1, "A mirrorless- type camera. My most recent camera.", "Nikon z6", 2, "24.5MP Full Frame", 1959 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cameras");
        }
    }
}

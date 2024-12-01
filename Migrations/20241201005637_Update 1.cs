using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Web_Server_Application_Final_Project.Migrations
{
    /// <inheritdoc />
    public partial class Update1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cameras",
                keyColumn: "CameraId",
                keyValue: 1,
                columns: new[] { "Name", "Year" },
                values: new object[] { "Nikon Z6", 2018 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cameras",
                keyColumn: "CameraId",
                keyValue: 1,
                columns: new[] { "Name", "Year" },
                values: new object[] { "Nikon z6", 1959 });
        }
    }
}

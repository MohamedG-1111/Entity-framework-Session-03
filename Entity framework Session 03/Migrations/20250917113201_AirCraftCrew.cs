using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Entity_framework_Session_03.Migrations
{
    /// <inheritdoc />
    public partial class AirCraftCrew : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Maj_pilot",
                table: "Aircrafts",
                newName: "Crew_Maj_pilot");

            migrationBuilder.RenameColumn(
                name: "Host2",
                table: "Aircrafts",
                newName: "Crew_Host2");

            migrationBuilder.RenameColumn(
                name: "Host1",
                table: "Aircrafts",
                newName: "Crew_Host1");

            migrationBuilder.RenameColumn(
                name: "Assistant",
                table: "Aircrafts",
                newName: "Crew_Assistant");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Crew_Maj_pilot",
                table: "Aircrafts",
                newName: "Maj_pilot");

            migrationBuilder.RenameColumn(
                name: "Crew_Host2",
                table: "Aircrafts",
                newName: "Host2");

            migrationBuilder.RenameColumn(
                name: "Crew_Host1",
                table: "Aircrafts",
                newName: "Host1");

            migrationBuilder.RenameColumn(
                name: "Crew_Assistant",
                table: "Aircrafts",
                newName: "Assistant");
        }
    }
}

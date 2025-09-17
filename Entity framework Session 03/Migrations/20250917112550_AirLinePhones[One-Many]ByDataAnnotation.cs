using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Entity_framework_Session_03.Migrations
{
    /// <inheritdoc />
    public partial class AirLinePhonesOneManyByDataAnnotation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Airline_Phones");

            migrationBuilder.CreateTable(
                name: "Airline_Phones",
                columns: table => new
                {
                    AL_Id = table.Column<int>(type: "int", nullable: false),
                    Phones = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Airline_Phones", x => new { x.AL_Id, x.Phones });
                    table.ForeignKey(
                        name: "FK_Airline_Phones_Airlines_AL_Id",
                        column: x => x.AL_Id,
                        principalTable: "Airlines",
                        principalColumn: "AirLineId",
                        onDelete: ReferentialAction.Cascade);
                });
        }


        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Airline_Phones_Airlines_AL_Id",
                table: "Airline_Phones");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Airline_Phones",
                table: "Airline_Phones");

            migrationBuilder.AlterColumn<string>(
                name: "Phones",
                table: "Airline_Phones",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<int>(
                name: "AL_Id",
                table: "Airline_Phones",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Airline_Phones",
                table: "Airline_Phones",
                column: "AL_Id");
        }
    }
}

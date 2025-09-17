using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Entity_framework_Session_03.Migrations
{
    /// <inheritdoc />
    public partial class Aircraft_RouteMMByFluentApis : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Aircraft_Routes",
                table: "Aircraft_Routes");

            migrationBuilder.AlterColumn<int>(
                name: "AC_Id",
                table: "Aircraft_Routes",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
              

            migrationBuilder.AddPrimaryKey(
                name: "PK_Aircraft_Routes",
                table: "Aircraft_Routes",
                columns: new[] { "Route_Id", "AC_Id" });

            migrationBuilder.CreateIndex(
                name: "IX_Aircraft_Routes_AC_Id",
                table: "Aircraft_Routes",
                column: "AC_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Aircraft_Routes_Aircrafts_AC_Id",
                table: "Aircraft_Routes",
                column: "AC_Id",
                principalTable: "Aircrafts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Aircraft_Routes_Routes_Route_Id",
                table: "Aircraft_Routes",
                column: "Route_Id",
                principalTable: "Routes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Aircraft_Routes_Aircrafts_AC_Id",
                table: "Aircraft_Routes");

            migrationBuilder.DropForeignKey(
                name: "FK_Aircraft_Routes_Routes_Route_Id",
                table: "Aircraft_Routes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Aircraft_Routes",
                table: "Aircraft_Routes");

            migrationBuilder.DropIndex(
                name: "IX_Aircraft_Routes_AC_Id",
                table: "Aircraft_Routes");

            migrationBuilder.AlterColumn<int>(
                name: "AC_Id",
                table: "Aircraft_Routes",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Aircraft_Routes",
                table: "Aircraft_Routes",
                column: "AC_Id");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Entity_framework_Session_03.Migrations
{
    /// <inheritdoc />
    public partial class AirLineEmployeeOneManyMMByFluentApis : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Employees_AL_Id",
                table: "Employees",
                column: "AL_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Airlines_AL_Id",
                table: "Employees",
                column: "AL_Id",
                principalTable: "Airlines",
                principalColumn: "AirLineId",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Airlines_AL_Id",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_AL_Id",
                table: "Employees");
        }
    }
}

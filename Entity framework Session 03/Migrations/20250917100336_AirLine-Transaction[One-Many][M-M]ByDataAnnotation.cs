using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Entity_framework_Session_03.Migrations
{
    /// <inheritdoc />
    public partial class AirLineTransactionOneManyMMByDataAnnotation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Transactions_AL_Id",
                table: "Transactions",
                column: "AL_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_Airlines_AL_Id",
                table: "Transactions",
                column: "AL_Id",
                principalTable: "Airlines",
                principalColumn: "AirLineId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_Airlines_AL_Id",
                table: "Transactions");

            migrationBuilder.DropIndex(
                name: "IX_Transactions_AL_Id",
                table: "Transactions");
        }
    }
}

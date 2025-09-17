using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Entity_framework_Session_03.Migrations
{
    /// <inheritdoc />
    public partial class EmployeeQualificationOneManyByDataAnnotation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Emp_Qualifications");

            migrationBuilder.CreateTable(
                name: "Emp_Qualifications",
                columns: table => new
                {
                    Emp_Id = table.Column<int>(type: "int", nullable: false),
                    Qualifications = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emp_Qualifications", x => new { x.Emp_Id, x.Qualifications });
                    table.ForeignKey(
                        name: "FK_Emp_Qualifications_Employees_Emp_Id",
                        column: x => x.Emp_Id,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
        }


        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Emp_Qualifications_Employees_Emp_Id",
                table: "Emp_Qualifications");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Emp_Qualifications",
                table: "Emp_Qualifications");

            migrationBuilder.AlterColumn<string>(
                name: "Qualifications",
                table: "Emp_Qualifications",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<int>(
                name: "Emp_Id",
                table: "Emp_Qualifications",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Emp_Qualifications",
                table: "Emp_Qualifications",
                column: "Emp_Id");
        }
    }
}

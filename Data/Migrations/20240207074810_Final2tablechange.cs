using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentManagement.Migrations
{
    /// <inheritdoc />
    public partial class Final2tablechange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DepartmentName",
                table: "Students",
                newName: "DepartmentID");

            migrationBuilder.RenameColumn(
                name: "DepartmentID",
                table: "Department",
                newName: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DepartmentID",
                table: "Students",
                newName: "DepartmentName");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Department",
                newName: "DepartmentID");
        }
    }
}

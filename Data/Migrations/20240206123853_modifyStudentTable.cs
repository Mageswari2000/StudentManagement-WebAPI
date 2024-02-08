using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentManagement.Migrations
{
    /// <inheritdoc />
    public partial class modifyStudentTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Students",
                newName: "Phone");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "Students",
                newName: "DepartmentName");

            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "Students",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age",
                table: "Students");

            migrationBuilder.RenameColumn(
                name: "Phone",
                table: "Students",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "DepartmentName",
                table: "Students",
                newName: "FirstName");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentManagement.Migrations
{
    /// <inheritdoc />
    public partial class SujectandStudent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SemesterType",
                table: "Subjects",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DepartmentId",
                table: "Student_Subject",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Student_Subject_DepartmentId",
                table: "Student_Subject",
                column: "DepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Student_Subject_DepartmentId",
                table: "Student_Subject",
                column: "DepartmentId",
                principalTable: "Department",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Student_Subject_DepartmentId",
                table: "Student_Subject");

            migrationBuilder.DropIndex(
                name: "IX_Student_Subject_DepartmentId",
                table: "Student_Subject");

            migrationBuilder.DropColumn(
                name: "SemesterType",
                table: "Subjects");

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "Student_Subject");
        }
    }
}

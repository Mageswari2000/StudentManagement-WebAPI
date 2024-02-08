using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentManagement.Migrations
{
    /// <inheritdoc />
    public partial class relationship1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("ALTER TABLE \"Students\" ALTER COLUMN \"DepartmentID\" TYPE integer USING \"DepartmentID\"::integer;");

            migrationBuilder.AlterColumn<int>(
                name: "DepartmentID",
                table: "Students",
                type: "integer",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.CreateIndex(
                name: "IX_Students_DepartmentID",
                table: "Students",
                column: "DepartmentID");

            migrationBuilder.AddForeignKey(
                name: "FK_Student_DepartmentID",
                table: "Students",
                column: "DepartmentID",
                principalTable: "Department",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Student_DepartmentID",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_DepartmentID",
                table: "Students");

            migrationBuilder.AlterColumn<string>(
                name: "DepartmentID",
                table: "Students",
                type: "text",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");
        }
    }
}

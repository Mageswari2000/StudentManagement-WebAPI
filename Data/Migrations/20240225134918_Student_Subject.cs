using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace StudentManagement.Migrations
{
    /// <inheritdoc />
    public partial class StudentSubject : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Department_DepartmentID",
                table: "Payment");

            migrationBuilder.DropForeignKey(
                name: "FK_Student_StudentId",
                table: "Payment");

            migrationBuilder.CreateTable(
                name: "Subjects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SubjectName = table.Column<string>(type: "text", nullable: false),
                    DepartmentId = table.Column<int>(type: "integer", nullable: false),
                    DepartmentName = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subjects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Subjects_Department_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Department",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Student_Subject",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StudentId = table.Column<int>(type: "integer", nullable: false),
                    SubjectId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student_Subject", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Student_Subject_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Student_Subject_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Student_Subject_StudentId",
                table: "Student_Subject",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Student_Subject_SubjectId",
                table: "Student_Subject",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Subjects_DepartmentId",
                table: "Subjects",
                column: "DepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Payment_DepartmentID",
                table: "Payment",
                column: "DepartmentID",
                principalTable: "Department",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Payment_StudentId",
                table: "Payment",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Payment_DepartmentID",
                table: "Payment");

            migrationBuilder.DropForeignKey(
                name: "FK_Payment_StudentId",
                table: "Payment");

            migrationBuilder.DropTable(
                name: "Student_Subject");

            migrationBuilder.DropTable(
                name: "Subjects");

            migrationBuilder.AddForeignKey(
                name: "FK_Department_DepartmentID",
                table: "Payment",
                column: "DepartmentID",
                principalTable: "Department",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Student_StudentId",
                table: "Payment",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

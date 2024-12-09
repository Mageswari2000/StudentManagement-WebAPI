using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentManagement.Migrations
{
    /// <inheritdoc />
    public partial class AddSemResIdinArrRes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "semesterResultId",
                table: "ArrearExamResult",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ArrearExamResult_semesterResultId",
                table: "ArrearExamResult",
                column: "semesterResultId");

            migrationBuilder.AddForeignKey(
                name: "FK_ArrearExamResult_semesterResultId",
                table: "ArrearExamResult",
                column: "semesterResultId",
                principalTable: "SemesterResult",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ArrearExamResult_semesterResultId",
                table: "ArrearExamResult");

            migrationBuilder.DropIndex(
                name: "IX_ArrearExamResult_semesterResultId",
                table: "ArrearExamResult");

            migrationBuilder.DropColumn(
                name: "semesterResultId",
                table: "ArrearExamResult");
        }
    }
}

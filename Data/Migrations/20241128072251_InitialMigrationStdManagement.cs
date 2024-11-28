using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace StudentManagement.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigrationStdManagement : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DepartmentName = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SemesterDetails",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SemType = table.Column<string>(type: "text", nullable: false),
                    TotalSemFees = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SemesterDetails", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RegNo = table.Column<int>(type: "integer", nullable: false),
                    FirstName = table.Column<string>(type: "text", nullable: false),
                    LastName = table.Column<string>(type: "text", nullable: false),
                    DateOfBirth = table.Column<DateOnly>(type: "date", nullable: false),
                    Age = table.Column<int>(type: "integer", nullable: false),
                    Gender = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Phone = table.Column<string>(type: "text", nullable: false),
                    GuardianName = table.Column<string>(type: "text", nullable: false),
                    GuardianPhone = table.Column<string>(type: "text", nullable: false),
                    SchlPassedOutYear = table.Column<DateOnly>(type: "date", nullable: false),
                    CutOffIn12th = table.Column<decimal>(type: "numeric", nullable: false),
                    JoiningDate = table.Column<DateOnly>(type: "date", nullable: false),
                    Batch = table.Column<int>(type: "integer", nullable: false),
                    DepartmentID = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Student_DepartmentID",
                        column: x => x.DepartmentID,
                        principalTable: "Department",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Subjects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SubjectCode = table.Column<string>(type: "text", nullable: false),
                    SubjectName = table.Column<string>(type: "text", nullable: false),
                    DepartmentId = table.Column<int>(type: "integer", nullable: false),
                    SemesterId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subjects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Subjects_DepartmentID",
                        column: x => x.DepartmentId,
                        principalTable: "Department",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Subjects_SemesterId",
                        column: x => x.SemesterId,
                        principalTable: "SemesterDetails",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ConsolidateStudentDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DepartmentId = table.Column<int>(type: "integer", nullable: false),
                    StudentId = table.Column<int>(type: "integer", nullable: false),
                    StudentRegNo = table.Column<int>(type: "integer", nullable: false),
                    StudentName = table.Column<string>(type: "text", nullable: false),
                    NoOfArrearPending = table.Column<int>(type: "integer", nullable: true),
                    NoOfArrearCleared = table.Column<int>(type: "integer", nullable: true),
                    TotalPapper = table.Column<int>(type: "integer", nullable: true),
                    PassedOutYear = table.Column<DateOnly>(type: "date", nullable: true),
                    Percentage = table.Column<int>(type: "integer", nullable: true),
                    CGPA = table.Column<int>(type: "integer", nullable: true),
                    classification = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConsolidateStudentDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ConsolidateStudentDetails_DepartmentID",
                        column: x => x.DepartmentId,
                        principalTable: "Department",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ConsolidateStudentDetails_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Payment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StudentId = table.Column<int>(type: "integer", nullable: false),
                    DepartmentId = table.Column<int>(type: "integer", nullable: false),
                    SemId = table.Column<int>(type: "integer", nullable: false),
                    paidAmount = table.Column<int>(type: "integer", nullable: false),
                    BalanceDue = table.Column<int>(type: "integer", nullable: true),
                    PaymentStatus = table.Column<string>(type: "text", nullable: false),
                    TransactionStatus = table.Column<string>(type: "text", nullable: false),
                    paymentMonthandYear = table.Column<DateOnly>(type: "date", nullable: false),
                    LastDueDate = table.Column<DateOnly>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Payment_DepartmentID",
                        column: x => x.DepartmentId,
                        principalTable: "Department",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Payment_SemId",
                        column: x => x.SemId,
                        principalTable: "SemesterDetails",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Payment_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ArrearExamResult",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SemId = table.Column<int>(type: "integer", nullable: false),
                    DepartmentId = table.Column<int>(type: "integer", nullable: false),
                    StudentId = table.Column<int>(type: "integer", nullable: false),
                    SubjectId = table.Column<int>(type: "integer", nullable: false),
                    StudentScore = table.Column<int>(type: "integer", nullable: false),
                    TotalScore = table.Column<int>(type: "integer", nullable: true),
                    Status = table.Column<string>(type: "text", nullable: false),
                    Grade = table.Column<string>(type: "text", nullable: false),
                    ArrearExamMonthYear = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArrearExamResult", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ArrearExamResult_DepartmentID",
                        column: x => x.DepartmentId,
                        principalTable: "Department",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArrearExamResult_SemId",
                        column: x => x.SemId,
                        principalTable: "SemesterDetails",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArrearExamResult_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArrearExamResult_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SemesterResult",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SemId = table.Column<int>(type: "integer", nullable: false),
                    DepartmentId = table.Column<int>(type: "integer", nullable: false),
                    StudentId = table.Column<int>(type: "integer", nullable: false),
                    SubjectId = table.Column<int>(type: "integer", nullable: false),
                    StudentSubScore = table.Column<int>(type: "integer", nullable: false),
                    TotalScore = table.Column<int>(type: "integer", nullable: true),
                    MonthandYearOfExam = table.Column<DateOnly>(type: "date", nullable: false),
                    Status = table.Column<string>(type: "text", nullable: false),
                    Grade = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SemesterResult", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SemesterResult_DepartmentID",
                        column: x => x.DepartmentId,
                        principalTable: "Department",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SemesterResult_SemId",
                        column: x => x.SemId,
                        principalTable: "SemesterDetails",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SemesterResult_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SemesterResult_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ArrearExamResult_DepartmentId",
                table: "ArrearExamResult",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_ArrearExamResult_SemId",
                table: "ArrearExamResult",
                column: "SemId");

            migrationBuilder.CreateIndex(
                name: "IX_ArrearExamResult_StudentId",
                table: "ArrearExamResult",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_ArrearExamResult_SubjectId",
                table: "ArrearExamResult",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_ConsolidateStudentDetails_DepartmentId",
                table: "ConsolidateStudentDetails",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_ConsolidateStudentDetails_StudentId",
                table: "ConsolidateStudentDetails",
                column: "StudentId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Payment_DepartmentId",
                table: "Payment",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_SemId",
                table: "Payment",
                column: "SemId");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_StudentId",
                table: "Payment",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_SemesterResult_DepartmentId",
                table: "SemesterResult",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_SemesterResult_SemId",
                table: "SemesterResult",
                column: "SemId");

            migrationBuilder.CreateIndex(
                name: "IX_SemesterResult_StudentId",
                table: "SemesterResult",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_SemesterResult_SubjectId",
                table: "SemesterResult",
                column: "SubjectId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Students_DepartmentID",
                table: "Students",
                column: "DepartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_Subjects_DepartmentId",
                table: "Subjects",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Subjects_SemesterId",
                table: "Subjects",
                column: "SemesterId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArrearExamResult");

            migrationBuilder.DropTable(
                name: "ConsolidateStudentDetails");

            migrationBuilder.DropTable(
                name: "Payment");

            migrationBuilder.DropTable(
                name: "SemesterResult");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Subjects");

            migrationBuilder.DropTable(
                name: "Department");

            migrationBuilder.DropTable(
                name: "SemesterDetails");
        }
    }
}

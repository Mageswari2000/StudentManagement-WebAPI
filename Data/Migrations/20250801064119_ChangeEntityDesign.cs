using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class ChangeEntityDesign : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_SemesterResult_SubjectId",
                table: "SemesterResult");

            migrationBuilder.DropColumn(
                name: "MonthandYearOfSemExam",
                table: "SemesterDetails");

            migrationBuilder.DropColumn(
                name: "StudentRegNo",
                table: "ConsolidateStudentDetails");

            migrationBuilder.RenameColumn(
                name: "DepartmentName",
                table: "Students",
                newName: "MiddleName");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "SemesterResult",
                newName: "ResultStatus");

            migrationBuilder.RenameColumn(
                name: "TotalSemFees",
                table: "SemesterDetails",
                newName: "TuitionFees");

            migrationBuilder.RenameColumn(
                name: "SemType",
                table: "SemesterDetails",
                newName: "SemesterNumber");

            migrationBuilder.RenameColumn(
                name: "paymentMonthandYear",
                table: "Payment",
                newName: "PaymentMonthAndYear");

            migrationBuilder.RenameColumn(
                name: "paidAmount",
                table: "Payment",
                newName: "PaidAmount");

            migrationBuilder.RenameColumn(
                name: "IsCashPaymentType",
                table: "Payment",
                newName: "IsLatePayment");

            migrationBuilder.RenameColumn(
                name: "classification",
                table: "ConsolidateStudentDetails",
                newName: "Classification");

            migrationBuilder.RenameColumn(
                name: "TotalPapper",
                table: "ConsolidateStudentDetails",
                newName: "TotalPapers");

            migrationBuilder.RenameColumn(
                name: "StudentName",
                table: "ConsolidateStudentDetails",
                newName: "Remarks");

            migrationBuilder.RenameColumn(
                name: "semesterResultId",
                table: "ArrearExamResult",
                newName: "SemesterResultId");

            migrationBuilder.RenameIndex(
                name: "IX_ArrearExamResult_semesterResultId",
                table: "ArrearExamResult",
                newName: "IX_ArrearExamResult_SemesterResultId");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Students",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AdmissionStatus",
                table: "Students",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Students",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Students",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Students",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsAbsent",
                table: "SemesterResult",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsPassed",
                table: "SemesterResult",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "SemesterDetails",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "SemesterTitle",
                table: "SemesterDetails",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Payment",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "PaidBy",
                table: "Payment",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PaymentMode",
                table: "Payment",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ReceiptNumber",
                table: "Payment",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ContactEmail",
                table: "Department",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Department",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "DepartmentCode",
                table: "Department",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DepartmentHead",
                table: "Department",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Department",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Department",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Percentage",
                table: "ConsolidateStudentDetails",
                type: "double precision",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "CGPA",
                table: "ConsolidateStudentDetails",
                type: "double precision",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "ConsolidateStudentDetails",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "HasClearedAllPapers",
                table: "ConsolidateStudentDetails",
                type: "boolean",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "ConsolidateStudentDetails",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ExamAttemptNumber",
                table: "ArrearExamResult",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_SemesterResult_SubjectId",
                table: "SemesterResult",
                column: "SubjectId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_SemesterResult_SubjectId",
                table: "SemesterResult");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "AdmissionStatus",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "IsAbsent",
                table: "SemesterResult");

            migrationBuilder.DropColumn(
                name: "IsPassed",
                table: "SemesterResult");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "SemesterDetails");

            migrationBuilder.DropColumn(
                name: "SemesterTitle",
                table: "SemesterDetails");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Payment");

            migrationBuilder.DropColumn(
                name: "PaidBy",
                table: "Payment");

            migrationBuilder.DropColumn(
                name: "PaymentMode",
                table: "Payment");

            migrationBuilder.DropColumn(
                name: "ReceiptNumber",
                table: "Payment");

            migrationBuilder.DropColumn(
                name: "ContactEmail",
                table: "Department");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Department");

            migrationBuilder.DropColumn(
                name: "DepartmentCode",
                table: "Department");

            migrationBuilder.DropColumn(
                name: "DepartmentHead",
                table: "Department");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Department");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Department");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "ConsolidateStudentDetails");

            migrationBuilder.DropColumn(
                name: "HasClearedAllPapers",
                table: "ConsolidateStudentDetails");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "ConsolidateStudentDetails");

            migrationBuilder.DropColumn(
                name: "ExamAttemptNumber",
                table: "ArrearExamResult");

            migrationBuilder.RenameColumn(
                name: "MiddleName",
                table: "Students",
                newName: "DepartmentName");

            migrationBuilder.RenameColumn(
                name: "ResultStatus",
                table: "SemesterResult",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "TuitionFees",
                table: "SemesterDetails",
                newName: "TotalSemFees");

            migrationBuilder.RenameColumn(
                name: "SemesterNumber",
                table: "SemesterDetails",
                newName: "SemType");

            migrationBuilder.RenameColumn(
                name: "PaymentMonthAndYear",
                table: "Payment",
                newName: "paymentMonthandYear");

            migrationBuilder.RenameColumn(
                name: "PaidAmount",
                table: "Payment",
                newName: "paidAmount");

            migrationBuilder.RenameColumn(
                name: "IsLatePayment",
                table: "Payment",
                newName: "IsCashPaymentType");

            migrationBuilder.RenameColumn(
                name: "Classification",
                table: "ConsolidateStudentDetails",
                newName: "classification");

            migrationBuilder.RenameColumn(
                name: "TotalPapers",
                table: "ConsolidateStudentDetails",
                newName: "TotalPapper");

            migrationBuilder.RenameColumn(
                name: "Remarks",
                table: "ConsolidateStudentDetails",
                newName: "StudentName");

            migrationBuilder.RenameColumn(
                name: "SemesterResultId",
                table: "ArrearExamResult",
                newName: "semesterResultId");

            migrationBuilder.RenameIndex(
                name: "IX_ArrearExamResult_SemesterResultId",
                table: "ArrearExamResult",
                newName: "IX_ArrearExamResult_semesterResultId");

            migrationBuilder.AddColumn<DateOnly>(
                name: "MonthandYearOfSemExam",
                table: "SemesterDetails",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));

            migrationBuilder.AlterColumn<int>(
                name: "Percentage",
                table: "ConsolidateStudentDetails",
                type: "integer",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "double precision",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CGPA",
                table: "ConsolidateStudentDetails",
                type: "integer",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "double precision",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StudentRegNo",
                table: "ConsolidateStudentDetails",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_SemesterResult_SubjectId",
                table: "SemesterResult",
                column: "SubjectId",
                unique: true);
        }
    }
}

using Microsoft.EntityFrameworkCore;
//using StudentManagement.Migrations;
using StudentManagement.Models;

namespace StudentManagement.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Students> Students { get; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<SemesterDetails> SemesterDetails { get; set; }
        public DbSet<Subjects> Subjects { get; set; }
        public DbSet<SemesterResult> SemesterResult { get; set; }
        public DbSet<ArrearExamResult> ArrearExamResult { get; set; }
        public DbSet<Payment> Payment { get; set; }
        public DbSet<ConsolidateStudentDetails> ConsolidateStudentDetails { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Students>(entity =>
            {
                entity.HasOne(d => d.Department)
                .WithMany(e => e.Student)
                .HasForeignKey(d => d.DepartmentID)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Student_DepartmentID");
            });
            modelBuilder.Entity<Subjects>(entity =>
            {
                entity.HasOne(d => d.Department)
                .WithMany(e => e.Subjects)
                .HasForeignKey(d => d.DepartmentId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Subjects_DepartmentID");

                entity.HasOne(d => d.Semester)
               .WithMany(e => e.Subjects)
               .HasForeignKey(d => d.SemesterId)
               .OnDelete(DeleteBehavior.Cascade)
               .HasConstraintName("FK_Subjects_SemesterId");
            });

            modelBuilder.Entity<SemesterResult>(entity =>
            {
                entity.HasOne(d => d.Department)
                .WithMany(e => e.SemesterResult)
                .HasForeignKey(d => d.DepartmentId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_SemesterResult_DepartmentID");

                entity.HasOne(d => d.semesterDetails)
                .WithMany(e => e.SemesterResult)
                .HasForeignKey(d => d.SemId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_SemesterResult_SemId");

                entity.HasOne(d => d.students)
               .WithMany(e => e.SemesterResult)
               .HasForeignKey(d => d.StudentId)
               .OnDelete(DeleteBehavior.Cascade)
               .HasConstraintName("FK_SemesterResult_StudentId");

                entity.HasOne(d => d.Subjects)
               .WithOne(e => e.SemesterResult)
               .HasForeignKey<SemesterResult>(d => d.SubjectId)
               .OnDelete(DeleteBehavior.Cascade)
               .HasConstraintName("FK_SemesterResult_SubjectId");
            });
            modelBuilder.Entity<ArrearExamResult>(entity =>
            {
                entity.HasOne(d => d.Department)
                .WithMany(e => e.ArrearExamResult)
                .HasForeignKey(d => d.DepartmentId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_ArrearExamResult_DepartmentID");

                entity.HasOne(d => d.SemesterDetails)
                .WithMany(e => e.ArrearExamResult)
                .HasForeignKey(d => d.SemId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_ArrearExamResult_SemId");

                entity.HasOne(d => d.Students)
               .WithMany(e => e.ArrearExamResult)
               .HasForeignKey(d => d.StudentId)
               .OnDelete(DeleteBehavior.Cascade)
               .HasConstraintName("FK_ArrearExamResult_StudentId");

                entity.HasOne(d => d.Subjects)
               .WithMany(e => e.ArrearExamResult)
               .HasForeignKey(d => d.SubjectId)
               .OnDelete(DeleteBehavior.Cascade)
               .HasConstraintName("FK_ArrearExamResult_SubjectId");
            });
            modelBuilder.Entity<Payment>(entity =>
            {
                entity.HasOne(d => d.Department)
                .WithMany(e => e.Payment)
                .HasForeignKey(d => d.DepartmentId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Payment_DepartmentID");

                entity.HasOne(d => d.SemesterDetails)
                .WithMany(e => e.Payment)
                .HasForeignKey(d => d.SemId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Payment_SemId");

                entity.HasOne(d => d.Students)
               .WithMany(e => e.payment)
               .HasForeignKey(d => d.StudentId)
               .OnDelete(DeleteBehavior.Cascade)
               .HasConstraintName("FK_Payment_StudentId");

            });
            modelBuilder.Entity<ConsolidateStudentDetails>(entity =>
            {
                entity.HasOne(d => d.Department)
                .WithMany(e => e.ConsolidateStudentDetails)
                .HasForeignKey(d => d.DepartmentId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_ConsolidateStudentDetails_DepartmentID");

                entity.HasOne(d => d.Students)
               .WithOne(e => e.ConsolidateStudentDetails)
               .HasForeignKey<ConsolidateStudentDetails>(d => d.StudentId)
               .OnDelete(DeleteBehavior.Cascade)
               .HasConstraintName("FK_ConsolidateStudentDetails_StudentId");
            });

            /////////////////////////refrence for MANY TO MANY///////////////////////////

            //modelBuilder.Entity<Student_Subject>(entity =>
            //{
            //    entity.HasOne(d => d.Student)
            //    .WithMany(e => e.Student_Subject)
            //    .HasForeignKey(d => d.StudentId)
            //    .OnDelete(DeleteBehavior.Cascade)
            //    .HasConstraintName("FK_Student_Subject_StudentId");

            //    entity.HasOne(d => d.Subject)
            //    .WithMany(e => e.Student_Subject)
            //    .HasForeignKey(d => d.SubjectId)
            //    .OnDelete(DeleteBehavior.Cascade)
            //    .HasConstraintName("FK_Student_Subject_SubjectId");

            //    entity.HasOne(d => d.Department)
            //   .WithMany(e => e.Student_Subject)
            //   .HasForeignKey(d => d.DepartmentId)
            //   .OnDelete(DeleteBehavior.Cascade)
            //   .HasConstraintName("FK_Student_Subject_DepartmentId");
            //});



        }

    }
}

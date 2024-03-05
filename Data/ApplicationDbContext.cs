using Microsoft.EntityFrameworkCore;
using StudentManagement.Migrations;
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
        public DbSet<Payment> Payment { get; set; }
        public DbSet<Subjects> Subjects { get; set; }
        public DbSet<Student_Subject> Student_Subject { get; set; }


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

            modelBuilder.Entity<Payment>(entity =>
            {
                entity.HasOne(d => d.Department)
                .WithOne(e => e.Payment)
                .HasForeignKey<Payment>(d => d.DepartmentID)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Payment_DepartmentID");

                entity.HasOne(d => d.Student)
                .WithOne(e => e.Payment)
                .HasForeignKey<Payment>(d => d.StudentId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Payment_StudentId");
            });

            modelBuilder.Entity<Student_Subject>(entity =>
            {
                entity.HasOne(d => d.Student)
                .WithMany(e => e.Student_Subject)
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Student_Subject_StudentId");

                entity.HasOne(d => d.Subject)
                .WithMany(e => e.Student_Subject)
                .HasForeignKey(d => d.SubjectId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Student_Subject_SubjectId");

                entity.HasOne(d => d.Department)
               .WithMany(e => e.Student_Subject)
               .HasForeignKey(d => d.DepartmentId)
               .OnDelete(DeleteBehavior.Cascade)
               .HasConstraintName("FK_Student_Subject_DepartmentId");
            });



        }

    }
}

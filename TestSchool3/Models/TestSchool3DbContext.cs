using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace TestSchool3.Models
{
    public partial class TestSchool3DbContext : DbContext
    {
        public TestSchool3DbContext()
        {
        }

        public TestSchool3DbContext(DbContextOptions<TestSchool3DbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblClasses> TblClasses { get; set; }
        public virtual DbSet<TblDepartment> TblDepartment { get; set; }
        public virtual DbSet<TblGrades> TblGrades { get; set; }
        public virtual DbSet<TblStaff> TblStaff { get; set; }
        public virtual DbSet<TblStudent> TblStudent { get; set; }
        public virtual DbSet<TblStudentClasses> TblStudentClasses { get; set; }
        public virtual DbSet<TblTdep> TblTdep { get; set; }
        public virtual DbSet<TeacherDep> TeacherDep { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source = Desktop-JLVI89N;Initial Catalog=TestSchool3;Integrated Security = True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblClasses>(entity =>
            {
                entity.HasKey(e => e.ClassId);

                entity.ToTable("tblClasses");

                entity.Property(e => e.ClassId)
                    .HasColumnName("ClassID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ClassName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CourseActivity)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.TeacherId).HasColumnName("TeacherID");

                entity.HasOne(d => d.Teacher)
                    .WithMany(p => p.TblClasses)
                    .HasForeignKey(d => d.TeacherId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblClasses_tblStaff");
            });

            modelBuilder.Entity<TblDepartment>(entity =>
            {
                entity.HasKey(e => e.DepId);

                entity.ToTable("tblDepartment");

                entity.Property(e => e.DepId).ValueGeneratedNever();

                entity.Property(e => e.DepName).HasMaxLength(50);
            });

            modelBuilder.Entity<TblGrades>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblGrades");

                entity.Property(e => e.DateOfGrade).HasColumnType("date");

                entity.Property(e => e.Grade).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Idclass).HasColumnName("IDClass");

                entity.Property(e => e.StudentIdgrades).HasColumnName("StudentIDGrades");

                entity.Property(e => e.TeacherIdgrades).HasColumnName("TeacherIDGrades");

                entity.HasOne(d => d.IdclassNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.Idclass)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblGrades_tblClasses");

                entity.HasOne(d => d.StudentIdgradesNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.StudentIdgrades)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblGrades_tblStudent");

                entity.HasOne(d => d.TeacherIdgradesNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.TeacherIdgrades)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblGrades_tblStaff");
            });

            modelBuilder.Entity<TblStaff>(entity =>
            {
                entity.HasKey(e => e.StaffId);

                entity.ToTable("tblStaff");

                entity.Property(e => e.StaffId)
                    .HasColumnName("StaffID")
                    .ValueGeneratedNever();

                entity.Property(e => e.DepId).HasColumnName("DepID");

                entity.Property(e => e.FirstDay)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.IdentityNumber)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Salary).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.WorkPosition)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Dep)
                    .WithMany(p => p.TblStaff)
                    .HasForeignKey(d => d.DepId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblStaff_tblDepartment");
            });

            modelBuilder.Entity<TblStudent>(entity =>
            {
                entity.HasKey(e => e.StudentId);

                entity.ToTable("tblStudent");

                entity.Property(e => e.StudentId)
                    .HasColumnName("StudentID")
                    .ValueGeneratedNever();

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.Gender).HasMaxLength(50);

                entity.Property(e => e.Idnumber)
                    .HasColumnName("IDNumber")
                    .HasMaxLength(50);

                entity.Property(e => e.LastName).HasMaxLength(50);
            });

            modelBuilder.Entity<TblStudentClasses>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblStudentClasses");

                entity.Property(e => e.ClassIdstudent).HasColumnName("ClassIDStudent");

                entity.Property(e => e.StudentFullName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.StudentIdclass).HasColumnName("StudentIDClass");

                entity.HasOne(d => d.ClassIdstudentNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.ClassIdstudent)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblStudentClassesTest_tblClasses");

                entity.HasOne(d => d.StudentIdclassNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.StudentIdclass)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblStudentClassesTest_tblStudent");
            });

            modelBuilder.Entity<TblTdep>(entity =>
            {
                entity.HasKey(e => e.TdepId);

                entity.ToTable("tblTDep");

                entity.Property(e => e.TdepId)
                    .HasColumnName("TDepID")
                    .ValueGeneratedNever();

                entity.Property(e => e.DepId).HasColumnName("DepID");

                entity.Property(e => e.TdepName)
                    .IsRequired()
                    .HasColumnName("TDepName")
                    .HasMaxLength(50);

                entity.HasOne(d => d.Dep)
                    .WithMany(p => p.TblTdep)
                    .HasForeignKey(d => d.DepId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblTDep_tblDepartment");
            });

            modelBuilder.Entity<TeacherDep>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.StaffId).HasColumnName("StaffID");

                entity.Property(e => e.TdepId).HasColumnName("TDepID");

                entity.HasOne(d => d.Staff)
                    .WithMany()
                    .HasForeignKey(d => d.StaffId)
                    .HasConstraintName("FK_TeacherDep_tblStaff");

                entity.HasOne(d => d.Tdep)
                    .WithMany()
                    .HasForeignKey(d => d.TdepId)
                    .HasConstraintName("FK_TeacherDep_tblTDep");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

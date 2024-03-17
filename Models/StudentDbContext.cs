using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace StudentManagementSystem.Models;

public partial class StudentDbContext : DbContext
{
    public StudentDbContext()
    {
    }

    public StudentDbContext(DbContextOptions<StudentDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Student> Students { get; set; }

//     protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
// #warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
//         => optionsBuilder.UseSqlServer("Server=DESKTOP-G0N0BUD\\SQLEXPRESS;Database=StudentDB;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Student>(entity =>
        {
            entity.ToTable("Student");

            entity.Property(e => e.StudentId)
                .HasMaxLength(50)
                .HasColumnName("Student_ID");
            entity.Property(e => e.Class)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Gender)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("gender");
            entity.Property(e => e.GradeId)
                .HasMaxLength(50)
                .HasColumnName("GradeID");
            entity.Property(e => e.NationalIty)
                .HasMaxLength(50)
                .HasColumnName("NationalITy");
            entity.Property(e => e.ParentAnsweringSurvey).HasMaxLength(50);
            entity.Property(e => e.ParentschoolSatisfaction).HasMaxLength(50);
            entity.Property(e => e.PlaceofBirth).HasMaxLength(50);
            entity.Property(e => e.Raisedhands).HasColumnName("raisedhands");
            entity.Property(e => e.Relation).HasMaxLength(50);
            entity.Property(e => e.SectionId)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SectionID");
            entity.Property(e => e.Semester)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.StageId)
                .HasMaxLength(50)
                .HasColumnName("StageID");
            entity.Property(e => e.StudentAbsenceDays).HasMaxLength(50);
            entity.Property(e => e.StudentMarks).HasColumnName("Student_Marks");
            entity.Property(e => e.Topic).HasMaxLength(50);
            entity.Property(e => e.VisItedResources).HasColumnName("VisITedResources");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

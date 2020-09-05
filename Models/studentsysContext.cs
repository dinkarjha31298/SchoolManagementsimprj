using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SchoolManagement.Models
{
    public partial class studentsysContext : DbContext
    {
        public studentsysContext()
        {
        }

        public studentsysContext(DbContextOptions<studentsysContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Project> Project { get; set; }
        public virtual DbSet<Student> Student { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=LAPTOP-TP1H9GUF;Database=studentsys;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Project>(entity =>
            {
                entity.HasKey(e => e.Prid)
                    .HasName("PK__project__46638AEDA7C66BC1");

                entity.ToTable("project");

                entity.Property(e => e.Prid).HasColumnName("prid");

                entity.Property(e => e.Prname)
                    .HasColumnName("prname")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Stid).HasColumnName("stid");

                entity.HasOne(d => d.St)
                    .WithMany(p => p.Project)
                    .HasForeignKey(d => d.Stid)
                    .HasConstraintName("FK__project__stid__267ABA7A");
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasKey(e => e.Stid)
                    .HasName("PK__student__312D1FC7936B6753");

                entity.ToTable("student");

                entity.Property(e => e.Stid).HasColumnName("stid");

                entity.Property(e => e.Stage).HasColumnName("stage");

                entity.Property(e => e.Stclas).HasColumnName("stclas");

                entity.Property(e => e.Stname)
                    .HasColumnName("stname")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DBFirstApp.Models
{
    public partial class dbRecruitSep2022Context : DbContext
    {
        public dbRecruitSep2022Context()
        {
        }

        public dbRecruitSep2022Context(DbContextOptions<dbRecruitSep2022Context> options)
            : base(options)
        {
        }

        public virtual DbSet<TblProfile> TblProfiles { get; set; } = null!;
        public virtual DbSet<TblUser> TblUsers { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-86CRKFR\\SQLEXPRESS;user id=sa;password=P@ssw0rd;Initial Catalog=dbRecruitSep2022");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblProfile>(entity =>
            {
                entity.ToTable("tblProfile");

                entity.Property(e => e.Age).HasDefaultValueSql("((18))");

                entity.Property(e => e.CurrentCtc).HasColumnName("CurrentCTC");

                entity.Property(e => e.Name)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Qualification)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("username");

                entity.HasOne(d => d.UsernameNavigation)
                    .WithMany(p => p.TblProfiles)
                    .HasForeignKey(d => d.Username)
                    .HasConstraintName("FK__tblProfil__usern__276EDEB3");
            });

            modelBuilder.Entity<TblUser>(entity =>
            {
                entity.HasKey(e => e.Username)
                    .HasName("PK__tblUsers__F3DBC573D05D7023");

                entity.ToTable("tblUsers");

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("username");

                entity.Property(e => e.Password)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("password");

                entity.Property(e => e.Role)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("role");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.DependencyInjection;

namespace BugSmasher3000.Models
{
    public partial class BugSmasherDataContext : DbContext
    {
        public BugSmasherDataContext()
        {
        }

        public BugSmasherDataContext(DbContextOptions<BugSmasherDataContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BugTicket> BugTicket { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<LoginInfo> LoginInfo { get; set; }
        public virtual DbSet<Position> Position { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\ProjectsV13;Initial Catalog=BugSmasherData;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BugTicket>(entity =>
            {
                entity.HasKey(e => e.BugId)
                    .HasName("PK__BugTicke__7812D742C4586518");

                entity.Property(e => e.BugId)
                    .HasColumnName("BugID")
                    .ValueGeneratedNever();

                entity.Property(e => e.BugDesc)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CompDate).HasColumnType("date");

                entity.Property(e => e.EmpId).HasColumnName("EmpID");

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Emp)
                    .WithMany(p => p.BugTicket)
                    .HasForeignKey(d => d.EmpId)
                    .HasConstraintName("FK__BugTicket__EmpID__29572725");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.EmpId)
                    .HasName("PK__Employee__AF2DBA7918095373");

                entity.Property(e => e.EmpId)
                    .HasColumnName("EmpID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.PositionId).HasColumnName("PositionID");

                entity.HasOne(d => d.Position)
                    .WithMany(p => p.Employee)
                    .HasForeignKey(d => d.PositionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Employee__Positi__2A4B4B5E");
            });

            modelBuilder.Entity<LoginInfo>(entity =>
            {
                entity.HasKey(e => e.UserName)
                    .HasName("PK__LoginInf__C9F284576F05269F");

                entity.Property(e => e.UserName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EmpId).HasColumnName("EmpID");

                entity.Property(e => e.PositionId).HasColumnName("PositionID");

                entity.Property(e => e.UserPassword)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Emp)
                    .WithMany(p => p.LoginInfo)
                    .HasForeignKey(d => d.EmpId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LoginInfo__EmpID__2B3F6F97");

                entity.HasOne(d => d.Position)
                    .WithMany(p => p.LoginInfo)
                    .HasForeignKey(d => d.PositionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LoginInfo__Posit__2C3393D0");
            });

            modelBuilder.Entity<Position>(entity =>
            {
                entity.Property(e => e.PositionId)
                    .HasColumnName("PositionID")
                    .ValueGeneratedNever();

                entity.Property(e => e.PosTitle)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

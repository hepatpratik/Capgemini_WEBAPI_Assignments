using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ProductdetWEBAPI.Models
{
    public partial class CollegeContext : DbContext
    {
        public CollegeContext()
        {
        }

        public CollegeContext(DbContextOptions<CollegeContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<Staffdet> Staffdet { get; set; }
        public virtual DbSet<Student> Student { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-RUQN97H\\SQLEXPRESS;Initial Catalog=College;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.Pcode);

                entity.Property(e => e.Pcode).ValueGeneratedNever();

                entity.Property(e => e.Category)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pdesc)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pname)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Staffdet>(entity =>
            {
                entity.HasKey(e => e.Sid);

                entity.ToTable("staffdet");

                entity.Property(e => e.Sid).HasColumnName("sid");

                entity.Property(e => e.Exp).HasColumnName("exp");

                entity.Property(e => e.Sname).HasColumnName("sname");
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasKey(e => e.Regno);

                entity.ToTable("student");

                entity.Property(e => e.Regno).HasColumnName("regno");

                entity.Property(e => e.Smailid).HasColumnName("smailid");

                entity.Property(e => e.Sname).HasColumnName("sname");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

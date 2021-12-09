using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Ang.Repository.Models;

#nullable disable

namespace Ang.Repository
{
    public partial class OopProjectDbContext : DbContext
    {
        public OopProjectDbContext()
        {
        }

        public OopProjectDbContext(DbContextOptions<OopProjectDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning 
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-7V6572P;Initial Catalog=OopProject;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasKey(e => e.FullName)
                    .HasName("PK__Students__89C60F109D4ECFC7");

                entity.Property(e => e.FullName).IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

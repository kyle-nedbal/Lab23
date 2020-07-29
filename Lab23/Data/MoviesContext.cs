using System;
using Lab23.Models;
using Microsoft.EntityFrameworkCore;

namespace Lab23.Data
{
    public class MoviesContext : DbContext
    {
        public MoviesContext(DbContextOptions<MoviesContext> options) : base(options)
        {

        }

        public DbSet<Movie> Movies { get; set; }

        //Add another DbSet?

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().ToTable("Movies")
                .Property (x => x.Title)
                    .HasMaxLength(50)
                    .HasColumnType("NVARCHAR")
                    .IsRequired();

            modelBuilder.Entity<Movie>().ToTable("Movies")
                .Property(x => x.Genre)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnType("NVARCHAR");

            modelBuilder.Entity<Movie>().ToTable("Movies")
                .Property(x => x.Runtime)
                    .HasColumnType("DOUBLE");
        }
    }
}

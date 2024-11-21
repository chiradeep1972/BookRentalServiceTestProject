using System;
using Microsoft.EntityFrameworkCore;


namespace BookRentalServiceTestProject.Models
{
    public partial class BooksDbContext:DbContext
    {
        public BooksDbContext(DbContextOptions<BooksDbContext> options)
           : base(options)
        {
        }

        public virtual DbSet<Books> Books { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Books>(entity =>
            {
                entity.Property(e => e.Title)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Auther)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ISBN).HasColumnType("int");
                entity.Property(e => e.Genre)
                   .HasMaxLength(250)
                   .IsUnicode(false);

            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

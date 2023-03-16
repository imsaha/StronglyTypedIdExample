using Microsoft.EntityFrameworkCore;
using StronglyTypedIdExample.Entities;

namespace StronglyTypedIdExample;

public class AppDbContext : DbContext
{

    public DbSet<Book> Books { get; set; }
    public DbSet<Author> Authors { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=localhost;Username=user;Password=password;Database=StronglyTypedIdDemo");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Book>()
            .Property(x=>x.Id).HasStronglyTypedId();
        modelBuilder.Entity<Book>()
            .Property(x=>x.AuthorId).HasStronglyTypedId();
        modelBuilder.Entity<Author>()
            .Property(x=>x.Id).HasStronglyTypedId();
    }
}

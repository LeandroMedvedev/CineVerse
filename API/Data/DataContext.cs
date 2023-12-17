using CineVerse.API.Models;

using Microsoft.EntityFrameworkCore;

namespace CineVerse.API.Data;

public sealed class DataContext : DbContext
{
    public DbSet<Customer> Customer { get; set; }
    public DbSet<Movie> Movie { get; set; }
    public DbSet<Serie> Serie { get; set; }
    public DbSet<Stock> Stock { get; set; }
    public DbSet<Cart> Cart { get; set; }
    // public DbSet<Genre> Genre { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var config = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.Development.json")
            .Build();
        var connection = config.GetConnectionString("DefaultConnection");

        optionsBuilder.UseSqlServer(connection);
    }
}

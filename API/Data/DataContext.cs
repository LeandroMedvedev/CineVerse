using CineVerse.API.Models;

using Microsoft.EntityFrameworkCore;

namespace CineVerse.API.Data;

public sealed class DataContext : DbContext
{
    public DbSet<Customer> Customer { get; set; }

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

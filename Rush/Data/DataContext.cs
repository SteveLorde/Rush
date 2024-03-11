using Microsoft.EntityFrameworkCore;
using Rush.Data.Models;

namespace Rush.Data;

public class DataContext : DbContext
{

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlite($"Data Source=database.db");
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Item>().HasData(
            new Item {Id = Guid.Parse(""), Name = "Call Of Duty Black Ops 2", imagecover = "cover.png", Filesname = "CODBO2.rar", LastUpdated = DateOnly.FromDateTime(DateTime.Today)}
        );
    }
    
    public DbSet<Item> Items { get; set; }
    
    
}
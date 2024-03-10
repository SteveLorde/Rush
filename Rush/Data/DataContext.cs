using Microsoft.EntityFrameworkCore;
using Rush.Data.Models;

namespace Rush.Data;

public class DataContext : DbContext
{

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlite($"Data Source=database.db");
    }
    
    public DbSet<Item> Items { get; set; }
    
    
}
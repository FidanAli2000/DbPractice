using DbPractice.Model;
using Microsoft.EntityFrameworkCore;

namespace DbPractice.DataBase;

public class StoreAppDataBase : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=STHQ0128-16;Initial Catalog=StoreAppDataBase;User ID=admin;Password=admin;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True");
        base.OnConfiguring(optionsBuilder);
    }

    public DbSet<Customer> Customers { get; set; }
    public DbSet <Order> Orders { get; set; }
    public DbSet <Product> Products { get; set; }
}

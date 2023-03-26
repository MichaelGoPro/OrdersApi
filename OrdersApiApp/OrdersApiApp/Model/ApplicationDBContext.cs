using Microsoft.EntityFrameworkCore;
using OrdersApiApp.Model.Entity;

namespace OrdersApiApp.Model;

public class ApplicationDBContext : DbContext
{
    public DbSet<Client> Clients { set; get; }
    public DbSet<Order> Orders { set; get; }
    public DbSet<Product> Products { set; get; }
    public DbSet<Order_Product> Orders_Products { set; get; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        IConfigurationRoot configuration = new ConfigurationBuilder().
            SetBasePath(AppDomain.CurrentDomain.BaseDirectory).
            AddJsonFile("appsettings.json").Build();
        optionsBuilder.UseNpgsql(configuration.GetConnectionString("DefaultConnection"));
    }
}
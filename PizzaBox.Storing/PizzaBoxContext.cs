using Microsoft.EntityFrameworkCore;
using PizzaBox.Domain.Models;

namespace PizzaBox.Storing
{
  public class PizzaBoxContext : DbContext
  {

    public DbSet<Crust> Crusts { get; set; }
    public DbSet<Crust> Toppings { get; set; }
    public DbSet<Crust> Sizes { get; set; }
    public DbSet<Crust> Pizzas { get; set; }
    public DbSet<Crust> Stores { get; set; }
    public DbSet<Crust> Customers { get; set; }

    public PizzaBoxContext(DbContextOptions options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<AStore>().HasKey(e => e.EntityId);
      builder.Entity<ChicagoStore>().HasBaseType<AStore>();
      builder.Entity<NewYorkStore>().HasBaseType<AStore>();

      builder.Entity<APizza>().HasKey(e => e.EntityId);
      builder.Entity<CustomPizza>().HasBaseType<APizza>();
      builder.Entity<MeatPizza>().HasBaseType<APizza>();
      builder.Entity<VeggiePizza>().HasBaseType<APizza>();

      builder.Entity<Crust>().HasKey(e => e.EntityId);

      builder.Entity<Order>().HasKey(e => e.EntityId);
      builder.Entity<Size>().HasKey(e => e.EntityId);
      builder.Entity<Topping>().HasKey(e => e.EntityId);

      builder.Entity<Customer>().HasKey(e => e.EntityId);
    }
  }
}
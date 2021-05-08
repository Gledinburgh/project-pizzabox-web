using Microsoft.EntityFrameworkCore;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models;
using PizzaBox.Domain.Models.Pizzas;
using PizzaBox.Domain.Models.Stores;

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

      OnDataSeeding(builder);
    }
    private void OnDataSeeding(ModelBuilder builder)
    {
      builder.Entity<MeatPizza>().HasData(new MeatPizza[]
     {
        new MeatPizza() { EntityId = 1, CrustEntityId = 1, SizeEntityId = 2}
     });
      builder.Entity<VeggiePizza>().HasData(new VeggiePizza[]
      {
        new VeggiePizza() { EntityId = 2}
      });


      builder.Entity<ChicagoStore>().HasData(new ChicagoStore[]
      {
        new ChicagoStore() { EntityId = 1, Name = "Chitown Main Street"}
      });

      builder.Entity<NewYorkStore>().HasData(new NewYorkStore[]
      {
        new NewYorkStore() { EntityId = 2, Name = "BigApple"}
      });

      builder.Entity<Crust>().HasData(new Crust[]
{
        new Crust() { EntityId = 1, Name = "Thin", Price = 1.00M}
});
      builder.Entity<Crust>().HasData(new Crust[]
      {
        new Crust() { EntityId = 2, Name = "Stuffed", Price = 1.00M}
      });
      builder.Entity<Crust>().HasData(new Crust[]
      {
        new Crust() { EntityId = 3, Name = "Original", Price = 1.00M}
      });
      builder.Entity<Crust>().HasData(new Crust[]
      {
        new Crust() { EntityId = 4, Name = "Neapolitan", Price = 1.00M}
      });
      builder.Entity<Size>().HasData(new Size[]
      {
        new Size("Small") { EntityId = 1}
      });
      builder.Entity<Size>().HasData(new Size[]
      {
        new Size("Medium") { EntityId = 2}
      });
      builder.Entity<Size>().HasData(new Size[]
      {
        new Size("Large") { EntityId = 3}
      });
      builder.Entity<Size>().HasData(new Size[]
      {
        new Size("Eating Challange(XXXL)") { EntityId = 4}
      });
      builder.Entity<Topping>().HasData(new Topping[]
      {
        new Topping("peppers") {EntityId = 1},
      });
      builder.Entity<Topping>().HasData(new Topping[]
      {
        new Topping("onions")  {EntityId = 2},
      });
      builder.Entity<Topping>().HasData(new Topping[]
      {
        new Topping("olives")  {EntityId = 3},
      });
      builder.Entity<Topping>().HasData(new Topping[]
      {
        new Topping("Mozzarella")  {EntityId = 4},
      });
      builder.Entity<Topping>().HasData(new Topping[]
      {
        new Topping("Marinara")  {EntityId = 5},
      });
    }
  }
}
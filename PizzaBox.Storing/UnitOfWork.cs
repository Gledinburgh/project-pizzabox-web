using PizzaBox.Storing;
using PizzaBox.Storing.Repositories;

namespace PizzaBox.Storing
{
  public class UnitOfWork
  {
    private readonly PizzaBoxContext _context;

    public StoreRepository Stores { get; }
    public CustomerRepository Customers { get; }
    public CrustRepository Crusts { get; }
    public OrderRepository Orders { get; set; }
    public PizzaRepository Pizzas { get; set; }
    public SizeRepository Sizes { get; }
    public ToppingRepository Toppings { get; }

    public UnitOfWork(PizzaBoxContext context)
    {
      _context = context;

      Crusts = new CrustRepository(_context);
      Customers = new CustomerRepository(_context);
      Stores = new StoreRepository(_context);
      Orders = new OrderRepository(_context);
      Pizzas = new PizzaRepository(_context);
      Sizes = new SizeRepository(_context);
      Toppings = new ToppingRepository(_context);
    }

    public void Save()
    {
      _context.SaveChanges();
    }
  }
}
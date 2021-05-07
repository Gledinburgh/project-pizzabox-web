using PizzaBox.Storing.Repositories;

namespace PizzaBox.Storing
{
  public class UnitOfWork
  {

    private readonly PizzaBoxContext _context;
    public CrustRepository Crusts { get; }
    public CustomerRepository Customers { get; }

    public UnitOfWork(PizzaBoxContext context)
    {
      _context = context;

      Crusts = new CrustRepository(_context);
    }

  }
}
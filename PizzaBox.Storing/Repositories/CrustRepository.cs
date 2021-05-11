using System;
using System.Collections.Generic;
using PizzaBox.Domain.Interfaces;
using PizzaBox.Domain.Models;

namespace PizzaBox.Storing.Repositories
{
  public class CrustRepository : IRepository<Crust>
  {
    private readonly PizzaBoxContext _context;

    public CrustRepository(PizzaBoxContext context)
    {
      _context = context;
    }
    public bool Create(Crust crust)
    {
      throw new System.NotImplementedException();
    }

    public bool Delete()
    {
      throw new System.NotImplementedException();
    }

    public IEnumerable<Crust> Read(Func<Crust, bool> filter)
    {
      return _context.Crusts;
    }

    public Crust Update()
    {
      throw new System.NotImplementedException();
    }
  }
}
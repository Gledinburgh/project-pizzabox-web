using System;
using System.Collections.Generic;
using PizzaBox.Domain.Interfaces;
using PizzaBox.Domain.Models;

namespace PizzaBox.Storing.Repositories
{
  public class SizeRepository : IRepository<Size>
  {
    private readonly PizzaBoxContext _context;

    public SizeRepository(PizzaBoxContext context)
    {
      _context = context;
    }
    public bool Create()
    {
      throw new System.NotImplementedException();
    }

    public bool Delete()
    {
      throw new System.NotImplementedException();
    }

    public IEnumerable<Size> Read(Func<Size, bool> filter)
    {
      return _context.Sizes;
    }

    public Size Update()
    {
      throw new System.NotImplementedException();
    }
  }
}
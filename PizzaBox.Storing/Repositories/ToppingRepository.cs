using System;
using System.Collections.Generic;
using PizzaBox.Domain.Interfaces;
using PizzaBox.Domain.Models;

namespace PizzaBox.Storing.Repositories
{
  public class ToppingRepository : IRepository<Topping>
  {
    private readonly PizzaBoxContext _context;

    public ToppingRepository(PizzaBoxContext context)
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

    public IEnumerable<Topping> Read(Func<Topping, bool> filter)
    {
      return _context.Toppings;
    }

    public Topping Update()
    {
      throw new System.NotImplementedException();
    }
  }
}
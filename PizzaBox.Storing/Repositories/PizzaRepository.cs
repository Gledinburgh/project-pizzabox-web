using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Interfaces;
using PizzaBox.Domain.Models;

namespace PizzaBox.Storing.Repositories
{
  public class PizzaRepository : IRepository<APizza>
  {
    private readonly PizzaBoxContext _context;

    public PizzaRepository(PizzaBoxContext context)
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

    public IEnumerable<APizza> Read(Func<APizza, bool> filter)
    {
      var pizzas = _context.Pizzas
                  .Include(p => p.Crust)
                  .Include(p => p.Size);
      return pizzas;
    }

    public APizza Update()
    {
      throw new System.NotImplementedException();
    }

    public APizza Where()
    {
      throw new NotImplementedException();
    }
  }
}
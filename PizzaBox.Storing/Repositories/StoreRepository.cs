using System.Collections.Generic;
using PizzaBox.Domain.Interfaces;
using PizzaBox.Domain.Models;
using PizzaBox.Domain.Abstracts;
using System;
using Microsoft.EntityFrameworkCore;

namespace PizzaBox.Storing.Repositories
{

  public class StoreRepository : IRepository<AStore>
  {
    private readonly PizzaBoxContext _context;

    public StoreRepository(PizzaBoxContext context)
    {
      _context = context;
    }
    public bool Create(AStore store)
    {
      throw new System.NotImplementedException();
    }

    public bool Delete()
    {
      throw new System.NotImplementedException();
    }

    public IEnumerable<AStore> Read(Func<AStore, bool> filter)
    {
      var stores = _context.Stores;

      return stores;
    }

    public AStore Update()
    {
      throw new System.NotImplementedException();
    }
  }

}
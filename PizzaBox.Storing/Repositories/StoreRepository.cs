using System.Collections.Generic;
using PizzaBox.Domain.Interfaces;
using PizzaBox.Domain.Models;
using PizzaBox.Domain.Abstracts;
using System;

namespace PizzaBox.Storing.Repositories
{
  public class StoreRepository : IRepository<AStore>
  {
    public bool Create()
    {
      throw new System.NotImplementedException();
    }

    public bool Delete()
    {
      throw new System.NotImplementedException();
    }

    public IEnumerable<AStore> Read(Func<AStore, bool> filter)
    {
      throw new System.NotImplementedException();
    }

    public AStore Update()
    {
      throw new System.NotImplementedException();
    }
  }

}
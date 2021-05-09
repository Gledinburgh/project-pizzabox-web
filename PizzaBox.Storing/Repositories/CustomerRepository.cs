using System;
using System.Collections.Generic;
using PizzaBox.Domain.Interfaces;
using PizzaBox.Domain.Models;

namespace PizzaBox.Storing.Repositories
{
  public class CustomerRepository : IRepository<Customer>
  {
    private readonly PizzaBoxContext _context;

    public CustomerRepository(PizzaBoxContext context)
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

    public IEnumerable<Customer> Read(Func<Customer, bool> filter)
    {
      throw new System.NotImplementedException();
    }

    public Customer Update()
    {
      throw new System.NotImplementedException();
    }
  }
}
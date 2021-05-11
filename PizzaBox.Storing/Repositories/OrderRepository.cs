using System;
using System.Collections.Generic;
using System.Linq;
using PizzaBox.Domain.Interfaces;
using PizzaBox.Domain.Models;

namespace PizzaBox.Storing.Repositories
{
  public class OrderRepository : IRepository<Order>
  {
    private readonly PizzaBoxContext _context;

    public OrderRepository(PizzaBoxContext context)
    {
      _context = context;
    }
    public bool Create(Order order)
    {
      _context.Orders.Add(order);
      return true;
    }

    public bool Delete()
    {
      throw new System.NotImplementedException();
    }

    public IEnumerable<Order> Read(Func<Order, bool> filter)
    {
      var orders = _context.Orders;
      return orders;
    }

    public Order Update()
    {
      throw new System.NotImplementedException();
    }
    public Order NewOrder()
    {
      return new Order();
    }
  }
}
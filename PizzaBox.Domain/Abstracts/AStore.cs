using System.Collections.Generic;
using PizzaBox.Domain.Models;

namespace PizzaBox.Domain.Abstracts
{
  public abstract class AStore : AEntity
  {
    public string Name { get; set; }
    public List<Order> Orders { get; set; }

    public override string ToString()
    {
      return Name;
    }
  }
}
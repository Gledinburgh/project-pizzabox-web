using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
  public class Customer : AEntity
  {
    public string Name { get; set; }
  }
}
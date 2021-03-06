using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
  public class Crust : AComponent
  {
    public ICollection<APizza> Pizzas { get; set; }
    public Crust(string name)
    {
      Name = name;
    }
    public Crust() { }
  }
}
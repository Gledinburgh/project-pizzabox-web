using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
  public class Crust : AComponent
  {
    public static List<string> crustsOptions = new List<string> { "Thin", "Stuffed", "Original" };
    public ICollection<APizza> Pizzas { get; set; }
    public Crust(string name)
    {
      Name = name;
    }
    public Crust() { }
  }
}
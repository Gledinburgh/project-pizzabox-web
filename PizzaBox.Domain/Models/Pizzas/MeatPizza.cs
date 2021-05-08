using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models.Pizzas
{

  public class MeatPizza : APizza
  {
    protected override void AddName()
    {
      Name = "Meat Pizza";
    }
  }
}
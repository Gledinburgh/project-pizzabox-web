using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models.Pizzas
{
  public class CustomPizza : APizza
  {
    protected override void AddName()
    {
      Name = "Custom Pizza";
    }

  }
}
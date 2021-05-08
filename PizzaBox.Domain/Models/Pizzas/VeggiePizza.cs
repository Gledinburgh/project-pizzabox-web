using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models.Pizzas
{

  public class VeggiePizza : APizza
  {

    protected override void AddName()
    {
      Name = "Veggie Pizza";
    }

  }
}
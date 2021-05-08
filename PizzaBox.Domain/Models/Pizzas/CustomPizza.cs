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
    protected override void AddCrust()
    {
      Crust = new Crust() { Name = "Original" };
    }

    protected override void AddSize()
    {
      Size = new Size("Medium");
    }


    protected override void AddToppings()
    {
      Toppings = new List<Topping>()
      {
        new Topping() { Name = "Mozzarella" },
        new Topping() { Name = "Marinara" }
      };
    }
  }
}
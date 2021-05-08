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
    protected override void AddCrust()
    {
      Crust = new Crust() { Name = "Neapolitan" };
    }

    protected override void AddSize()
    {
      Size = new Size("Medium");
    }

    protected override void AddToppings()
    {
      Toppings = new List<Topping>()
      {
        new Topping() { Name = "Parmigiano" },
        new Topping() { Name = "Margherita" }
      };
    }
  }
}
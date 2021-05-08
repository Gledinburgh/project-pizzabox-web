using System.Collections.Generic;
using System.Text;
using PizzaBox.Domain.Models;

namespace PizzaBox.Domain.Abstracts
{
  public abstract class APizza : AEntity
  {
    public string Name;
    public Crust Crust { get; set; }
    public Size Size { get; set; }
    public long CrustEntityId { get; set; }
    public long SizeEntityId { get; set; }
    public List<Topping> Toppings { get; set; }

    protected APizza()
    {
      Factory();
    }

    protected virtual void Factory()
    {
      AddName();
      AddCrust();
      AddSize();
      AddToppings();
    }

    protected abstract void AddName();
    protected abstract void AddCrust();
    protected abstract void AddSize();

    protected abstract void AddToppings();


    public override string ToString()
    {
      var stringBuilder = new StringBuilder();
      var separator = ", ";

      foreach (var item in Toppings)
      {
        stringBuilder.Append($"{item}{separator}");
      }

      return $"{Name} \n\t Crust: {Crust} \n\t Size: {Size} \n\t Toppings: {stringBuilder.ToString().TrimEnd(separator.ToCharArray())} \n\t Price: ${PizzaPrice()}\n";
    }
    public decimal PizzaPrice()
    {
      decimal sum = Crust.Price + Size.Price;
      foreach (Topping t in Toppings)
      {
        sum += t.Price;
      }
      return sum;
    }
  }
}
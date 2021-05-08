namespace PizzaBox.Domain.Abstracts
{
  public class AComponent : AEntity
  {
    public string Name { get; set; }
    public decimal Price { get; set; }

    public override string ToString()
    {
      return Name;
    }
  }
}
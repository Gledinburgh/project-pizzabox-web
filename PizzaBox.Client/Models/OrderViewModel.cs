using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PizzaBox.Storing;
using PizzaBox.Domain.Models;
using System.Linq;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models.Pizzas;

namespace PizzaBox.Client.Models
{
  public class OrderViewModel
  {
    public Order CurrentOrder { get; set; }
    public APizza CurrentPizza { get; set; }
    public string SelectedPizzaName { get; set; }
    public List<Crust> Crusts { get; set; }
    public List<APizza> Pizzas { get; set; }
    public List<AStore> Stores { get; set; }
    public List<Size> Sizes { get; set; }
    public List<Topping> Toppings { get; set; }

    [Required(ErrorMessage = "Need to Select a crust")]
    [DataType(DataType.Text)]
    public Customer SelectedCustomer { get; set; }

    [Required(ErrorMessage = "Need to Select a Pizza")]
    public List<APizza> SelectedPizzas { get; set; }

    [Required(ErrorMessage = "Need to Select a store")]
    public AStore SelectedStore { get; set; }
    public Size SelectedSize { get; set; }
    public Crust SelectedCrust { get; set; }
    public List<string> SelectedToppings { get; set; }


    public void Load(UnitOfWork unitOfWork)
    {
      Pizzas = unitOfWork.Pizzas.Read(c => c.EntityId < 4).ToList();
      Crusts = unitOfWork.Crusts.Read(c => c.EntityId >= 0).ToList();
      Toppings = unitOfWork.Toppings.Read(c => c.EntityId >= 0).ToList();
      Sizes = unitOfWork.Sizes.Read(c => c.EntityId >= 0).ToList();
      Stores = unitOfWork.Stores.Read(c => c.EntityId >= 0).ToList();
    }


    public IEnumerable<ValidationResult> ValidationResults(ValidationContext validation)
    {
      yield return new ValidationResult("oops", new string[] { "1", "2" });
    }
  }
}
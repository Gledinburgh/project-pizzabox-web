using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PizzaBox.Storing;
using PizzaBox.Domain.Models;
using System.Linq;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Client.Models
{
  public class OrderViewModel
  {

    private UnitOfWork _unitOfWork;
    public List<Crust> Crusts { get; set; }
    [Required(ErrorMessage = "Need to Select a crust")]
    [DataType(DataType.Text)]
    public Crust SelectedCrust { get; set; }

    [Required(ErrorMessage = "Need to Select a Pizza")]
    [Range(0, 50)]
    public List<APizza> Pizzas { get; set; }
    public List<APizza> SelectedPizzas { get; set; }

    public void Load(UnitOfWork unitOfWork)
    {
      Crusts = unitOfWork.Crusts.Read(c => c.EntityId > 0).ToList();
    }

    public IEnumerable<ValidationResult> ValidationResults(ValidationContext validation)
    {
      yield return new ValidationResult("oops", new string[] { "1", "2" });
    }
  }
}
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Storing;

namespace PizzaBox.Client.Models
{
  public class PizzaViewModel
  {
    public List<APizza> PizzaList { get; set; }
    [Required]
    public string SelectedPizza { get; set; }

    public void Load(UnitOfWork unitOfWork)
    {
      PizzaList = unitOfWork.Pizzas.Read(c => c.EntityId >= 0).ToList();
    }
  }
}
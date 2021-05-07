using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PizzaBox.Client.Models
{
  public class CustomerViewModel
  {
    public List<string> Customers { get; set; } = new List<string> { "customer1", "customer2" };
    [Required]
    public string SelectedCustomer { get; set; }
  }
}
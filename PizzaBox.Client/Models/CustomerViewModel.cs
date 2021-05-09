using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PizzaBox.Domain.Models;

namespace PizzaBox.Client.Models
{
  public class CustomerViewModel
  {
    public List<Customer> Customers { get; set; }
    [Required]
    public string SelectedCustomer { get; set; }
  }
}
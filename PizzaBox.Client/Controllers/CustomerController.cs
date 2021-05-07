using Microsoft.AspNetCore.Mvc;
using PizzaBox.Client.Models;

namespace PizzaBox.Client.Controllers
{
  public class CustomerController : Controller
  {
    [HttpPost]
    [Route("Customer/[action]")]
    [HttpPost]
    public IActionResult validate(CustomerViewModel customer)
    {
      //check whether or not the customer exists
      //if so return index view
      //otherwise return other view
      return View();
    }
  }
}
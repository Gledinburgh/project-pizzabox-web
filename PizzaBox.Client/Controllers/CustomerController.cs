using Microsoft.AspNetCore.Mvc;
using PizzaBox.Client.Models;
using PizzaBox.Storing;

namespace PizzaBox.Client.Controllers
{
  [Route("customer/[action]")]
  public class CustomerController : Controller
  {
    private readonly UnitOfWork _unitOfWork;

    [HttpGet]
    public IActionResult Name()
    {
      return View("Name");
    }
    [HttpPost]
    public IActionResult StepOne(CustomerViewModel customer)
    {
      //set customer to be customer.SelectedCustomer
      return View("StepOne", customer);
    }
    [HttpPost]
    public IActionResult validate(CustomerViewModel customer)
    {
      //check whether or not the customer exists
      //if so return index view
      //otherwise return other view
      return View();
    }
    public CustomerController(UnitOfWork unitOfWork)
    {
      _unitOfWork = unitOfWork;
    }
  }
}
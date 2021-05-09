
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using PizzaBox.Client.Models;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Storing;

namespace PizzaBox.Client.Controllers
{
  [Route("[controller]/[action]")]
  public class OrderController : Controller
  {
    private readonly UnitOfWork _unitOfWork;
    [HttpPost]
    [HttpGet]
    [ValidateAntiForgeryToken]
    public IActionResult submit(OrderViewModel order)
    {
      return View("index", _unitOfWork);
    }
    [HttpPost]
    [HttpGet]
    public IActionResult SelectPizza(CustomerViewModel customer, OrderViewModel order)
    {
      System.Console.WriteLine("customer in OrderControler:" + customer.SelectedCustomer);
      order.Load(_unitOfWork);
      return View("SelectPizza", order);
    }
    public IActionResult SelectStore(OrderViewModel order)
    {
      order.Load(_unitOfWork);
      return View("SelectStore", order);
    }
    public IActionResult NextSteps(CustomerViewModel customer, OrderViewModel order, PizzaViewModel pizza)
    {
      System.Console.WriteLine("customer: " + customer.SelectedCustomer);
      order.CurrentPizza = _unitOfWork.Pizzas.Read(p => p.Name == order.SelectedPizzaName).First();
      order.CurrentPizza.Size = _unitOfWork.Sizes.Read(s => s.Name == order.SelectedSize.Name).First();
      order.CurrentPizza.Crust = _unitOfWork.Crusts.Read(c => c.Name == order.SelectedCrust.Name).First();

      if (order.SelectedPizzas == null)
      {
        order.SelectedPizzas = new List<APizza>();
      }
      order.SelectedPizzas.Add(order.CurrentPizza);
      System.Console.WriteLine("Selected pizza:" + order.SelectedPizzaName);
      System.Console.WriteLine("Current Order:" + order.SelectedPizzas[0].Name);
      return View("NextSteps", order);
    }
    //test
    [HttpPost]
    [HttpGet]
    public IActionResult NewOrder(OrderViewModel order)
    {
      order.Load(_unitOfWork);
      return View("NewOrder", order);
    }
    public IActionResult ConfirmPizza(OrderViewModel order)
    {
      order.Load(_unitOfWork);
      return View("CustomizePizza", order);
    }


    public OrderController(UnitOfWork unitOfWork)
    {
      _unitOfWork = unitOfWork;
    }
  }
}

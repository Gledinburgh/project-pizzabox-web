
using Microsoft.AspNetCore.Mvc;
using PizzaBox.Client.Models;
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
    public IActionResult SelectPizza(PizzaViewModel pizzas)
    {
      pizzas.Load(_unitOfWork);
      return View("SelectPizza", pizzas);
    }
    //test
    [HttpPost]
    [HttpGet]
    public IActionResult NewOrder(OrderViewModel order)
    {
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

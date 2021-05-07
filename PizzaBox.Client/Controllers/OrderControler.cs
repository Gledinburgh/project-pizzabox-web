
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
      ViewBag.SelectedCrust = order.SelectedCrust;
      return View("index", _unitOfWork);
    }
    public OrderController(UnitOfWork unitOfWork)
    {
      _unitOfWork = unitOfWork;
    }
  }
}

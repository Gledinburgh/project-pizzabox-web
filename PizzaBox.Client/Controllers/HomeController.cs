using Microsoft.AspNetCore.Mvc;
using PizzaBox.Client.Models;
using PizzaBox.Storing;
using PizzaBox.Storing.Repositories;

namespace PizzaBox.Client.Controllers
{
  [Route("[controller]/[action]")]
  public class HomeController : Controller
  {
    private readonly UnitOfWork _unitOfWork;

    public HomeController(UnitOfWork unitOfWork)
    {
      _unitOfWork = unitOfWork;
    }

    [HttpGet]
    public IActionResult Index()
    {
      var order = new OrderViewModel();

      order.Load(_unitOfWork);

      return View("order", order);
    }
    [HttpGet]
    public IActionResult Welcome()
    {
      var order = new OrderViewModel();

      return View("welcome", order);
    }
  }
}

using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using PizzaBox.Client.Models;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models;
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
    public IActionResult SelectPizza(OrderViewModel order)
    {
      order.Load(_unitOfWork);
      return View("SelectPizza", order);
    }
    public IActionResult SelectStore(OrderViewModel order)
    {
      order.Load(_unitOfWork);
      return View("SelectStore", order);
    }
    public IActionResult NextSteps(OrderViewModel order)
    {
      order.Load(_unitOfWork);

      order.CurrentPizza = _unitOfWork.Pizzas.Read(p => p.EntityId >= 0).FirstOrDefault(p => p.Name == order.SelectedPizzaName);
      order.CurrentPizza.Size = _unitOfWork.Sizes.Read(c => c.EntityId >= 0).FirstOrDefault(c => c.Name == order.SelectedSize);
      order.CurrentPizza.Crust = _unitOfWork.Crusts.Read(c => c.EntityId >= 0).FirstOrDefault(c => c.Name == order.SelectedCrust);

      var newCustomer = new Customer { Name = order.SelectedCustomer };
      _unitOfWork.Customers.Create(newCustomer);
      _unitOfWork.Save();

      var customer = _unitOfWork.Customers.Read(c => c.EntityId >= 0).FirstOrDefault(c => c.Name == order.SelectedCustomer);
      var CustomerId = customer.EntityId;
      var store = _unitOfWork.Stores.Read(s => s.EntityId >= 0).FirstOrDefault(s => s.Name == order.SelectedStore);
      var newOrder = new Order()
      {
        Store = store,
        Customer = customer,
        Pizzas = new List<APizza> { order.CurrentPizza }
      };
      _unitOfWork.Orders.Create(newOrder);
      _unitOfWork.Save();

      return View("NextSteps", order);
    }

    [HttpPost]
    [HttpGet]
    public IActionResult placeorder(OrderViewModel order)
    {
      order.Load(_unitOfWork);
      order.CustomerOrders = _unitOfWork.Orders.Read(o => o.CustomerEntityId == order.CustomerId).ToList();
      return View("OrderPlaced", order);
    }
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

    // CUSTOMER ACTIONS

    public IActionResult Name(OrderViewModel order)
    {
      return View("Name", order);
    }
    [HttpPost]
    public IActionResult StepOne(OrderViewModel order)
    {
      return View("StepOne", order);
    }

    public OrderController(UnitOfWork unitOfWork)
    {
      _unitOfWork = unitOfWork;
    }
  }
}

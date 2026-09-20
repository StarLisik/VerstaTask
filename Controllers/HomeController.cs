using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using VerstaTask.Models;
using VerstaTask.Services;

namespace VerstaTask.Controllers
{
    public class HomeController : Controller
    {
        private readonly IOrderService OrderService;

        public HomeController(IOrderService orderService)
        {
            OrderService = orderService;
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(OrderRequestModel order)
        {
            if (!ModelState.IsValid)
            {
                return View(order);
            }

            await OrderService.AddOrder(order);
            
            return RedirectToAction(nameof(AllOrders));
        }

        public async Task<IActionResult> AllOrders()
        {
            var orders = await OrderService.GetAll();

            return View(orders);
        }

        public async Task<IActionResult> GetOrderById(int id)
        {
            var order = await OrderService.GetById(id);

            if (order == null)
            {
                return NotFound();
            }

            return View("Order", order);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

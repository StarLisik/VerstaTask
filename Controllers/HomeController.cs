using Microsoft.AspNetCore.Mvc;
using VestaTask.Models;
using VestaTask.Services;

namespace VestaTask.Controllers
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
                return View();
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
    }
}

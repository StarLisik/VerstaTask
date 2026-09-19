using Microsoft.EntityFrameworkCore;
using VestaTask.Models;

namespace VestaTask.Services
{
    public class OrderService : IOrderService
    {
        private readonly ApplicationContext db;
        private readonly ILogger<OrderService> logger;

        public OrderService (ApplicationContext db, ILogger<OrderService> logger)
        {
            this.db = db;
            this.logger = logger;
        }

        public async Task<OrderModel?> GetById(int id)
        {
            return await db.Orders
                .AsNoTracking()
                .FirstOrDefaultAsync(order => order.Id == id);
        }

        public async Task<List<OrderModel>> GetAll()
        {
            try
            {
                return await db.Orders
                .AsNoTracking()
                .ToListAsync();
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Ошибка при получении списка заказов");
                return new List<OrderModel>();
            }
        }

        public async Task AddOrder(OrderRequestModel order)
        {
            var newOrder = new OrderModel()
            {
                CitySender = order.CitySender,
                AdressSender = order.AdressSender,
                CityReceiver = order.CityReceiver,
                AdressReceiver = order.AdressReceiver,
                Weight = order.Weight,
                PickDate = order.PickDate
            };

            db.Orders.Add(newOrder);
            db.SaveChanges();
        }
    }
}

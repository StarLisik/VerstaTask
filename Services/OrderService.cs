using Microsoft.EntityFrameworkCore;
using VestaTask.Models;

namespace VestaTask.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository repository;
        private readonly ILogger<OrderService> logger;

        public OrderService (IOrderRepository repository, ILogger<OrderService> logger)
        {
            this.repository = repository;
            this.logger = logger;
        }

        public async Task<OrderModel?> GetById(int id)
        {
            return await repository.GetById(id);
        }

        public async Task<List<OrderModel>> GetAll()
        {
            return await repository.GetAll();
        }

        public async Task AddOrder(OrderRequestModel order)
        {
            var newOrder = new OrderModel()
            {
                CitySender = order.CitySender,
                AddressSender = order.AddressSender,
                CityReceiver = order.CityReceiver,
                AddressReceiver = order.AddressReceiver,
                Weight = order.Weight,
                PickDate = order.PickDate
            };

            await repository.Add(newOrder);
        }
    }
}

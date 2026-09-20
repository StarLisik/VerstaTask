using Microsoft.EntityFrameworkCore;
using VestaTask.Models;

namespace VestaTask.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private readonly ApplicationContext db;

        public OrderRepository(ApplicationContext db)
        {
            this.db = db;
        }

        public async Task<OrderModel?> GetById(int id) =>
            await db.Orders
            .AsNoTracking()
            .FirstOrDefaultAsync(o => o.Id == id);

        public async Task<List<OrderModel>> GetAll() =>
            await db.Orders
            .AsNoTracking()
            .ToListAsync();

        public async Task Add(OrderModel order)
        {
            db.Orders.Add(order);
            await db.SaveChangesAsync();
        }
    }
}

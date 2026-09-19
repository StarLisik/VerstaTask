using VestaTask.Models;

namespace VestaTask.Repository
{
    public interface IOrderRepository
    {
        Task<OrderModel?> GetById(int id);
        Task<List<OrderModel>> GetAll();
        Task AddOrder(OrderModel order);
    }
}

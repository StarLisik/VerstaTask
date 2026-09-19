using VestaTask.Models;

namespace VestaTask.Services
{
    public interface IOrderService
    {
        Task<OrderModel?> GetById(int id);
        Task<List<OrderModel>> GetAll();
        Task AddOrder(OrderRequestModel order);
    }
}

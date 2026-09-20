using VerstaTask.Models;

namespace VerstaTask.Services
{
    public interface IOrderService
    {
        Task<OrderModel?> GetById(int id);
        Task<List<OrderModel>> GetAll();
        Task AddOrder(OrderRequestModel order);
    }
}

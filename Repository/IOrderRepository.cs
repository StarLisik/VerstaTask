using VestaTask.Models;

public interface IOrderRepository
{
    Task<OrderModel?> GetById(int id);
    Task<List<OrderModel>> GetAll();
    Task Add(OrderModel order);
}
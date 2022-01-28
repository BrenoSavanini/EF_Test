using EF_Test.Domain.Models;

namespace EF_Test.Domain.Interfaces{
    public interface IOrderRepository{
        IEnumerable<Order> Get();
        Order Create(Order order);
    }
}
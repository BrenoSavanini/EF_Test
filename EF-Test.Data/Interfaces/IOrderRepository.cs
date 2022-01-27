using EF_Test.Data.Models;

namespace EF_Test.Data.Interfaces{
    public interface IOrderRepository{
        IEnumerable<Product> Get();
    }
}
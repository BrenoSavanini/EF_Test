using EF_Test.Domain.Models;

namespace EF_Test.Domain.Interfaces{
    public interface IProductRepository{
        Product Create(Product product);
    }
}
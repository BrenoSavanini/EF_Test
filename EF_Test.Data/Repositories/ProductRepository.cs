using EF_Test.Domain.Interfaces;
using EF_Test.Domain.Models;

namespace EF_Test.Data.Repositories{
    public class ProductRepository: IProductRepository{
        public Product Create(Product product){
            var db = new DatabaseContext();
            db.Products.Add(product);
            db.SaveChanges();
            return product;
        }
    }
}
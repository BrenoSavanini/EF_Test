using EF_Test.Data.Interfaces;
using EF_Test.Data.Models;

namespace EF_Test.Data.Repositories{
    public class OrderRepository: IOrderRepository{
        public OrderRepository(){

        }
        public IEnumerable<Product> Get(){
            var db = new DatabaseContext();

            var orders = db.Products; 
            return orders;
            
        }
    }
}
using EF_Test.Domain.Interfaces;
using EF_Test.Domain.Models;

namespace EF_Test.Data.Repositories{
    public class OrderRepository: IOrderRepository{
        public IEnumerable<Order> Get(){
            var db = new DatabaseContext();

            var orders = db.Orders; 
            return orders;
            
        }
        public Order Create(Order order){
            var db = new DatabaseContext();
            db.Orders.Add(order);
            db.SaveChanges();

            return order;
            
        }
    }
}
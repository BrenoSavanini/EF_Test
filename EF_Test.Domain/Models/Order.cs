namespace EF_Test.Domain.Models{
  public class Order
  {
    public int OrderId { get; set; }

    public DateTime? Created { get; set; }
  
    public ICollection<OrderItem>? Items { get; set; }
  }
}
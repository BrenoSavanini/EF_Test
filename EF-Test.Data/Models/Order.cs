namespace EF_Test.Data.Models{
  public class Order
  {
    public int OrderId { get; set; }

    public DateTime? Created { get; set; }
  
    public ICollection<OrderItem>? Items { get; set; }
  }
}
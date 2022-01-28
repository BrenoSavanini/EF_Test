namespace EF_Test.Domain.Models{
  public class OrderItem
  {
    public int OrderItemId { get; set; }
    public int Quantity { get; set; }
    public virtual Product? Product { get; set; }
  }
}
namespace ECommerceAppWPF.Model
{
    public class CartItem
    {
        public int CartItemId { get; set; }
        public int CartId { get; set; }
        public int ItemId { get; set; }
        public int Quantity { get; set; }
        public Item Item { get; set; }
    }
}

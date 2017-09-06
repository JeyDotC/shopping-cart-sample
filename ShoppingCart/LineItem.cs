namespace ShoppingCart
{
    public class LineItem
    {
        public int Quantity { get; set; }

        public decimal Price { get; set; }

        public Product Product { get; private set; }

        public LineItem(Product product, int quantity, decimal price)
        {
            Product = product;
            Price = price;
            Quantity = quantity;
        }
    }
}
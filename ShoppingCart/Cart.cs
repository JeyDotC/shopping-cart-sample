using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingCart
{
    public class Cart
    {
        public long Id { get; set; }

        private List<LineItem> _lineItems = new List<LineItem>();
        
        public DateTime DateCreated { get; set; }

        public IEnumerable<LineItem> LineItems => _lineItems;

        public void ChangeItemQuantity(int productId, int newQuantity)
        {
            var existingLineItem = _lineItems.FirstOrDefault(l => l.Product.Id == productId);

            if (existingLineItem == null)
            {
                throw new InvalidOperationException("Product not found in the cart.");
            }

            if (existingLineItem.Quantity > 0)
            {
                existingLineItem.Quantity--;
            }
        }

        public void AddLineItem(Product product, int quantity, decimal price)
        {
            var existingLineItem = _lineItems.FirstOrDefault(l => l.Product.Id == product.Id);

            if (existingLineItem != null)
            {
                existingLineItem.Quantity++;
            }
            else
            {
                _lineItems.Add(new LineItem(product, quantity, price));
            }
        }

        public void RemoveLineItem(int productId)
        {
            var existingLineItem = _lineItems.FirstOrDefault(l => l.Product.Id == productId);

            if (existingLineItem != null)
            {
                _lineItems.Remove(existingLineItem);
            }
        }
    }
}

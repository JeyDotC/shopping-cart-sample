using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.Application.Requests
{
    public class AddProductToCartRequest
    {
        public int CartId { get; set; }

        public int ProductId { get; set; }

        public int Quantity { get; set; }

        public decimal Price { get; set; }
    }
}

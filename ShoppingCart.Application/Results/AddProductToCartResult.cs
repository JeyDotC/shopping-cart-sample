using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.Application.Results
{
    public class AddProductToCartResult : ResultBase
    {
        public AddProductToCartResult(Status status, string message = "", Exception exception = null) 
            : base(status, message, exception)
        {
        }
    }
}

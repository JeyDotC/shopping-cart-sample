using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.Application
{
    public interface IRequestHandler<in TRequest, TResult>
    {
        TResult Handle(TRequest request);
    }
}

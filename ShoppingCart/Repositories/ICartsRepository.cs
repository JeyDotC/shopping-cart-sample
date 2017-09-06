using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.Repositories
{
    public interface ICartsRepository
    {
        Cart Get(int id);

        void Add(Cart data);

        void Update(Cart data);
    }
}

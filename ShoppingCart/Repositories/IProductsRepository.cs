using ShoppingCart.Repositories.Queries;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.Repositories
{
    public interface IProductsRepository
    {
        Product Get(int id);

        IEnumerable<Product> List(FindProductsBySearchStringQuery query);

        IEnumerable<Product> List(Paging paging);

        void Add(Product product);

        void Update(Product product);
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.Repositories.Queries
{
    public struct FindProductsBySearchStringQuery
    {
        public string SearchString { get; set; }

        public Paging Paging { get; set; }
    }
}

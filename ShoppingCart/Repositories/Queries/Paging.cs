using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.Repositories.Queries
{
    public struct Paging
    {
        public int Skip { get; }

        public int Count { get; }

        public Paging(int skip, int count)
            : this()
        {
            Skip = skip;
            Count = count;
        }
    }
}

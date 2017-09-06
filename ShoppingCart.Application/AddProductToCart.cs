using ShoppingCart.Application.Requests;
using ShoppingCart.Application.Results;
using ShoppingCart.Repositories;
using System;

namespace ShoppingCart.Application
{
    // https://fullstackmark.com/post/11/better-software-design-with-clean-architecture
    public class AddProductToCart : IRequestHandler<AddProductToCartRequest, AddProductToCartResult>
    {
        private ICartsRepository _carts;
        private IProductsRepository _products;

        public AddProductToCart(ICartsRepository carts, IProductsRepository products)
        {
            _carts = carts;
            _products = products;
        }

        public AddProductToCartResult Handle(AddProductToCartRequest request)
        {
            try
            {
                var cart = _carts.Get(request.CartId);
                var product = _products.Get(request.ProductId);

                cart.AddLineItem(product, request.Quantity, request.Price);

                _carts.Update(cart);

                return new AddProductToCartResult(Status.Succeeded);
            }
            catch (Exception ex)
            {
                return new AddProductToCartResult(Status.Failed, exception: ex);
            }
        }
    }
}

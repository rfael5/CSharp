using Stripe;
using Stripe.Checkout;

namespace BlazorEcommerce.Client.Services.PaymentService
{
    public class PaymentService : IPaymentService
    {
        private readonly ICartService _cartService;
        private readonly IAuthService _authService;
        private readonly IOrderService _orderService;

        public PaymentService(ICartService cartService,
            IAuthService authService,
            IOrderService orderService)
        {
            StripeConfiguration.ApiKey = "sk_test_51NFherKS4BTu2wjNUsN26pEksnRhnKjZIcGFWDW2NWwtFJP4ow90Ii1kkkjkwdcrk4CjrJGSHs3s8BLIwNRjU2mm007B85S9XD";
            
            _cartService = cartService;
            _authService = authService;
            _orderService = orderService;
        }
        /*public async Task<Session> CreateCheckoutSession()
        {
            var products = (await _cartService.GetDbCartProducts()).Data;
            var lineItems = new List<SessionLineItemOptions>();
            products.ForEach(product => lineItems.Add(new SessionLineItemOptions
            {
                PriceData = new SessionLineItemPriceDataOptions
                {
                    UnitAmoutDecimal = product.Price * 100,
                    Currency = "usd",
                    ProductData = new SessionLineItemPriceDataProductDataOptions
                    {
                        Name = product.Title,
                        Images = new List<string> { product.ImageUrl }
                    }
                },
                Quantity = product.Quantity
            }));
        }*/
    }
}

using Stripe;
using Stripe.Checkout;
namespace Proj.Services;

public class StripePaymentService
{
    public StripePaymentService()
    {
        StripeConfiguration.ApiKey = "sk_test_51QhRyxJg5c5h9iXSpd1ii56kyngE7FIMHn5ut9e2q05LeHGyBpBaV5d9dEhPJK0Hz9bmPV2JF7N7NhQ66rJ3hIIR00jZYtep0Q"; // Replace this with you actual api key 
    }

    public Session CreateCheckoutSession(decimal totalAmount, string successUrl, string cancelUrl)
    {
        var options = new SessionCreateOptions
        {
            PaymentMethodTypes = new List<string> { "card" },
            LineItems = new List<SessionLineItemOptions>
            {
                new SessionLineItemOptions
                {
                    PriceData = new SessionLineItemPriceDataOptions
                    {
                        Currency = "usd",
                        ProductData = new SessionLineItemPriceDataProductDataOptions
                        {
                            Name = "Order Payment",
                        },
                        UnitAmountDecimal = totalAmount * 100, // Convert to cents
                    },
                    Quantity = 1,
                }
            },
            Mode = "payment",
            SuccessUrl = successUrl,
            CancelUrl = cancelUrl,
        };

        var service = new SessionService();
        return service.Create(options);
    }
    
}

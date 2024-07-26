namespace Checkout_Kata.Services
{
    public interface IPricing
    {
        int GetUnitPrice(string sku);
        (int? Quantity, int? Price) GetOffer(string sku);
    }
}

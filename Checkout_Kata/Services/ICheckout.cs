namespace Checkout_Kata.Services
{
    public interface ICheckout
    {
        void Scan(string item);
        int GetTotalPrice();
    }
}

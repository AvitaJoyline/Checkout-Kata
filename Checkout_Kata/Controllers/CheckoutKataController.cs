using Checkout_Kata.Services;
using Microsoft.AspNetCore.Mvc;

namespace Checkout_Kata.Controllers
{
    [Route("api/[controller]")]
    public class CheckoutKataController : Controller
    {
        private readonly ICheckout _checkout;

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckoutKataController"/> class.
        /// </summary>
        /// <param name="checkout">The checkout service to use.</param>
        public CheckoutKataController(ICheckout checkout)
        {
            _checkout = checkout;
        }

        /// <summary>
        /// Scans an item by its SKU.
        /// </summary>
        /// <param name="sku">The SKU of the item to scan.</param>
        /// <returns>HTTP status code indicating the result of the operation.</returns>
        [HttpPost]
        public IActionResult ScanItem(string sku)
        {
            _checkout.Scan(sku);
            return Ok();
        }

        /// <summary>
        /// Gets the total price of all scanned items.
        /// </summary>
        /// <returns>The total price.</returns>
        [HttpGet]
        public IActionResult GetTotal()
        {
            var total = _checkout.GetTotalPrice();
            return Ok(total);
        }
    }

}

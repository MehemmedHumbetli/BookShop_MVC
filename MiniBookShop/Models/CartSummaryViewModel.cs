using MiniBookShop.Domain.Models;

namespace MiniBookShop.Models
{
    public class CartSummaryViewModel
    {
        public CartSummaryViewModel() 
        {
            
        }

        public Cart Cart { get; set; }
    }
}

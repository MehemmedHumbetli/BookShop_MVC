using MiniBookShop.Domain.Models;

namespace MiniBookShop.Services
{
    public interface ICartSessionService
    {
        Cart GetCart();
        void SetCart(Cart cart);
    }
}

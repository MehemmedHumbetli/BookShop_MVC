using MiniBookShop.Domain.Entities;
using MiniBookShop.Domain.Models;

namespace MiniBookShop.Application.Abstract
{
    public interface ICartService
    {
        void AddToCart(Cart cart, Book book);
        void RemoveFromCart(Cart cart, int bookId);
        List<CartLine> List(Cart cart);
    }
}

using MiniBookShop.Domain.Entities;
using MiniBookShop.Domain.Models;
using System.Collections.Generic;

namespace MiniBookShop.Application.Abstract
{
    public interface ICartService
    {
        void AddToCart(Cart cart, object item);
        void RemoveFromCart(Cart cart, int itemId, ItemType itemType);
        List<CartLine> List(Cart cart);
    }

    public enum ItemType
    {
        Book,
        Course
    }
}

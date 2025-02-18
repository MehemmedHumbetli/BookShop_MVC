using MiniBookShop.Application.Abstract;
using MiniBookShop.Domain.Entities;
using MiniBookShop.Domain.Models;
using System.Linq;
using System.Collections.Generic;

namespace MiniBookShop.Application.Concrete
{
    public class CartService : ICartService
    {
        public void AddToCart(Cart cart, object item)
        {
            if (item is Book book)
            {
                var cartLine = cart.CartLines.FirstOrDefault(cl => cl.Book?.Id == book.Id);
                if (cartLine != null)
                    cartLine.Quantity++;
                else
                    cart.CartLines.Add(new CartLine { Quantity = 1, Book = book });
            }
            else if (item is Course course)
            {
                var cartLine = cart.CartLines.FirstOrDefault(cl => cl.Course?.Id == course.Id);
                if (cartLine != null)
                    cartLine.Quantity++;
                else
                    cart.CartLines.Add(new CartLine { Quantity = 1, Course = course });
            }
        }

        public void RemoveFromCart(Cart cart, int itemId, ItemType itemType)
        {
            if (itemType == ItemType.Book)
            {
                var cartLine = cart.CartLines.FirstOrDefault(c => c.Book?.Id == itemId);
                if (cartLine != null)
                    cart.CartLines.Remove(cartLine);
            }
            else if (itemType == ItemType.Course)
            {
                var cartLine = cart.CartLines.FirstOrDefault(c => c.Course?.Id == itemId);
                if (cartLine != null)
                    cart.CartLines.Remove(cartLine);
            }
        }

        public List<CartLine> List(Cart cart)
        {
            return cart.CartLines;
        }
    }
}

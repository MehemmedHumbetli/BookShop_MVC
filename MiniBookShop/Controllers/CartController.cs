using Microsoft.AspNetCore.Mvc;
using MiniBookShop.Application.Abstract;
using MiniBookShop.Models;
using MiniBookShop.Services;
using MiniBookShop.Domain.Models;

namespace MiniBookShop.Controllers
{
    public class CartController(IBookService bookService, ICartSessionService cartSessionService, ICartService cartService, ICourseService courseService) : Controller
    {
        private readonly IBookService _bookService = bookService;
        private readonly ICartSessionService _cartSessionService = cartSessionService;
        private readonly ICartService _cartService = cartService;
        private readonly ICourseService _courseService = courseService;

        public IActionResult AddToCart(int Id, string type)
        {
            var cart = _cartSessionService.GetCart();

            if (type.ToLower() == "book")
            {
                var bookToBeAdded = _bookService.GetById(Id);
                if (bookToBeAdded != null)
                {
                    _cartService.AddToCart(cart, bookToBeAdded);
                    TempData["message"] = $"Your book '{bookToBeAdded.Name}' was added successfully to the cart!";
                }
            }
            else if (type.ToLower() == "course")
            {
                var courseToBeAdded = _courseService.GetById(Id);
                if (courseToBeAdded != null)
                {
                    _cartService.AddToCart(cart, courseToBeAdded);
                    TempData["message"] = $"Your course '{courseToBeAdded.Name}' was added successfully to the cart!";
                }
            }

            _cartSessionService.SetCart(cart);
            return RedirectToAction("Index", type.ToLower() == "book" ? "Book" : "Course");
        }

        [HttpGet]
        public IActionResult List()
        {
            var cart = _cartSessionService.GetCart();
            var model = new CartListViewModel()
            {
                Cart = cart
            };
            return View(model);
        }

        public IActionResult Delete(int Id, string type)
        {
            var cart = _cartSessionService.GetCart();

            if (type.ToLower() == "book")
            {
                _cartService.RemoveFromCart(cart, Id, ItemType.Book);
                TempData["message"] = "Your book was deleted successfully from the cart.";
            }
            else if (type.ToLower() == "course")
            {
                _cartService.RemoveFromCart(cart, Id, ItemType.Course);
                TempData["message"] = "Your course was deleted successfully from the cart.";
            }

            _cartSessionService.SetCart(cart);
            return RedirectToAction("List");
        }
    }
}

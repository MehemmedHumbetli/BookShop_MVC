using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using MiniBookShop.Models;
using MiniBookShop.Services;

namespace MiniBookShop.ViewComponents
{
    public class CartSummaryViewComponent(ICartSessionService sessionService) : ViewComponent
    {
        private readonly ICartSessionService _sessionService = sessionService;
        
        public ViewViewComponentResult Invoke()
        {
            var model = new CartSummaryViewModel()
            {
                Cart = _sessionService.GetCart()
            };
            return View(model);
        }
    }
}

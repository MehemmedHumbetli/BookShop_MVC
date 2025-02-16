using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using MiniBookShop.Application.Abstract;

namespace MiniBookShop.ViewComponents
{
    public class BookListViewComponent(IBookService bookService) : ViewComponent
    {
        private readonly IBookService _bookService = bookService;

        public ViewViewComponentResult Invoke()
        {
            var model = new BookListViewModel
            {
                Books = _bookService.GetAll()
            };
            return View(model);
        }
    }
}

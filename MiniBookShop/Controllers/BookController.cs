using Microsoft.AspNetCore.Mvc;
using MiniBookShop.Application.Abstract;
using MiniBookShop.Application.Concrete;
using MiniBookShop.Domain.Entities;

namespace MiniBookShop.Controllers
{
    public class BookController(IBookService bookService) : Controller
    {
        private readonly IBookService _bookService = bookService;

        public IActionResult Index()
        {
            var books = _bookService.GetAll();
            return View(books);
        }

        [HttpGet]
        public IActionResult Add()
        {
            var model = new BookViewModel();
            model.Book = new Book();
            return View(model);
        }

        [HttpPost]
        public IActionResult Add(BookViewModel model)
        {
            _bookService.Add(model.Book);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete()
        {
            var model = new BookViewModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            _bookService.Delete(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var book = _bookService.GetById(id);
            if (book == null)
            {
                return NotFound();
            }

            var model = new BookViewModel
            {
                Book = book
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult Update(BookViewModel model)
        {
            var bookInDb = _bookService.GetById(model.Book.Id);
            if (bookInDb == null)
            {
                return NotFound();
            }

            bookInDb.Name = model.Book.Name;
            bookInDb.Author = model.Book.Author;
            bookInDb.Genre = model.Book.Genre;
            bookInDb.Pages = model.Book.Pages;
            bookInDb.ReadCount = model.Book.ReadCount;
            bookInDb.Decription = model.Book.Decription;
            bookInDb.ImagePath = model.Book.ImagePath;
            bookInDb.Price = model.Book.Price;

            _bookService.Update(bookInDb);
            return RedirectToAction("Index");
        }
    }
}

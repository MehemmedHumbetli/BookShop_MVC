using MiniBookShop.Application.Abstract;
using MiniBookShop.DataAccess.Abstract;
using MiniBookShop.DataAccess.Implementation;
using MiniBookShop.Domain.Entities;

namespace MiniBookShop.Application.Concrete
{
    public class BookService(IBookDal bookDal) : IBookService
    {
        private readonly IBookDal _bookDal = bookDal;

        public void Add(Book book)
        {
            _bookDal.Add(book);
        }

        public void Delete(int bookId)
        {
            var book = _bookDal.Get(p => p.Id == bookId);
            _bookDal.Delete(book);
        }

        public List<Book> GetAll()
        {
            return _bookDal.GetList();
        }

        public Book GetById(int id)
        {
            return _bookDal.Get(p => p.Id == id);
        }

        public void Update(Book book)
        {
            _bookDal.Update(book);
        }
    }
}

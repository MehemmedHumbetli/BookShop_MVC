using MiniBookShop.Domain.Entities;

namespace MiniBookShop.Application.Abstract
{
    public interface IBookService
    {
        public List<Book> GetAll();
        Book GetById(int id);
        void Add(Book book);
        void Update(Book book);
        void Delete(int bookId);
    }
}

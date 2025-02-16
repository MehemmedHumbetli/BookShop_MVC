using MiniBookShop.Domain.Entities;

namespace MiniBookShop.Application.Abstract
{
    public interface IUserService
    {
        public List<User> GetAll();
        User GetById(int id);
        void Add(User user);
        void Update(User user);
        void Delete(int userId);
    }
}

using MiniBookShop.DataAccess.Abstract;
using MiniBookShop.DataAccess.Context;
using MiniBookShop.Domain.Entities;
using MiniBookShop.Repository.DataAccess.EntityFrameworkAccess;

namespace MiniBookShop.DataAccess.Implementation
{
    public class EFBookDal(ShopDbContext shopDbContext) : EFEntityRepositoryBase<Book, ShopDbContext>(shopDbContext), IBookDal
    {
    }
}

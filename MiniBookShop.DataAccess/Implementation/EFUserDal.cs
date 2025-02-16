using MiniBookShop.DataAccess.Abstract;
using MiniBookShop.DataAccess.Context;
using MiniBookShop.Domain.Entities;
using MiniBookShop.Repository.DataAccess.EntityFrameworkAccess;

namespace MiniBookShop.DataAccess.Implementation
{
    public class EFUserDal(ShopDbContext shopDbContext) : EFEntityRepositoryBase<User,ShopDbContext>(shopDbContext), IUserDal
    {

    }
}

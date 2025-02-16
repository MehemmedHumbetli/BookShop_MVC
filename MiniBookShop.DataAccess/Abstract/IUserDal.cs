﻿using MiniBookShop.Domain.Entities;
using MiniBookShop.Repository.DataAccess;

namespace MiniBookShop.DataAccess.Abstract
{
    public interface IUserDal : IEntityRepository<User>
    {

    }
}

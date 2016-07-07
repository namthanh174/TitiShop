using System;

namespace TitiShop.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        TitiShopDbContext Init();
    }
}
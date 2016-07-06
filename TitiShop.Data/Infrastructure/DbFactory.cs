namespace TitiShop.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private TitiShopDbContext dbContext;

        public TitiShopDbContext Init()
        {
            return dbContext ?? (dbContext = new TitiShopDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
            {
                dbContext.Dispose();
            }
        }
    }
}
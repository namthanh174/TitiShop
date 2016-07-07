using TitiShop.Data.Infrastructure;
using TitiShop.Model.Models;

namespace TitiShop.Data.Repositories
{
    public interface ISupportOnlineRepository
    {
    }

    public class SupportOnlineRepository : RepositoryBase<Page>, ISupportOnlineRepository
    {
        public SupportOnlineRepository(DbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
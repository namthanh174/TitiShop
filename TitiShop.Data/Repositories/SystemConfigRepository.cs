using TitiShop.Data.Infrastructure;
using TitiShop.Model.Models;

namespace TitiShop.Data.Repositories
{
    public interface ISystemConfigRepository
    {
    }

    public class SystemConfigRepository : RepositoryBase<Page>, ISystemConfigRepository
    {
        public SystemConfigRepository(DbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
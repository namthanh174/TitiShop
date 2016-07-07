using TitiShop.Data.Infrastructure;
using TitiShop.Model.Models;

namespace TitiShop.Data.Repositories
{
    public interface IVisitorStatisticRepository
    {
    }

    public class VisitorStatisticRepository : RepositoryBase<Page>, IVisitorStatisticRepository
    {
        public VisitorStatisticRepository(DbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
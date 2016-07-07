using TitiShop.Data.Infrastructure;
using TitiShop.Model.Models;

namespace TitiShop.Data.Repositories
{
    public interface IOrderRepository
    {
    }

    public class OrderRepository : RepositoryBase<Order>, IOrderRepository
    {
        public OrderRepository(DbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
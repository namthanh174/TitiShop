using TitiShop.Data.Infrastructure;
using TitiShop.Model.Models;

namespace TitiShop.Data.Repositories
{
    public interface IProductTagRepository
    {
    }

    public class ProductTagRepository : RepositoryBase<Page>, IProductTagRepository
    {
        public ProductTagRepository(DbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
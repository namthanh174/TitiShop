using TitiShop.Data.Infrastructure;
using TitiShop.Model.Models;

namespace TitiShop.Data.Repositories
{
    public interface IProductRepository
    {
    }

    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(DbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
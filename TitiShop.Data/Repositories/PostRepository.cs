using TitiShop.Data.Infrastructure;
using TitiShop.Model.Models;

namespace TitiShop.Data.Repositories
{
    public interface IPostRepository
    {
    }

    public class PostRepository : RepositoryBase<Page>, IPostRepository
    {
        public PostRepository(DbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
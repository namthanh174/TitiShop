using TitiShop.Data.Infrastructure;
using TitiShop.Model.Models;

namespace TitiShop.Data.Repositories
{
    public interface IPostTagRepository
    {
    }

    public class PostTagRepository : RepositoryBase<Page>, IPostTagRepository
    {
        public PostTagRepository(DbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
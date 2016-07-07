using TitiShop.Data.Infrastructure;
using TitiShop.Model.Models;

namespace TitiShop.Data.Repositories
{
    public interface ITagRepository
    {
    }

    public class TagRepository : RepositoryBase<Page>, ITagRepository
    {
        public TagRepository(DbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
using TitiShop.Data.Infrastructure;
using TitiShop.Model.Models;

namespace TitiShop.Data.Repositories
{
    public interface ISlideRepository
    {
    }

    public class SlideRepository : RepositoryBase<Page>, ISlideRepository
    {
        public SlideRepository(DbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
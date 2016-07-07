using TitiShop.Data.Infrastructure;
using TitiShop.Model.Models;

namespace TitiShop.Data.Repositories
{
    public interface IFooterRepository
    {
    }

    public class FooterRepository : RepositoryBase<Footer>, IFooterRepository
    {
        public FooterRepository(DbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
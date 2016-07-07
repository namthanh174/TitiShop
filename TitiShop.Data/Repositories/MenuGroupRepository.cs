using TitiShop.Data.Infrastructure;
using TitiShop.Model.Models;

namespace TitiShop.Data.Repositories
{
    public interface IMenuGroupRepository
    {
    }

    public class MenuGroupRepository : RepositoryBase<MenuGroup>, IMenuGroupRepository
    {
        public MenuGroupRepository(DbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
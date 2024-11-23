using LMS.Data;
using System.Collections.Generic;

namespace LMS.Repository
{
    public interface IPageLinkRepository : IRepository<PageLink>, IAddCustom<PageLinkViewModel>
    {
        List<SideMenuCategory> GetSideMenuByUser(string userName);
    }
}

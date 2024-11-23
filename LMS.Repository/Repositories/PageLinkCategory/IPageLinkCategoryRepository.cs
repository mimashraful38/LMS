using LMS.Data;
using System.Collections.Generic;

namespace LMS.Repository
{
    public interface IPageLinkCategoryRepository : IRepository<PageLinkCategory>
    {
        ICollection<PageLinkCategoryViewModel> GetCategoryWithLink();

        PageLink LinkRoleUpdate(int linkId, string roleId);
        ICollection<DDL> ddl();
    }
}

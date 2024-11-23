using System;
using System.Threading.Tasks;

namespace LMS.Repository
{
    public interface IUnitOfWork : IDisposable
    {
        IRegistrationRepository Registrations { get; }
        IPageLinkRepository PageLinks { get; }
        IPageLinkCategoryRepository PageLinkCategories { get; }
        IPageLinkAssignRepository PageLinkAssigns { get; }

        int SaveChanges();
        Task<int> SaveChangesAsync();
    }
}

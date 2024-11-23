using AutoMapper;
using LMS.Data;
using System.Threading.Tasks;

namespace LMS.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        public UnitOfWork(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
            PageLinks = new PageLinkRepository(_context);
            PageLinkCategories = new PageLinkCategoryRepository(_context);
            PageLinkAssigns = new PageLinkAssignRepository(_context);
            Registrations = new RegistrationRepository(_context);


        }

        public IPageLinkRepository PageLinks { get; private set; }
        public IPageLinkCategoryRepository PageLinkCategories { get; private set; }
        public IPageLinkAssignRepository PageLinkAssigns { get; private set; }
        public IRegistrationRepository Registrations { get; private set; }



        public int SaveChanges()
        {
            return _context.SaveChanges();
        }
        public Task<int> SaveChangesAsync()
        {
            return _context.SaveChangesAsync();
        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}

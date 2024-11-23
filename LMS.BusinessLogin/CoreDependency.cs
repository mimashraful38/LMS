using AutoMapper;
using LMS.Repository;

namespace LMS.BusinessLogin
{
    public class CoreDependency
    {
        protected readonly IUnitOfWork _db;
        protected readonly IMapper _mapper;

        public CoreDependency(IUnitOfWork db, IMapper mapper)
        {
            _mapper = mapper;
            _db = db;
        }
    }
}
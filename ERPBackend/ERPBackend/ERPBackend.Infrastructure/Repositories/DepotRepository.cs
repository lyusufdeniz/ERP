using ERPBackend.Domain.Entities;
using ERPBackend.Domain.Repositories;
using ERPBackend.Infrastructure.Context;
using GenericRepository;

namespace ERPBackend.Infrastructure.Repositories
{
    internal sealed class DepotRepository : Repository<Depot, ApplicationDbContext>, IDepotRepository
    {
        public DepotRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}

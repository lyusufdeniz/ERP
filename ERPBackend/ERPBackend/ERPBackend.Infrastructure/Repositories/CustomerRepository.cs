using ERPBackend.Domain.Entities;
using ERPBackend.Domain.Repositories;
using ERPBackend.Infrastructure.Context;
using GenericRepository;

namespace ERPBackend.Infrastructure.Repositories
{
    internal class CustomerRepository : Repository<Customer, ApplicationDbContext>, ICustomerRepository
    {
        public CustomerRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}

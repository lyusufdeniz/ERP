using ERPBackend.Domain.Entities;
using ERPBackend.Domain.Repositories;
using ERPBackend.Infrastructure.Context;
using GenericRepository;

namespace ERPBackend.Infrastructure.Repositories;

internal sealed class OrderDetailRepository : Repository<OrderDetail, ApplicationDbContext>, IOrderDetailRepository
{
    public OrderDetailRepository(ApplicationDbContext context) : base(context)
    {
    }
}
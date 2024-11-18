
using ERPBackend.Domain.Entities;
using ERPBackend.Domain.Repositories;
using MediatR;
using Microsoft.EntityFrameworkCore;
using TS.Result;

namespace ERPBackend.Application.Features.Customers.GetAllCustomer
{
    internal sealed class GetAllCustomerQueryHandler(ICustomerRepository repository) : IRequestHandler<GetAllCustomerQuery, Result<List<Customer>>>
{
        public async Task<Result<List<Customer>>> Handle(GetAllCustomerQuery request, CancellationToken cancellationToken)
        {
          return await repository.GetAll().OrderBy(p => p.Name).ToListAsync();
        }
    }
}

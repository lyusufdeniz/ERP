using ERPBackend.Domain.Entities.Customer;
using MediatR;
using System.Runtime.CompilerServices;
using TS.Result;

namespace ERPBackend.Application.Features.Customers.UpdateCustomer
{
    public sealed record UpdateCustomerCommand(Guid Id,string Name, string TaxDepartment, string TaxNumber, string City, string Town, string FullAddress, bool State) :IRequest<Result<string>>;
   
}

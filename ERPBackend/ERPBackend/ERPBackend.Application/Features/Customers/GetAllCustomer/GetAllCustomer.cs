
using ERPBackend.Domain.Entities.Customer;
using MediatR;
using System.Net.Http.Headers;
using TS.Result;

namespace ERPBackend.Application.Features.Customers.GetAllCustomer
{
    public sealed record GetAllCustomerQuery():IRequest<Result<List<Customer>>>;
}

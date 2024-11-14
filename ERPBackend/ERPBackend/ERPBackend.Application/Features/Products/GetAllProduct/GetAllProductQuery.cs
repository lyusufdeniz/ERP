using MediatR;
using ERPBackend.Domain.Entities;
using TS.Result;

namespace ERPBackend.Application.Features.Products.GetAllProduct
{
    public sealed record GetAllProductQuery:IRequest<Result<List<Product>>>
    {
    }
}

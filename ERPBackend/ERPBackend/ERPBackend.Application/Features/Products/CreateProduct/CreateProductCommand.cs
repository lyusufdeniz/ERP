using MediatR;
using TS.Result;

namespace ERPBackend.Application.Features.Products.CreateProduct
{
    public sealed record CreateProductCommand(string Name,int TypeValue):IRequest<Result<string>>
    {
    }
}

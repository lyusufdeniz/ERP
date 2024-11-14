using MediatR;
using TS.Result;

namespace ERPBackend.Application.Features.Products.DeleteProductById
{
    public sealed record DeleteProductByIdCommand(Guid Id) : IRequest<Result<string>>;
}

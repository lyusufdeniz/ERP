using MediatR;
using TS.Result;

namespace ERPBackend.Application.Features.Orders.DeleteOrderById;
public sealed record DeleteOrderByIdCommand(
    Guid Id) : IRequest<Result<string>>;

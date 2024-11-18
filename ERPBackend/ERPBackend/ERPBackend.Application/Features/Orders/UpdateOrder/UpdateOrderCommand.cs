using ERPBackend.Domain.Dtos;
using MediatR;
using TS.Result;

namespace ERPBackend.Application.Features.Orders.UpdateOrder;
public sealed record UpdateOrderCommand(
    Guid Id,
    Guid CustomerId,
    DateOnly Date,
    DateOnly DeliveryDate,
    List<OrderDetailDto> Details) : IRequest<Result<string>>;

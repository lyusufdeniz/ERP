using ERPBackend.Domain.Entities;
using MediatR;
using TS.Result;

namespace ERPBackend.Application.Features.Orders.GetAllOrder;
public sealed record GetAllOrderQuery() : IRequest<Result<List<Order>>>;

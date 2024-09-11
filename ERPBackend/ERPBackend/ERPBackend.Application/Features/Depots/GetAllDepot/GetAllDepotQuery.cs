using ERPBackend.Domain.Entities;
using MediatR;
using TS.Result;

namespace ERPBackend.Application.Features.Depots.GetAllDepot
{
    public sealed record GetAllDepotQuery():IRequest<Result<List<Depot>>>
    {
    }
}

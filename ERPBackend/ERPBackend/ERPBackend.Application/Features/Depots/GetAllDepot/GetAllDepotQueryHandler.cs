using ERPBackend.Domain.Entities;
using ERPBackend.Domain.Repositories;
using MediatR;
using Microsoft.EntityFrameworkCore;
using TS.Result;

namespace ERPBackend.Application.Features.Depots.GetAllDepot
{
    internal sealed class GetAllDepotQueryHandler(IDepotRepository _depotRepository) : IRequestHandler<GetAllDepotQuery, Result<List<Depot>>>
    {
        public async Task<Result<List<Depot>>> Handle(GetAllDepotQuery request, CancellationToken cancellationToken)
        {
            List<Depot> depots = await _depotRepository.GetAll().OrderBy(p=>p.Name).ToListAsync(cancellationToken);

            return depots;
            

        }
    }
}

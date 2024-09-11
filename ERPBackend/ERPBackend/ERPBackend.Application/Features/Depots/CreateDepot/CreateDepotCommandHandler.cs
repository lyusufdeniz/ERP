using AutoMapper;
using ERPBackend.Domain.Entities;
using ERPBackend.Domain.Repositories;
using GenericRepository;
using MediatR;
using TS.Result;

namespace ERPBackend.Application.Features.Depots.CreateDepot
{
    internal sealed class CreateDepotCommandHandler(IDepotRepository depotRepository, IUnitOfWork unitOfWork, IMapper mapper) : IRequestHandler<CreateDepotCommand, Result<string>>
    {
        public async Task<Result<string>> Handle(CreateDepotCommand request, CancellationToken cancellationToken)
        {
          Depot depot=mapper.Map<Depot>(request);
            await depotRepository.AddAsync(depot,cancellationToken);
            await unitOfWork.SaveChangesAsync(cancellationToken);
            return "Depo Başarıyla Kaydedildi";
        }
    }
}

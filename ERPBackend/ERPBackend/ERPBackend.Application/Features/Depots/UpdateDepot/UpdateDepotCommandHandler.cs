using AutoMapper;
using ERPBackend.Domain.Repositories;
using GenericRepository;
using MediatR;
using TS.Result;

namespace ERPBackend.Application.Features.Depots.UpdateDepot
{
    internal sealed class UpdateDepotCommandHandler(IDepotRepository depotRepository,IUnitOfWork unitOfWork,IMapper mapper) : IRequestHandler<UpdateDepotCommand, Result<string>>
    {
        public async Task<Result<string>> Handle(UpdateDepotCommand request, CancellationToken cancellationToken)
        {
            var depot = await depotRepository.GetByExpressionWithTrackingAsync(p => p.Id == request.Id);
            if (depot == null)
                return Result<string>.Failure("Böyle bir depo yok");
            mapper.Map(request, depot);
           await unitOfWork.SaveChangesAsync(cancellationToken);
            return "Depo Güncellendi";
        }
    }
}

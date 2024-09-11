using ERPBackend.Domain.Repositories;
using GenericRepository;
using MediatR;
using TS.Result;

namespace ERPBackend.Application.Features.Depots.DeleteDepotById
{
    internal sealed class DeleteDepotByIdCommandHandler(IDepotRepository depotRepository,IUnitOfWork unitOfWork) : IRequestHandler<DeleteDepotByIdCommand, Result<string>>
    {
        public  async Task<Result<string>> Handle(DeleteDepotByIdCommand request, CancellationToken cancellationToken)
        {
            var depot = await depotRepository.GetByExpressionAsync(p=>p.Id==request.Id);
            if(depot == null) 
                return Result<string>.Failure("Böyle bir depo yok");
            depotRepository.Delete(depot);
            await unitOfWork.SaveChangesAsync(cancellationToken);
            return "Depo Silindi";

        }
    }
}

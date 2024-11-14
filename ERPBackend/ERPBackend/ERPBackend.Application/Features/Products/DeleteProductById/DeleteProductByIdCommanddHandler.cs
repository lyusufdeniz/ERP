using ERPBackend.Domain.Repositories;
using GenericRepository;
using MediatR;
using TS.Result;

namespace ERPBackend.Application.Features.Products.DeleteProductById
{
    internal sealed class DeleteProductByIdCommanddHandler(IProductRepository pRepository, IUnitOfWork unit) : IRequestHandler<DeleteProductByIdCommand, Result<string>>
    {
        public async Task<Result<string>> Handle(DeleteProductByIdCommand request, CancellationToken cancellationToken)
        {
            var p = await pRepository.GetByExpressionAsync(p => p.Id == request.Id, cancellationToken);
            if (p == null)
            {
                return Result<string>.Failure("kayıt yok");
            }
            pRepository.Delete(p);
            await unit.SaveChangesAsync(cancellationToken);
            return "Ürün Silindi";

        }
    }
}

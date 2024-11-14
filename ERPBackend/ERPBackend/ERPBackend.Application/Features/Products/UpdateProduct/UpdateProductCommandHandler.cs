using AutoMapper;
using ERPBackend.Domain.Entities;
using ERPBackend.Domain.Repositories;
using GenericRepository;
using MediatR;
using TS.Result;

namespace ERPBackend.Application.Features.Products.UpdateProduct
{
    internal sealed class UpdateProductCommandHandler(IProductRepository productRepository, IUnitOfWork unitOfWork, IMapper mapper) : IRequestHandler<UpdateProductCommand, Result<string>>
    {
        public async Task<Result<string>> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            var p = await productRepository.GetByExpressionWithTrackingAsync(p => p.Id == request.Id, cancellationToken);
            if (p == null)
            {
                return Result<string>.Failure("kayıt yok");
            }
            bool isNameExits = await productRepository.AnyAsync(p => p.Name == request.Name, cancellationToken);
            if (p.Name != request.Name)
            {
                if (isNameExits)
                {
                    return Result<string>.Failure("Ürün Kayıtlı");

                }
            }

            mapper.Map(request, p);

            await unitOfWork.SaveChangesAsync(cancellationToken);
            return "Ürün Güncellendi";
        }
    }

}

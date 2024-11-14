using AutoMapper;
using ERPBackend.Domain.Entities;
using ERPBackend.Domain.Repositories;
using GenericRepository;
using MediatR;
using TS.Result;

namespace ERPBackend.Application.Features.Products.CreateProduct
{
    internal sealed class CreateProductCommandHandler(IProductRepository product,IMapper mapper,IUnitOfWork unit) : IRequestHandler<CreateProductCommand, Result<string>>
    {
        public  async Task<Result<string>> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            bool isNameExits = await product.AnyAsync(p => p.Name == request.Name, cancellationToken);
            if (isNameExits)
            {
                return Result<string>.Failure("Ürün Kayıtlı");

            }
            Product p=mapper.Map<Product>(request);
            await product.AddAsync(p);
            await unit.SaveChangesAsync(cancellationToken);
            return "Ürün Kaydedildi";

        }
    }
}

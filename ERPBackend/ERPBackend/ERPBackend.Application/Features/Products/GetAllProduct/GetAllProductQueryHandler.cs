using MediatR;
using ERPBackend.Domain.Entities;
using TS.Result;
using ERPBackend.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace ERPBackend.Application.Features.Products.GetAllProduct
{
    internal sealed class GetAllProductQueryHandler(IProductRepository productRepository) : IRequestHandler<GetAllProductQuery, Result<List<Product>>>
    {
        public async Task<Result<List<Product>>> Handle(GetAllProductQuery request, CancellationToken cancellationToken)
        {
           List<Product> products = await productRepository.GetAll().OrderBy(p=>p.Name).ToListAsync(cancellationToken);
            return products;
        }
    }
}

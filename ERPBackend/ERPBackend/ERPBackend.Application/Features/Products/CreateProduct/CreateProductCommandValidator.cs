using ERPBackend.Application.Features.Customers.UpdateCustomer;
using ERPBackend.Application.Features.Products.UpdateProduct;
using FluentValidation;

namespace ERPBackend.Application.Features.Products.CreateProduct
{

    public sealed class CreateProductCommandValidator : AbstractValidator<CreateProductCommand>
    {
        public CreateProductCommandValidator()
        {
            RuleFor(p => p.TypeValue).GreaterThan(0);
        }
    }
}

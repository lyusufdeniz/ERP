using ERPBackend.Application.Features.Customers.UpdateCustomer;
using ERPBackend.Application.Features.Products.UpdateProduct;
using FluentValidation;

namespace ERPBackend.Application.Features.Products.CreateProduct
{

    public sealed class UpdateProductCommandValidator : AbstractValidator<UpdateProductCommand>
    {
        public UpdateProductCommandValidator()
        {
            RuleFor(p => p.TypeValue).GreaterThan(0);
        }
    }
}

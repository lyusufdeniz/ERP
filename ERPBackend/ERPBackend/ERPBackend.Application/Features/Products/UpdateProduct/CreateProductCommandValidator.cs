using ERPBackend.Application.Features.Customers.UpdateCustomer;
using FluentValidation;

namespace ERPBackend.Application.Features.Products.UpdateProduct
{

    public sealed class UpdateProductCommandValidator : AbstractValidator<UpdateProductCommand>
    {
        public UpdateProductCommandValidator()
        {
            RuleFor(p => p.TypeValue).GreaterThan(0);
        }
    }
}

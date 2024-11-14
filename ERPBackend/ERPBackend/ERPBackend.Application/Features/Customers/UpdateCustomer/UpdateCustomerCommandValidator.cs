using ERPBackend.Application.Features.Customers.UpdateCustomer;
using FluentValidation;

public sealed class UpdateCustomerCommandValidator : AbstractValidator<UpdateCustomerCommand>
{
    public UpdateCustomerCommandValidator()
    {
        RuleFor(p=>p.TaxNumber).MinimumLength(10).MaximumLength(11);
    }
}

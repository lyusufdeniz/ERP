using ERPBackend.Application.Features.Customers.CreateCustomer;
using FluentValidation;

public sealed class CreateCustomerCommandValidator : AbstractValidator<CreateCustomerCommand>
{
    public CreateCustomerCommandValidator()
    {
        RuleFor(p=>p.Name).MinimumLength(3).MaximumLength(50);
        RuleFor(p=>p.TaxNumber).MaximumLength(11).MinimumLength(10);
    }

}
using AutoMapper;
using ERPBackend.Application.Features.Customers.CreateCustomer;
using ERPBackend.Domain.Entities.Customer;
using ERPBackend.Domain.Repositories;
using GenericRepository;
using MediatR;
using TS.Result;

internal sealed class CreateCustomerCommandHandler(ICustomerRepository customerRepository, IUnitOfWork unitOfWork, IMapper mapper) : IRequestHandler<CreateCustomerCommand, Result<string>>
{
    public async Task<Result<string>> Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
    {
        bool istaxNumberExists = await customerRepository.AnyAsync(p => p.TaxNumber == request.TaxNumber);
        if (istaxNumberExists)
        {
            return Result<string>.Failure("Vergi Numarasına Ait Müşteri var");

        }
        Customer customer = mapper.Map<Customer>(request);
      await  customerRepository.AddAsync(customer,cancellationToken);
        await unitOfWork.SaveChangesAsync(cancellationToken);
        return "Müşteri Kaydı Başarılı";
    }
}

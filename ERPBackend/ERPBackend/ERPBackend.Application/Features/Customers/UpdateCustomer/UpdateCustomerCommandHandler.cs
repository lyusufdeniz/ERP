using AutoMapper;
using ERPBackend.Application.Features.Customers.UpdateCustomer;
using ERPBackend.Domain.Repositories;
using GenericRepository;
using MediatR;
using TS.Result;

internal sealed class UpdateCustomerCommandHandler(ICustomerRepository customerRepository, IUnitOfWork unitOfWork,IMapper mapper) : IRequestHandler<UpdateCustomerCommand, Result<string>>
{
    public  async Task<Result<string>> Handle(UpdateCustomerCommand request, CancellationToken cancellationToken)
    {
        var customer = await customerRepository.GetByExpressionWithTrackingAsync(p => p.Id == request.Id, cancellationToken);
        if (customer == null)
        {
            return Result<string>.Failure("kayıt yok");
        }
        if (customer.TaxNumber != request.TaxNumber)
        {
            bool istaxNumberExists = await customerRepository.AnyAsync(p => p.TaxNumber == request.TaxNumber);
            if (istaxNumberExists)
            {
                return Result<string>.Failure("Vergi Numarasına Ait Müşteri var");

            }
        }
        mapper.Map(request,customer);
        
        await unitOfWork.SaveChangesAsync(cancellationToken);
        return "Müşteri Güncellendi";
    }
}

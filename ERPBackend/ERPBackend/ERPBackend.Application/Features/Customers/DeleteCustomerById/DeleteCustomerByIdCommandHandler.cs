using ERPBackend.Domain.Repositories;
using GenericRepository;
using MediatR;
using TS.Result;

namespace ERPBackend.Application.Features.Customers.DeleteCustomerById
{
    internal sealed class DeleteCustomerByIdCommandHandler(ICustomerRepository customerRepository,IUnitOfWork unit) : IRequestHandler<DeleteCustomerByIdCommand, Result<string>>
    {
        public async Task<Result<string>> Handle(DeleteCustomerByIdCommand request, CancellationToken cancellationToken)
        {
            var customer = await customerRepository.GetByExpressionAsync(p => p.Id==request.Id,cancellationToken);
            if(customer == null)
            {
                return Result<string>.Failure("kayıt yok");
            }
            customerRepository.Delete(customer);
            await unit.SaveChangesAsync(cancellationToken);
            return "Müşteri Silindi";

        }
    }
}

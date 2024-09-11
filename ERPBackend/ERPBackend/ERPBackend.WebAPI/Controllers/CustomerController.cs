using ERPBackend.Application.Features.Customers.CreateCustomer;
using ERPBackend.Application.Features.Customers.DeleteCustomerById;
using ERPBackend.Application.Features.Customers.GetAllCustomer;
using ERPBackend.Application.Features.Customers.UpdateCustomer;
using ERPBackend.WebAPI.Abstractions;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ERPBackend.WebAPI.Controllers
{

    public class CustomerController : ApiController
    {
        public CustomerController(IMediator mediator) : base(mediator)
        {
        }
        [HttpPost]
        public async Task<IActionResult> GetAll(GetAllCustomerQuery request,CancellationToken cancellationToken)
        {
            var response= await _mediator.Send(request,cancellationToken);
            return StatusCode(response.StatusCode, response);


        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateCustomerCommand request, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return StatusCode(response.StatusCode, response);


        }
        [HttpPost]
        public async Task<IActionResult> Delete(DeleteCustomerByIdCommand request, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return StatusCode(response.StatusCode, response);


        }
        [HttpPost]
        public async Task<IActionResult> Update(UpdateCustomerCommand request, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return StatusCode(response.StatusCode, response);


        }
    }
}

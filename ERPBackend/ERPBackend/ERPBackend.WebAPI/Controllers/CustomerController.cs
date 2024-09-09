using ERPBackend.Application.Features.Customers.GetAllCustomer;
using ERPBackend.WebAPI.Abstractions;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ERPBackend.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
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
    }
}

using ERPBackend.Application.Features.Depots.CreateDepot;
using ERPBackend.Application.Features.Depots.DeleteDepotById;
using ERPBackend.Application.Features.Depots.GetAllDepot;
using ERPBackend.Application.Features.Depots.UpdateDepot;
using ERPBackend.WebAPI.Abstractions;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ERPBackend.WebAPI.Controllers
{

    public class DepotController : ApiController
    {
        public DepotController(IMediator mediator) : base(mediator)
        {
        }
        [HttpPost]
        public async Task<IActionResult> GetAll(GetAllDepotQuery request, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return StatusCode(response.StatusCode, response);


        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateDepotCommand request, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return StatusCode(response.StatusCode, response);


        }
        [HttpPost]
        public async Task<IActionResult> Delete(DeleteDepotByIdCommand request, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return StatusCode(response.StatusCode, response);


        }
        [HttpPost]
        public async Task<IActionResult> Update(UpdateDepotCommand request, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return StatusCode(response.StatusCode, response);


        }
    }
}

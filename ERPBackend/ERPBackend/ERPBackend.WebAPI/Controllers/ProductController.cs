using ERPBackend.Application.Features.Products.CreateProduct;
using ERPBackend.Application.Features.Products.DeleteProductById;
using ERPBackend.Application.Features.Products.GetAllProduct;
using ERPBackend.Application.Features.Products.UpdateProduct;
using ERPBackend.WebAPI.Abstractions;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ERPBackend.WebAPI.Controllers
{

    public class ProductController : ApiController
    {
        public ProductController(IMediator mediator) : base(mediator)
        {
        }
        [HttpPost]
        public async Task<IActionResult> GetAll(GetAllProductQuery request, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return StatusCode(response.StatusCode, response);


        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return StatusCode(response.StatusCode, response);


        }
        [HttpPost]
        public async Task<IActionResult> Delete(DeleteProductByIdCommand request, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return StatusCode(response.StatusCode, response);


        }
        [HttpPost]
        public async Task<IActionResult> Update(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return StatusCode(response.StatusCode, response);


        }
    }
}

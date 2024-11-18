using ERPBackend.Application.Features.Recipes.CreateRecipe;
using ERPBackend.Application.Features.Recipes.DeleteRecipeById;
using ERPBackend.Application.Features.Recipes.GetAllRecipe;
using ERPBackend.WebAPI.Abstractions;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ERPBackend.WebAPI.Controllers
{

    public class RecipesController : ApiController
    {
        public RecipesController(IMediator mediator) : base(mediator)
        {
        }
        [HttpPost]
        public async Task<IActionResult> GetAll(GetAllRecipeQuery request, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return StatusCode(response.StatusCode, response);


        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateRecipeCommand request, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return StatusCode(response.StatusCode, response);


        }
        [HttpPost]
        public async Task<IActionResult> Delete(DeleteRecipeByIdCommand request, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return StatusCode(response.StatusCode, response);


        }


    }
}

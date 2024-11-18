using ERPBackend.Application.Features.RecipeDetails.CreateRecipeDetail;
using ERPBackend.Application.Features.RecipeDetails.DeleteRecipeDetailById;
using ERPBackend.Application.Features.RecipeDetails.GetByIdRecipeWithDetails;
using ERPBackend.Application.Features.RecipeDetails.UpdateRecipeDetail;
using ERPBackend.Application.Features.Recipes.CreateRecipe;
using ERPBackend.Application.Features.Recipes.DeleteRecipeById;
using ERPBackend.Application.Features.Recipes.GetAllRecipe;
using ERPBackend.WebAPI.Abstractions;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ERPBackend.WebAPI.Controllers
{

    public class RecipeDetailsController : ApiController
    {
        public RecipeDetailsController(IMediator mediator) : base(mediator)
        {
        }
        [HttpPost]
        public async Task<IActionResult> GetById(GetRecipeByIdWithDetailsQuery request, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return StatusCode(response.StatusCode, response);


        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateRecipeDetailCommand request, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return StatusCode(response.StatusCode, response);


        }
        [HttpPost]
        public async Task<IActionResult> Delete(DeleteRecipeDetailByIdCommand request, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return StatusCode(response.StatusCode, response);


        }
        [HttpPost]
        public async Task<IActionResult> Update(UpdateRecipeDetailCommand request, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return StatusCode(response.StatusCode, response);


        }

    }
}

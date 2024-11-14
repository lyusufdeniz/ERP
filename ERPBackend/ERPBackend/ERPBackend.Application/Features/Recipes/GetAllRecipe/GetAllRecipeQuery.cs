using ERPBackend.Domain.Entities;
using MediatR;
using TS.Result;

namespace ERPBackend.Application.Features.Recipes.GetAllRecipe
{
    public sealed record  GetAllRecipeQuery():IRequest<Result<List<Recipe>>>
    {
    }

}

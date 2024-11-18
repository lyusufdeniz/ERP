using ERPBackend.Domain.Entities;
using MediatR;
using TS.Result;

namespace ERPBackend.Application.Features.RecipeDetails.GetByIdRecipeWithDetails
{
    public sealed record GetRecipeByIdWithDetailsQuery(
   Guid RecipeId) : IRequest<Result<Recipe>>;

}

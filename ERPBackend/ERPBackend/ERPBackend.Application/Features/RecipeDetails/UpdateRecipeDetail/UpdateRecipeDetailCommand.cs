using MediatR;
using TS.Result;

namespace ERPBackend.Application.Features.RecipeDetails.UpdateRecipeDetail
{
    public sealed record UpdateRecipeDetailCommand(
       Guid Id,
       Guid ProductId,
       decimal Quantity) : IRequest<Result<string>>;
}

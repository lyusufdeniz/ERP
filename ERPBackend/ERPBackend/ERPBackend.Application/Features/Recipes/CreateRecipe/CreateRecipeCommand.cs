using AutoMapper;
using ERPBackend.Domain.Dtos;
using MediatR;
using System.Security.Cryptography.X509Certificates;
using TS.Result;

namespace ERPBackend.Application.Features.Recipes.CreateRecipe
{

    public sealed record CreateRecipeCommand(Guid ProductId,List<RecipeDetailDto> RecipeDetails) : IRequest<Result<string>>
    {

    }
}

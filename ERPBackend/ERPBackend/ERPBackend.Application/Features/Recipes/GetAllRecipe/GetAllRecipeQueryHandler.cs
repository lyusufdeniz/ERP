using ERPBackend.Domain.Entities;
using ERPBackend.Domain.Repositories;
using MediatR;
using Microsoft.EntityFrameworkCore;
using TS.Result;

namespace ERPBackend.Application.Features.Recipes.GetAllRecipe
{
    internal sealed class GetAllRecipeQueryHandler(IRecipeRepository recipeRepository) : IRequestHandler<GetAllRecipeQuery, Result<List<Recipe>>>
    {
        public async Task<Result<List<Recipe>>> Handle(GetAllRecipeQuery request, CancellationToken cancellationToken)
        {
            List<Recipe> result = await recipeRepository.GetAll().
                Include(p=>p.Product).
                OrderBy(p=>p.Product!.Name).
                ToListAsync();
            return result;
        }
    }

}

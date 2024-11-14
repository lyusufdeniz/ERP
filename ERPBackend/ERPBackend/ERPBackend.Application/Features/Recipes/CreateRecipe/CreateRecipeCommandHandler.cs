using ERPBackend.Domain.Entities;
using ERPBackend.Domain.Repositories;
using GenericRepository;
using MediatR;
using TS.Result;

namespace ERPBackend.Application.Features.Recipes.CreateRecipe
{
    internal sealed class CreateRecipeCommandHandler(IRecipeRepository recipeRepository ,IUnitOfWork unitOfWork) : IRequestHandler<CreateRecipeCommand, Result<string>>
    {
        public async Task<Result<string>> Handle(CreateRecipeCommand request, CancellationToken cancellationToken)
        {
            bool isRecipeExist = recipeRepository.Any(p => p.ProductId == request.ProductId);
            if (isRecipeExist)
            {
                return Result<string>.Failure("Bu ürün için bir reçete zaten mevcut");
            }
            Recipe recipe=new ()
            {
                ProductId = request.ProductId,
                RecipeDetails=request.RecipeDetails.Select(s=> new RecipeDetail() { ProductId=s.ProductId,Quantity=s.Quantity}).ToList(),
            };
            await recipeRepository.AddAsync(recipe);
            await unitOfWork.SaveChangesAsync(cancellationToken);
            return "kaıyt başarılı";
        }
    }
}

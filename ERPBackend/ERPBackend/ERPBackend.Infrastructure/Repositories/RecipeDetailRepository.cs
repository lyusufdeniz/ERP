using ERPBackend.Domain.Entities;
using ERPBackend.Domain.Repositories;
using ERPBackend.Infrastructure.Context;
using GenericRepository;

namespace ERPBackend.Infrastructure.Repositories
{
    internal sealed class RecipeDetailRepository : Repository<RecipeDetail, ApplicationDbContext>, IRecipeDetailRepository
    {
        public RecipeDetailRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}

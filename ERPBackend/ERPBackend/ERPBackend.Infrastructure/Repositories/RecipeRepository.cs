using ERPBackend.Domain.Entities;
using ERPBackend.Domain.Repositories;
using ERPBackend.Infrastructure.Context;
using GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPBackend.Infrastructure.Repositories
{
    internal sealed class RecipeRepository : Repository<Recipe, ApplicationDbContext>, IRecipeRepository
    {
        public RecipeRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}

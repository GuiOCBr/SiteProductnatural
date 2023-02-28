using NaturalFarma.Context;
using NaturalFarma.Models;
using NaturalFarma.Repositories.Interfaces;

namespace NaturalFarma.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext _context;

        public CategoryRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Category> Category => _context.Category;
    }
}

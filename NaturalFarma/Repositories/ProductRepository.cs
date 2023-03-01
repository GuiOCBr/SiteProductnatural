using Microsoft.EntityFrameworkCore;
using NaturalFarma.Context;
using NaturalFarma.Models;
using NaturalFarma.Repositories.Interfaces;

namespace NaturalFarma.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext _context;
        public ProductRepository(AppDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Product> Products => _context.Product.Include(c => c.Category);
        public IEnumerable<Product> ProductFavorite => _context.Product.Where(l => l.ProductFavorite).Include(c => c.Category);

        public Product GetProductById(int ProductId)
        {
           return _context.Product.FirstOrDefault(l => l.ProductId == ProductId);
        }
    }
}

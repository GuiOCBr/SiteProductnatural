using NaturalFarma.Models;

namespace NaturalFarma.Repositories.Interfaces
{
    public interface IProductRepository
    {
        IEnumerable<Product> Products { get; }

        IEnumerable<Product> ProductFavorite { get; }

        Product GetProductById(int ProductId);
    }
}

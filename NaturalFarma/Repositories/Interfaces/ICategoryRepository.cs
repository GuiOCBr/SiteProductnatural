using NaturalFarma.Models;

namespace NaturalFarma.Repositories.Interfaces
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> Category { get; }
    }
}

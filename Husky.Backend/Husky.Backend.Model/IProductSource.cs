using Husky.Backend.Model.Products;
using System.Linq;

namespace Husky.Backend.Model
{
    public interface IProductSource
    {
        IQueryable<Product> Products { get; }
        IQueryable<Nutrient> Nutrients { get; }
        IQueryable<NutrientInfo> NutrientInfoes { get; }
        IQueryable<Category> Categories { get; }
        IQueryable<Unit> Units { get; }
    }
}

using Husky.Backend.Model.Products;
using System.Linq;
using System.Threading.Tasks;

namespace Husky.Backend.Model
{
    public interface IProductSource
    {
        //Reading
        IQueryable<Product> Products { get; }
        IQueryable<Nutrient> Nutrients { get; }
        IQueryable<NutrientInfo> NutrientInfoes { get; }
        IQueryable<Category> Categories { get; }
        IQueryable<Unit> Units { get; }

        //Writing
        Task AddProduct(Product product);
    }
}

using Husky.Backend.Model.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Husky.Backend.Model
{
    public interface IDbProductSource : IProductSource
    {
        IQueryable<Product> FullProducts { get; }
        IQueryable<Nutrient> FullNutrients { get; }
        IQueryable<NutrientInfo> FullNutrientInfoes { get; }
        IQueryable<Category> FullCategories { get; }
        IQueryable<Unit> FullUnits { get; }
    }
}

using Husky.Backend.Domain.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Husky.Backend.Domain.ViewModels.Products
{
    public class ProductModel : DictionaryModel<int>
    {
        public double Protein { get; set; }
        public double Fat { get; set; }
        public double Carbon { get; set; }
        public double Kcal { get; set; }
        public double Water { get; set; }
        public double AlimentaryFiber { get; set; }
        public byte NutritionRate { get; set; }

        public UnitModel Unit { get; set; }
        public CategoryModel Category { get; set; }
        public ICollection<NutrientModel> Nutrients { get; set; }

        public ProductModel()
        {
            Nutrients = new List<NutrientModel>();
        }
    }
}

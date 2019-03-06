using System.Collections.Generic;

namespace Husky.Backend.Model.Products
{
    public class Product : Dictionary<int>
    {
        public double Protein { get; set; }
        public double Fat { get; set; }
        public double Carbon { get; set; }
        public double Kcal { get; set; }
        public double Water { get; set; }
        public double AlimentaryFiber { get; set; }
        public byte NutritionRate { get; set; }

        public int? UnitId { get; set; }
        public Unit Unit { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public virtual ICollection<Nutrient> Nutrients { get; set; }

        public Product()
        {
            Nutrients = new List<Nutrient>();
        }
    }
}

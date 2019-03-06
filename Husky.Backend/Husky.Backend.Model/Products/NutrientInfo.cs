using System.Collections.Generic;

namespace Husky.Backend.Model.Products
{
    public class NutrientInfo : Dictionary<int>
    {
        public string ShortName { get; set; }
        public double Norma { get; set; }

        public virtual ICollection<Nutrient> Nutrients { get; set; }
    }
}

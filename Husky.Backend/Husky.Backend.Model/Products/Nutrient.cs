using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Husky.Backend.Model.Products
{
    public class Nutrient
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public double AmountInProduct { get; set; }
        public double PercentageFromNorma { get; set; }

        public int NutrientInfoId { get; set; }
        public NutrientInfo NutrientInfo { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}

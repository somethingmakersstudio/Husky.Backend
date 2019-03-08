using System;
using System.Collections.Generic;
using System.Text;

namespace Husky.Backend.Domain.ViewModels.Products
{
    public class NutrientModel
    {
        public int Id { get; set; }

        public double AmountInProduct { get; set; }
        public double PercentageFromNorma { get; set; }

        public NutrientInfoModel NutrientInfo { get; set; }
    }
}

using Husky.Backend.Domain.ViewModels.Products;
using Husky.Backend.Model;
using Husky.Backend.Model.Products;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Husky.Backend.Infrastructure
{
    public class ProductContext : DbContext, IDbProductSource
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Nutrient> Nutrients { get; set; }
        public DbSet<NutrientInfo> NutrientInfoes { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Unit> Units { get; set; }

        IQueryable<Product> IProductSource.Products => Products;
        IQueryable<Nutrient> IProductSource.Nutrients => Nutrients;
        IQueryable<NutrientInfo> IProductSource.NutrientInfoes => NutrientInfoes;
        IQueryable<Category> IProductSource.Categories => Categories;
        IQueryable<Unit> IProductSource.Units => Units;

        IQueryable<Product> IDbProductSource.FullProducts => Products.Include(p => p.Nutrients).Include(p => p.Category).Include(p => p.Unit);
        IQueryable<Nutrient> IDbProductSource.FullNutrients => Nutrients.Include(n => n.NutrientInfo).Include(n => n.Product);
        IQueryable<NutrientInfo> IDbProductSource.FullNutrientInfoes => NutrientInfoes.Include(ni => ni.Nutrients);
        IQueryable<Category> IDbProductSource.FullCategories => Categories;
        IQueryable<Unit> IDbProductSource.FullUnits => Units.Include(u => u.Products);

        public ProductContext(DbContextOptions<ProductContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }
    }
}

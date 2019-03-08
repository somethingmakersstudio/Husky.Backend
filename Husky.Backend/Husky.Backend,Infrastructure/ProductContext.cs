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
    class ProductContext : DbContext, IProductSource
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

        public Task AddProduct(Product product)
        {
            throw new NotImplementedException();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //TODO: Вынести в конфиг
            optionsBuilder.UseSqlServer("Server=193.124.129.19; Database=ProductDB; User Id=********; Password=******;");
        }
    }
}

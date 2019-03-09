using Husky.Backend.Domain.ViewModels.Products;
using Husky.Backend.Model;
using Husky.Backend.Model.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Husky.Backend.ProductService.Services
{
    public class ProductService
    {
        protected IDbProductSource DbSource { get; set; }
        protected IQuickProductSource QuickSource { get; set; }

        public ProductService(IDbProductSource dbSource, IQuickProductSource quickSource)
        {
            DbSource = dbSource;
            QuickSource = quickSource;
        }

        //protected IProductSource GetRelevantSource(Type entityType, Type keyType, object key)
        //{
        //    //var id = Convert.ChangeType(key, keyType);
        //    //TODO: Алгритм выбора релевантного источника
        //}

        public Product GetProduct(int id)
        {
            return DbSource.Products.FirstOrDefault(p => p.Id == id);
        }

        public ProductModel GetProductModel(int id)
        {
            var product = GetProduct(id);
            //TODO: Смапить в модель
            return null;
        }

        public Product GetFullProduct(int id)
        {
            return DbSource.FullProducts.FirstOrDefault(p => p.Id == id);
        }

        public ProductModel GetFullProductModel(int id)
        {
            var product = GetFullProduct(id);
            //TODO: Смапить в модель
            return null;
        }

        async public Task AddProduct()
        {
            //TODO: Couchbase

        }
    }
}

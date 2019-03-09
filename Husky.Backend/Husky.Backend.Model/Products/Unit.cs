using System.Collections.Generic;

namespace Husky.Backend.Model.Products
{
    public class Unit : Dictionary<int>
    {
        public virtual ICollection<Product> Products { get; set; }
    }
}

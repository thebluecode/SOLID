using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WrongSubstitution
{
    public class Repository
    {
        public List<Product> ProductList;

        public virtual void Insert(Product product)
        {
            if (product == null)
                throw new ArgumentNullException("product", "Product cannot be null !");

            if (ProductList == null)
                ProductList = new List<Product>();

            ProductList.Add(product);
        }

        public virtual List<Product> GetList()
        {
            return ProductList;
        }
    }
}

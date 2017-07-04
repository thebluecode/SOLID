using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WrongSubstitution
{
    public class ODataRepository : Repository
    {
        public List<Product> ODataProductList;

        public override void Insert(Product product)
        {
            if (product == null)
                throw new ArgumentNullException("product", "Product cannot be null !");

            if (!IsConnected())
                throw new ODataServiceNotConnectedException("OData server not connected !");

            if (ODataProductList == null)
                ODataProductList = new List<Product>();

            ODataProductList.Add(product);
        }

        public override List<Product> GetList()
        {
            return ODataProductList;
        }

        private bool IsConnected()
        {
            return false;
        }
    }
}

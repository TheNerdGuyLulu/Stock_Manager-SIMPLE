using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Manager__SIMPLE_
{
    class Insert
    {
        public List<Product> ProductList;

        public Insert()
        {
            ProductList = new List<Product>();
        }

        public void InsertProduct(Product _product)
        {
            ProductList.Add(_product);
        }
    }
}

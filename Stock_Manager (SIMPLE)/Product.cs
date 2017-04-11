using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Manager__SIMPLE_
{
    class Product
    {

        public int codProd 
        {
            get; set;
        }
        public string nomeProd { get; set; }
        public decimal valorProd { get; set; }


        public Product(string _nomeProd, decimal _valorProd)
        {
            nomeProd = _nomeProd;
            valorProd = _valorProd;
            codProd = CalcCodProdIdentity();
        }

        int CalcCodProdIdentity()
        {
            int lastCod;

            if (Global.insert.ProductList.Count > 0)
            {
                var item = Global.insert.ProductList.Last();
                lastCod = int.Parse(item.codProd.ToString());
                lastCod++;
            }
            else
                lastCod = 1;

            return lastCod;
        }
    }
}
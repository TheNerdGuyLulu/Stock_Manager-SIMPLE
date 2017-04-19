using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Manager__SIMPLE_
{
    public class Product
    {
        public int codProd
        {
            get; set;
        }
        public string nomeProd { get; set; }
        public decimal valorProd { get; set; }
        public int quantidadeProd { get; set; }

        public Product(string _nomeProd, decimal _valorProd, int _quantidadeProd)
        {
            nomeProd = _nomeProd;
            valorProd = _valorProd;
            quantidadeProd = _quantidadeProd;
        }
    }
}
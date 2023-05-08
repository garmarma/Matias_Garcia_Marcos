using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matias_Garcia
{
    internal class ProductoVendido
    {
        private int _id;
        private int _idProducto;
        private string _stock;
        private string _idVenta;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public int IdProducto
        {
            get { return _idProducto; }
            set { _idProducto = value; }
        }

        public string Stock
        {
            get { return _stock; }
            set { _stock = value; }
        }

        public string IdVenta
        {
            get { return _idVenta; }
            set { _idVenta = value; }
        }
    }
}

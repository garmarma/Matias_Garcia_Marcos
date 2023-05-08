using System;
namespace Matias_Garcia
{
    internal class Producto
    {
        private int _id;
        private int _descripcion;
        private string _costo;
        private string _precioventa;
        private string _stock;
        private string _idusuario;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public int Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        public string Costo
        {
            get { return _costo; }
            set { _costo = value; }
        }

        public string PrecioVenta
        {
            get { return _precioventa; }
            set { _precioventa = value; }
        }
        public string Stock
        {
            get { return _stock; }
            set { _stock = value; }
        }
        public string IdUsuario 
        {
            get { return _idusuario; }
            set { _idusuario = value; }
        }


    }
}
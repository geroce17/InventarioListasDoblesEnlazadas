using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_De_Inventario
{
    class Producto
    {
        private int _Codigo;
        public int Codigo { get { return _Codigo; } }

        private string _Nombre;
        public string Nombre { get { return _Nombre; } }

        private int _Cantidad;
        public int Cantidad { get { return _Cantidad; } }

        private int _Costo;
        public int Costo { get { return _Costo; } }

        public Producto _Siguiente;

        public Producto _Anterior;

        //int codigo;
        //string nombre;
        //int cantidad;
        //int costo;
        //Producto siguiente;

        public Producto (int codigo, string nombre, int cantidad, int costo)
        {
            //this.codigo = codigo;
            //this.nombre = nombre;
            //this.cantidad = cantidad;
            //this.costo = costo;
            //this.siguiente = siguiente;

            _Codigo = codigo;
            _Nombre = nombre;
            _Cantidad = cantidad;
            _Costo = costo;
            _Siguiente = null;
            _Anterior = null;
        }

        public override string ToString()
        {
            string cadena = "";
            cadena = _Codigo + "\r\n" + _Nombre + "\r\n" + _Cantidad + "\r\n" + _Costo + "\r\n\r\n";
            return cadena;
        }
    }
}

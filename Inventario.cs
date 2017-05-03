using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_De_Inventario
{
    class Inventario
    {
        private Producto primero;
        private Producto actual;
        private Producto final;


        //public void agregar(int codigo, string nombre, int cantidad, int costo)
        //{
        //    Producto nuevoP = new Producto(codigo, nombre, cantidad, costo);
        //    if (primero == null)
        //        primero = nuevoP;
        //    else
        //    {
        //        actual = primero;
        //        while (actual._Siguiente!=null)
        //        {
        //            actual = actual._Siguiente;
        //        }
        //        actual._Siguiente = nuevoP;
        //        final = nuevoP;
        //    }
        //}

        public void agregar(int codigo, string nombre, int cantidad, int costo)
        {
            Producto nuevoP = new Producto(codigo, nombre, cantidad, costo);
            if (primero == null)
            {
                primero = nuevoP;
                final = primero;
            }
            else
            {
                agrega(nuevoP, primero);
            }
        }

        private void agrega(Producto nuevo, Producto ultimo)
        {
            if (ultimo._Siguiente == null)
            {
                ultimo._Siguiente = nuevo;
                nuevo._Anterior = ultimo;
                final = nuevo;
            }
            else
                agrega(nuevo, ultimo._Siguiente);
        }

        public string buscar(string nombre)
        {
            string cadena = "";
            actual = primero;
            while (actual.Nombre != nombre)
            {
                actual = actual._Siguiente;
            }
            cadena += actual.ToString();
            return cadena;
        }

        public void eliminar(int codigo)
        {
            if (primero.Codigo == codigo)
            {
                if (primero._Siguiente == null)
                    primero = null;
                else
                {
                    primero = primero._Siguiente;
                    primero._Anterior = null;
                }
            }
            else
            {
                actual = primero;
                while (actual._Siguiente.Codigo != codigo)
                {
                    actual = actual._Siguiente;
                }
                if (actual._Siguiente == final)
                {
                    final = actual;
                    actual._Siguiente = null;
                }
                else
                {
                    actual._Siguiente = actual._Siguiente._Siguiente;
                    actual._Siguiente._Anterior = actual;
                }
            }
        }

        public string reporte()
        {
            string cadena="";
            actual = primero;
            while (actual != null)
            {
                cadena += actual.ToString(); //actual.Codigo + "\r\n" + actual.Nombre + "\r\n" + actual.Cantidad + "\r\n" + actual.Costo + "\r\n\r\n";
                actual = actual._Siguiente;
            }
            return cadena;
        }

        public string reporteInverso()
        {
            if (final != null)
                return repInverso(final);
            else
                return "";
        }

        private string repInverso(Producto nodo)
        {
            if (nodo._Anterior == null)
                return nodo.ToString();
            else
                return nodo.ToString() + repInverso(nodo._Anterior) ;
        }

        public void insertar (int codigo, string nombre, int cantidad, int costo, int pos)
        {
            int cont = 1;
            Producto nuevoP = new Producto(codigo, nombre, cantidad, costo);
            actual = primero;
            if (pos == 1)
            {
                if (primero == null)
                    primero = nuevoP;
                else
                {
                    nuevoP._Siguiente = primero;
                    primero = nuevoP;
                    primero._Siguiente._Anterior = primero;
                }
            }
            else
            {
                cont++;
                while (cont != pos)
                {
                    cont++;
                    actual = actual._Siguiente;
                }
                nuevoP._Siguiente = actual._Siguiente;
                actual._Siguiente._Anterior = nuevoP;
                nuevoP._Anterior = actual;
                actual._Siguiente = nuevoP;
            }
            
        }

        public void agregaInicio(int codigo, string nombre, int cantidad, int costo)
        {
            Producto nuevoP = new Producto(codigo, nombre, cantidad, costo);
            if (primero == null)
            {
                primero = nuevoP;
                final = primero;
            }
                
            else
            {
                if (primero._Siguiente == null)
                    final = primero;
                nuevoP._Siguiente = primero;
                primero = nuevoP;
                primero._Siguiente._Anterior = primero;
            }
        }

        public void agregaFinal(int codigo, string nombre, int cantidad, int costo)
        {
            Producto nuevoP = new Producto(codigo, nombre, cantidad, costo);
            if (primero == null)
            {
                primero = nuevoP;
                final = nuevoP;
            }
            else
            {
                nuevoP._Anterior = final;
                nuevoP._Anterior._Siguiente = nuevoP;
                final = nuevoP;
            }
        }

        public void eliminarFinal()
        {
            if (final == primero)
            {
                final = null;
                primero = null;
            }
            else
            {
                final = final._Anterior;
                final._Siguiente = null;
            }
        }

        public void eliminarInicio()
        {
            if (primero._Siguiente == null)
            {
                primero = null;
                final = null;
            }
            else
            {
                primero = primero._Siguiente;
                primero._Anterior = null;
            }
        }

    }
}

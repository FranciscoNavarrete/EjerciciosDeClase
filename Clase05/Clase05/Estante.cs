using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase05
{
    class Estante
    {
        private Producto[] productos;
        private int ubicacionEstante;

        private Estante(int capacidad) 
        {
            this.productos = new Producto[capacidad];
        }

        public Estante(int capacidad, int ubicacion) :this(capacidad)
        {
            this.ubicacionEstante = ubicacion;
        }

        public Producto[] GetProductos() 
        {
            return this.productos;
        }
        public static string MostrarEstante(Estante e) 
        {
            StringBuilder cadena = new StringBuilder();
            cadena.AppendLine("Ubicacion del Estante: "+e.ubicacionEstante);
            for (int i = 0; i < e.productos.Length; i++)
            {
                cadena.Append(i+1 +"º Producto ");
                cadena.AppendLine("");
                cadena.AppendLine(Producto.MostrarProducto(e.productos[i]));
            }
            return cadena.ToString();
        }
        public static bool operator ==(Estante e, Producto p)
        {
            foreach (Producto item in e.productos)
            {
                if (!object.ReferenceEquals(item, null) && item == p)
                {
                    return true;
                }
            }

            return false;

        }
        public static bool operator !=(Estante e, Producto p)
        {
            return !(e == p);
        }
        public static bool operator +(Estante e, Producto p) 
        {
            for (int i = 0; i < e.productos.Length; i++)
            {
                if (object.ReferenceEquals(e.productos[i], null))
                {
                        if (e == p)
                        {
                            //recorrio y el producto estaba en el estante
                            return false;
                        }

                    
                    e.productos[i] = p;
                    return true;
                }
            }
            return false;
        }
        public static Estante operator -(Estante e, Producto p) 
        {
            for (int i = 0; i < e.productos.Length; i++)
            {
                if (e.productos[i] == p) 
                {
                    return new Estante(e.ubicacionEstante);
                }

            } return e;
            

        }

    }
}

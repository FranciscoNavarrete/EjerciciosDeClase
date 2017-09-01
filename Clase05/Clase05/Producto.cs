using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase05
{
    class Producto
    {
        private string codigoDeBarra;
        private string marca;
        private float precio;

        public Producto(string mar, string codigo, float prec) 
        {
            this.marca = mar;
            this.codigoDeBarra = codigo;
            this.precio = prec;
        }


        public static explicit operator string(Producto p)
        {
            return p.codigoDeBarra;
        }
        public string GetMarca()
        {
            return marca;
        }
        public float GetPrecio()
        {
            return precio;
        }

        public static string MostrarProducto(Producto p) 
        {
            StringBuilder cadena = new StringBuilder();
            cadena.AppendLine("Codigo de barras: "+p.codigoDeBarra);
            cadena.AppendLine("Marca: "+p.marca);
            cadena.AppendLine("Precio: "+p.precio);
            return cadena.ToString();
            
        }

        public static bool operator ==(Producto p1, string marca) 
        {
            return p1.marca == marca;
        }
        public static bool operator !=(Producto p1, string marca) 
        {
            return !(p1 == marca);
        }

        public static bool operator ==(Producto p1, Producto p2) 
        {
            return (p1.marca == p2.marca && p1.codigoDeBarra == p2.codigoDeBarra);
        }
        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }
        

    }
}

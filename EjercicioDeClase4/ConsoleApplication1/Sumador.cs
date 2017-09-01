using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Sumador
    {
        private int cantidadSumas;
        
        
        public Sumador() 
        {
            this.cantidadSumas = 0;
        }
        public Sumador(int cantSumas) 
        {
            this.cantidadSumas = cantSumas;
        }

         public long Sumar(long a, long b) 
        {
            cantidadSumas++;
            return a + b;
        }
         public string Sumar(string a, string b)
         {
             cantidadSumas++;
             return a + b;
         }

         
         public static explicit operator long(Sumador sum) 
         {
             return sum.cantidadSumas;
         }
         public static long operator +(Sumador a, Sumador b) 
         {
             return a.cantidadSumas + b.cantidadSumas;
         }

         public static bool operator |(Sumador a, Sumador b) 
         {
             return (a.cantidadSumas == b.cantidadSumas);
         }


         public static bool operator ==(Sumador a, Sumador b) 
         {
             return a.cantidadSumas == b.cantidadSumas;
         }
        public static bool operator !=(Sumador a, Sumador b)
        {
            return !(a == b);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Sumador suma1 = new Sumador();
            Sumador suma2 = new Sumador();

            Console.WriteLine("SUMA UNO");

            Console.WriteLine(suma1.Sumar(4, 6));
            Console.WriteLine(suma1.Sumar(5, 5));
            Console.WriteLine(suma1.Sumar(3, 7));

            Console.WriteLine("SUMA DOS");

            Console.WriteLine(suma2.Sumar(10, 5));
            Console.WriteLine(suma2.Sumar(8, 7));
            Console.WriteLine(suma2.Sumar("hola", "chau"));

            
            

            if (suma1 | suma2)
            {
                Console.WriteLine("Tiene igual cantidad de sumas");
            }
            else
            {
                Console.WriteLine("La cantidad de sumas son distintas");
            }

            long sumas = suma1 + suma2;

            Console.WriteLine("La cantidad de suma tiene es : {0}", sumas);

            Console.ReadKey();
        }
    }
}

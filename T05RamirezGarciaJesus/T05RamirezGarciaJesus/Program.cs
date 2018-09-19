using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace T05RamirezGarciaJesus
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch tiempo = Stopwatch.StartNew();
            Int32 suma = 0;
            for (Int32 cont = 1; cont <= 1000000; cont++)
            {
                suma = suma + cont;
            }

            Console.WriteLine("El resultado es: {0}", suma);
            Console.WriteLine("El tiempo requerido fue: {0}", tiempo.Elapsed);
            Console.WriteLine("Preciona una tecla para salir.");
            Console.ReadKey();
        }
    }
}

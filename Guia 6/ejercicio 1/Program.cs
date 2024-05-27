using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese el valor máximo para calcular la suma:");
            int maximo = Convert.ToInt32(Console.ReadLine());

            int suma = (maximo * (maximo + 1)) / 2;

            Console.WriteLine("la suma de los números naturales hasta " + maximo + " es: " + suma);
            Console.ReadKey();
        }
    }
}

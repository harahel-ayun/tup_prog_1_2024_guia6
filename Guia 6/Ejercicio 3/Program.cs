using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] numeros = new double[10];
            Console.WriteLine("ingrese 10 numeros:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write("numero " + (i + 1) + ": ");
                numeros[i] = Convert.ToDouble(Console.ReadLine());
            }
            double suma = 0;
            foreach (double numero in numeros)
            {
                suma += numero;
            }
            double promedio = suma / 10;
            Console.WriteLine("el promedio de los números ingresados es: " + promedio);
            Console.ReadKey();
        }

    }
}

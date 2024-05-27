using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0, num2 = 0,rango = 0;
            Console.WriteLine("ingrese los dos numeros");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());

            int numMenor, numMayor;
            if (num1 < num2)
            {
                numMenor = num1;
                numMayor = num2;
            }
            else
            {
                numMenor = num2;
                numMayor = num1;
            }


            rango = numMayor - numMenor;
            for (int i = numMenor; i <= num1; i++)
            {
                if (i != 1)
                {
                    if ((i % 2) == 0)
                    {
                        Console.WriteLine("el numero {0}es divisible por 2", i);
                    }
                    if ((i % 3) == 0)
                    {
                        Console.WriteLine("el numero {0} es divisible por 3", i);
                    }

                }
                else
                {
                    Console.WriteLine("ek numero 1 es divsible por 2 y por 3");
                }

            }
            Console.ReadKey();
        }
    }
}

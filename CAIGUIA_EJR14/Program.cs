using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Threading;

namespace CAIGUIA_EJR14
{
    class Program
    {
        static void Main(string[] args)
        {
            //Solicite el ingreso de dos frases y determine si son iguales, sin diferenciar mayúsculas de minúsculas.

            string frase1;
            string frase2;
            bool igualdad = true;

            do
            {
                Console.Write("Ingrese una frase: ");
                frase1 = Console.ReadLine();

                Console.Write("Ingrese la misma frase: ");
                frase2 = Console.ReadLine();

                if (frase1.Equals(frase2, StringComparison.InvariantCultureIgnoreCase))
                {
                    Console.WriteLine($"Usted ingreso dos frases iguales. Frase 1: '{frase1}' y Frase 2: '{frase2}' ");
                    break;
                }
                else
                {
                    Console.WriteLine("No ingreso la misma frase.");
                    
                }

            } while (igualdad);

            Console.ReadKey();

        }
    }
}

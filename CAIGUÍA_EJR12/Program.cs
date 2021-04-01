using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAIGUÍA_EJR12
{
    class Program
    {
        static void Main(string[] args)
        {
            //Solicite el ingreso de dos frases y determine si son iguales.

            
            string frase1;
            string frase2;
            do
            {
                Console.Write("Ingrese una frase: ");
                 frase1 = Console.ReadLine();

                Console.Write("Ingrese la misma frase nuevamente: ");
                frase2 = Console.ReadLine();

                if (frase1.Equals(frase2))
                {
                    Console.WriteLine($"Usted ha ingresado dos frases iguales. Primer frase: {frase1}, segunda frase: {frase2}");
                }
                else
                {
                    Console.WriteLine("Usted no ingreso la misma frase.");
                }


            } while (frase1 != frase2);

            Console.ReadKey();

        }
    }
}

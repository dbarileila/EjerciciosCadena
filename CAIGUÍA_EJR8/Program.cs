using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAIGUÍA_EJR8
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Solicite al usuario el ingreso de una frase y presente un mensaje indicando si alguna contiene la
            palabra “fin”.*/

            
            do
            {
                Console.Write("Por favor ingrese una frase: ");
                 string frase = Console.ReadLine();

                if (frase.Contains("fin"))
                {
                    Console.Write($"Su frase ingresada fue: {frase} ");
                    break;

                }
              


            } while (true);

            Console.ReadKey();

     
        }
    }
}

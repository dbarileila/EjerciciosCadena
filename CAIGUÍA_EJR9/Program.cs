using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAIGUÍA_EJR9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Solicite un ingreso al usuario y lo presente en mayúsculas.

            do
            {
                Console.Write("Por favor ingrese texto: ");
                string ingreso = Console.ReadLine();

                Console.WriteLine($"Su ingreso es: {ingreso.ToUpper()}");

            } while (false);


            Console.ReadKey();

        }
    }
}

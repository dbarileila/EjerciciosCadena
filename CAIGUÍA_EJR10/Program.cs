using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAIGUÍA_EJR10
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Write("Por favor ingrese texto: ");
                string ingreso = Console.ReadLine();

                Console.WriteLine($"Su ingreso es: {ingreso.ToLower()}");

            } while (false);


            Console.ReadKey();
        }
    }
}

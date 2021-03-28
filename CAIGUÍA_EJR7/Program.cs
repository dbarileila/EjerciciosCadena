using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAIGUÍA_EJR7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Solicite al usuario el ingreso de su nombre y presente el mensaje “Hola [nombre]”.

            Console.Write("Ingrese su nombre: ");
            string NOMBRE = Console.ReadLine();

            Console.Write($"Hola {NOMBRE}");

            Console.ReadKey();
        }
    }
}

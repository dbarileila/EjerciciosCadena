using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAIGUÍA_EJR13
{
    class Program
    {
        static void Main(string[] args)
        {
            //Solicite el ingreso de dos frases y determine si tienen la misma longitud.


            string frase1;
            string frase2;
           
            do
            {
                Console.Write("Ingrese una frase: ");
                 frase1 = Console.ReadLine();

                Console.Write("Ingrese otra frase: ");
                 frase2 = Console.ReadLine();

                if (frase1.Length == frase2.Length)
                {
                    Console.WriteLine($"Usted ingreso la frase '{frase1}' con longitud = {frase1.Length}" +
                        $" y la frase '{frase2}' con longitud = {frase2.Length}");
                }
                else
                {
                    Console.WriteLine("Las frases ingresadas no poseen la misma longitud.");
                    
                }



            } while (frase1.Length != frase2.Length);

            Console.ReadKey();
        }
    }
}

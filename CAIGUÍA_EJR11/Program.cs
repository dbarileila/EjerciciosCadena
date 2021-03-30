using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace CAIGUÍA_EJR11
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Reemplace en una cadena ingresada por el usuario todas las vocales acentuadas por vocales 
             * sin acento y presente el resultado.*/

            do
            {
                Console.Write("Ingrese un texto con las vocales acentuadas: ");
                string ingreso = Console.ReadLine();

                
                

                string palabrasinTildes = Regex.Replace(ingreso.Normalize(NormalizationForm.FormD), @"[^0-9A-Za-z\s]", "",
                RegexOptions.None);
                
             
                Console.WriteLine($"Su ingreso sin acento: {palabrasinTildes}");


            } while (false);

            Console.ReadKey();


        }
    }
}

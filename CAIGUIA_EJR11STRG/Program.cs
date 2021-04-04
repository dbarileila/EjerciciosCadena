using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAIGUIA_EJR11STRG
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Reemplace en una cadena ingresada por el usuario todas las vocales 
            acentuadas por vocales sin acento y presente el resultado.*/

              
             Console.Write("Ingrese texto acento: ");
             string ingreso = Console.ReadLine();

                string[] ingresoConAcento = new string[] {"á", "é", "í", "ó", "ú", "Á", "É", "Í", "Ó", "Ú"};
                string[] ingresoSinAcento = new string[] { "a", "e", "i", "o", "u", "A", "E", "I", "O", "U" };

                for (int i = 0; i < 10; i++)
                {
                    ingreso = ingreso.Replace(ingresoConAcento[i], ingresoSinAcento[i]);
                }

            Console.WriteLine($"Usted ingreso {ingreso}");
            
            Console.ReadKey();

        }
    }
}

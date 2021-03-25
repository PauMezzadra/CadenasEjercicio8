using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadenasEjercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase;
            string cadena = "FIN";
            do
            {
                Console.WriteLine("Ingrese cualquier frase, yo le avisaré cuando su frase contenga la cadena ´FIN´");
                frase = Console.ReadLine().ToUpper();
                if (frase == "")
                {
                    Console.WriteLine("Debe ingresar al menos una palabra");
                }
                else
                {
                    if (frase.Contains(cadena))
                    {
                        Console.WriteLine("Su frase contiene la cadena ´FIN´");
                    }
                    else
                    {
                        Console.WriteLine("Su frase no contiene la cadena ´FIN´");
                    }
                }
                
            } while (!frase.Contains(cadena));


            Console.ReadKey();
        }
    }
}

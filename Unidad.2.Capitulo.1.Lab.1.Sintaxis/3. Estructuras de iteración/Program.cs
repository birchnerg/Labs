using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Estructuras_de_iteración
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantIteraciones = 5;
            string[] arrayDeStrings = new string[cantIteraciones];
            for (int i = 0; i < cantIteraciones; i++)
            {
                Console.WriteLine("Ingrese la cadena " + (i + 1));
                arrayDeStrings[i] = Console.ReadLine();
            }
            for (int i = (cantIteraciones-1); i >= 0; i--)
            {
                Console.WriteLine("cadena N°" + (i + 1) + ": " + arrayDeStrings[i]);
            }
            Console.WriteLine("Precione una tecla para finalizar");
            Console.ReadLine();       
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Estructuras.de.decision._bis_
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputTexto;
            Console.WriteLine("2. Estructuras de decisión (bis)");
            Console.WriteLine("Ingrese una linea de texto:");
            inputTexto = Console.ReadLine();
            if (inputTexto != "")
            {
                Console.WriteLine("1 - Trasnformar linea de texto ingresada a mayusculas");
                Console.WriteLine("2 - Trasnformar linea de texto ingresada a minusculas");
                Console.WriteLine("3 - Cantidad de caracteres de linea de texto ingresada");
                ConsoleKeyInfo opcion = Console.ReadKey();
                Console.WriteLine();
                switch (opcion.Key)
                {
                    case (ConsoleKey.D1):
                        Console.WriteLine(inputTexto.ToUpper());
                        break;
                    case (ConsoleKey.D2):
                        Console.WriteLine(inputTexto.ToLower());
                        break;
                    case (ConsoleKey.D3):
                        Console.WriteLine("La linea de texto ingresada posee " + inputTexto.Length + " caracteres.");
                        break;
                    default:
                        Console.WriteLine("No se ingreso una opcion valida");
                        Console.WriteLine("Fin de ejecucion");
                        break;
                }
            }
            else
            {
                Console.WriteLine("No se ingreso una linea de texto valida");
                Console.WriteLine("Fin de ejecucion");
            }
            Console.WriteLine("Precione una tecla para cerrar");
            Console.ReadKey();
        }
    }
}

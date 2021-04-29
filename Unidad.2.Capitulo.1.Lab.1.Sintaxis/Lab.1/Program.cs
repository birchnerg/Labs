using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Estructuras de decisión ");
            string inputTexto;
            Console.WriteLine("Ingrese una linea de texto:");
            inputTexto = Console.ReadLine();
            if (inputTexto != "")
            {
                Console.WriteLine("1 - Trasnformar linea de texto ingresada a mayusculas");
                Console.WriteLine("2 - Trasnformar linea de texto ingresada a minusculas");
                Console.WriteLine("3 - Cantidad de caracteres de linea de texto ingresada");
                ConsoleKeyInfo opcion = Console.ReadKey();
                Console.WriteLine();
                if (opcion.Key == ConsoleKey.D1)
                {
                    Console.WriteLine(inputTexto.ToUpper());
                }
                else if (opcion.Key == ConsoleKey.D2)
                {
                    Console.WriteLine(inputTexto.ToLower());
                }
                else if (opcion.Key == ConsoleKey.D3)
                {
                    Console.WriteLine("La linea de texto ingresada posee " + inputTexto.Length + " caracteres.");
                }
                else
                {
                    Console.WriteLine("No se ingreso una opcion valida");
                    Console.WriteLine("Fin de ejecucion");
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

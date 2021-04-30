using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Ejercicios_para_Pensar
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo opcionUsuario;
            do
            {
                Console.Clear();
                opcionUsuario = menu();
                switch (opcionUsuario.Key)
                {
                    case (ConsoleKey.D1): case(ConsoleKey.NumPad1):
                        Console.WriteLine("ejecuta modulo 1");

                        suma_2_numeros();
                        break;
                    case (ConsoleKey.D2): case(ConsoleKey.NumPad2):
                        Console.WriteLine("ejecuta modulo 2");
                        break;
                    case (ConsoleKey.D3): case(ConsoleKey.NumPad3):
                        Console.WriteLine("ejecuta modulo 3");
                        break;
                    case (ConsoleKey.D4): case(ConsoleKey.NumPad4):
                        Console.WriteLine("ejecuta modulo 4");
                        break;
                    case (ConsoleKey.D5): case (ConsoleKey.NumPad5):
                        Console.WriteLine("ejecuta modulo 5");
                        break;
                    case (ConsoleKey.D6): case (ConsoleKey.NumPad6):
                        Console.WriteLine("ejecuta modulo 6");
                        break;
                    case (ConsoleKey.D7): case (ConsoleKey.NumPad7):
                        Console.WriteLine("ejecuta modulo 7");
                        break;
                    case (ConsoleKey.D8): case(ConsoleKey.NumPad8):
                        Console.WriteLine("ejecuta modulo 8");
                        break;
                    case (ConsoleKey.D9): case (ConsoleKey.NumPad9):
                        Console.WriteLine("ejecuta modulo 9");
                        break;
                    case (ConsoleKey.D0):
                    case (ConsoleKey.NumPad0):
                        Console.WriteLine("Precione cualquier tecla para salir");
                        Console.ReadLine();
                        break;
                }
            } while (opcionUsuario.Key != ConsoleKey.D0 && opcionUsuario.Key != ConsoleKey.NumPad0 );
        }

        public static ConsoleKeyInfo menu()
        {
            Console.WriteLine("Ingrese opcion (1 a 9) para ejecutar, 0 para salir:");
            Console.WriteLine("1: suma de 2 numeros");
            Console.WriteLine("2: ");
            Console.WriteLine("3: ");
            Console.WriteLine("4: ");
            Console.WriteLine("5: ");
            Console.WriteLine("6: ");
            Console.WriteLine("7: ");
            Console.WriteLine("8: ");
            Console.WriteLine("9: ");
            Console.WriteLine("0: Salir");
            ConsoleKeyInfo opcion = Console.ReadKey();
            return opcion;
        }
        public static void suma_2_numeros()
        {
            Console.WriteLine("----------------");
            Console.WriteLine("Ingresar 2 numeros para obtner su suma:");
            Console.WriteLine("Ingrese el primer numero");
            int a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            int b = Int32.Parse(Console.ReadLine());
            int c = a + b;
            Console.WriteLine("El resultado de la suma de {0} y {1} es {2} >.", a, b, (a+b));
            Console.WriteLine("Presione una tecla para volver al menu");
            Console.ReadKey();
        }
        public static void nombre2()
        {
            Console.WriteLine("----------------");

            Console.WriteLine("Presione una tecla para volver al menu");
            Console.ReadKey();
        }
        public static void nombre3()
        {
            Console.WriteLine("----------------");

            Console.WriteLine("Presione una tecla para volver al menu");
            Console.ReadKey();
        }
        public static void nombre4()
        {
            Console.WriteLine("----------------");

            Console.WriteLine("Presione una tecla para volver al menu");
            Console.ReadKey();
        }
        public static void nombre5()
        {
            Console.WriteLine("----------------");

            Console.WriteLine("Presione una tecla para volver al menu");
            Console.ReadKey();
        }
        public static void nombre6()
        {
            Console.WriteLine("----------------");

            Console.WriteLine("Presione una tecla para volver al menu");
            Console.ReadKey();
        }
        public static void nombre7()
        {
            Console.WriteLine("----------------");

            Console.WriteLine("Presione una tecla para volver al menu");
            Console.ReadKey();
        }
        public static void nombre8()
        {
            Console.WriteLine("----------------");

            Console.WriteLine("Presione una tecla para volver al menu");
            Console.ReadKey();
        }
        public static void nombre9()
        {
            Console.WriteLine("----------------");

            Console.WriteLine("Presione una tecla para volver al menu");
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseJuego
{
    public class Juego
    {
        private int _record = 999;

        public Juego()
        {
            ComenzarJuego();
        }

        public void ComenzarJuego()
        {
            ConsoleKeyInfo opcion;
           /* Jugada actual = new jugada(0);*/
            JugadaConAyuda actual = new JugadaConAyuda(0);
            do
            {
                Console.WriteLine("----------ADIVINAR NUMERO-----------");
                Console.Write("- MODO DE JUEGO -:");
               /* Console.WriteLine(" Sin Ayuda");*/
                Console.WriteLine(" Con Ayuda");
                Console.WriteLine("Presione una tecla para continuar");
                opcion = Console.ReadKey();
                Console.Clear();
               /* actual = new Jugada(PreguntarMaximo());*/
                actual = new JugadaConAyuda(PreguntarMaximo());
                do
                {                    
                    int aComparar = PreguntarNumer();
                    actual.Comparar(aComparar);

                } while (actual.Adivino == false);

                if (actual.Adivino == true)
                {
                    CompararRecord(actual.Intentos);
                    opcion = Continuar();
                }
            } while (opcion.Key != ConsoleKey.N);
        }

        private void CompararRecord(int intentos)
        {
            Console.WriteLine("Adivino el numero");
            if (_record <= intentos)
            {
                Console.WriteLine("No logro superar el record de {0} intentos.", _record);
                Console.WriteLine("Necesito {0} intentos para adivinar el numero.", intentos);
            }
            if (_record > intentos)
            {
                Console.WriteLine("Logro superar el record de {0} intentos.", _record);
                Console.WriteLine("Necesito {0} intentos para adivinar el numero.", intentos);
                Console.WriteLine("Nuevo record {0}", intentos);
                _record = intentos;
            }
        }

        private ConsoleKeyInfo Continuar()
        {
            Console.WriteLine("Desea jugar nuevamente (S/N)");
            ConsoleKeyInfo opcion = Console.ReadKey();
            
            return opcion;
        }

        private int PreguntarMaximo()
        {
            string mensaje = "Ingrese el limite maximo del numero a adivinar";
            int maximo = Validar_int(mensaje);
            return maximo;
        }

        private int PreguntarNumer()
        {
            string mensaje = "Ingrese un numero para comparar";
            int aComparar = Validar_int(mensaje);
            return aComparar;
        }
        private int Validar_int(string mensaje)
        {
            bool bandera = true;
            int ingreso = 0;
            do
            {
                Console.WriteLine(mensaje);
                try
                {
                    ingreso = Convert.ToInt32(Console.ReadLine());
                    bandera = false;
                    break;
                }
                catch
                {
                    Console.WriteLine(
                        "El numero ingresado no es un entero positivo.");
                }
            } while (bandera);
            return ingreso;
        }
    }
}

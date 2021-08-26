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
        //Menu principal en pantalla
            ConsoleKeyInfo opcionUsuario;
            do
            {
                Console.Clear();
                opcionUsuario = menu();
                switch (opcionUsuario.Key)
                {
                    case (ConsoleKey.D1): case(ConsoleKey.NumPad1):
                        Console.WriteLine("-->ejecuta modulo 1");
                        suma_2_numeros();
                        break;
                    case (ConsoleKey.D2): case(ConsoleKey.NumPad2):
                        Console.WriteLine("-->ejecuta modulo 2");
                        es_bisiesto();
                        break;
                    case (ConsoleKey.D3): case(ConsoleKey.NumPad3):
                        Console.WriteLine("-->ejecuta modulo 3");
                        serie_fibonacci();
                        break;
                    case (ConsoleKey.D4): case(ConsoleKey.NumPad4):
                        Console.WriteLine("-->ejecuta modulo 4");
                        pares_1_a_100();
                        break;
                    case (ConsoleKey.D5): case (ConsoleKey.NumPad5):
                        Console.WriteLine("-->ejecuta modulo 5");
                        mes_numero();
                        break;
                    case (ConsoleKey.D6): case (ConsoleKey.NumPad6):
                        Console.WriteLine("-->ejecuta modulo 6");
                        entero_a_romano();

                        break;
                    case (ConsoleKey.D7): case (ConsoleKey.NumPad7):
                        Console.WriteLine("-->ejecuta modulo 7");
                        primos_gemelos();
                        break;
                    case (ConsoleKey.D8): case(ConsoleKey.NumPad8):
                        Console.WriteLine("-->ejecuta modulo 8");
                        validar_clave();
                        break;
                    case (ConsoleKey.D9): case (ConsoleKey.NumPad9):
                        Console.WriteLine("-->ejecuta modulo 9");
                        piramide_asteriscos();
                        break;
                    case (ConsoleKey.D0):
                    case (ConsoleKey.NumPad0):
                        Console.WriteLine("");
                        Console.WriteLine("Precione cualquier tecla para salir");
                        Console.ReadLine();
                        break;
                }
            } while (opcionUsuario.Key != ConsoleKey.D0 && opcionUsuario.Key != ConsoleKey.NumPad0 );
        }
        // Funciones del programa
        public static ConsoleKeyInfo menu()
        {
            Console.WriteLine("Ingrese opcion (1 a 9) para ejecutar, 0 para salir:");
            Console.WriteLine("1: suma de 2 numeros");
            Console.WriteLine("2: el año es bisiesto");
            Console.WriteLine("3: serie de Fibonacci");
            Console.WriteLine("4: numeros pares del 1 al 100");
            Console.WriteLine("5: ingrese un nombre de mes para conocer su numero en el calendario");
            Console.WriteLine("6: transformar numero decimal a romano");
            Console.WriteLine("7: numeros primos gemelos (NO REALIZADO)");
            Console.WriteLine("8: validacion de clave");
            Console.WriteLine("9: piramide de asteriscos");
            Console.WriteLine("0: Salir");
            ConsoleKeyInfo opcion = Console.ReadKey();
            return opcion;
        }
        public static void suma_2_numeros()
        {
            Console.WriteLine("----------------");
            Console.WriteLine("Ingresar 2 numeros para obtner su suma:");
            string msj = "Ingrese el primer numero";
            int a = leer_entero(msj);
            msj = "Ingrese el segundo numero";
            int b = leer_entero(msj);
            int c = a + b;
            Console.WriteLine("El resultado de la suma de {0} y {1} es {2} .", a, b, (a+b));
            Console.WriteLine("Presione una tecla para volver al menu");
            Console.ReadKey();
        }
        public static void es_bisiesto()
        {
            Console.WriteLine("----------------");
            string msj = "Ingrese un año para comprobar si es bisiesto: ";
            int a = leer_entero(msj);
            int caso;
            if (a % 100 == 0){
                caso = 0;
            }
            else
            {
                caso = 1;
            }
            switch (caso)
            {
                case (0):
                    if (a % 400 == 0)
                    {
                        Console.WriteLine("El año {0} es bisiesto.", a);
                    }
                    else
                    {
                        Console.WriteLine("El año {0} es no es bisiesto.", a);
                    }
                    break;
                case (1):
                    if (a % 4 == 0)
                    {
                        Console.WriteLine("El año {0} es bisiesto.", a);
                    }
                    else
                    {
                        Console.WriteLine("El año {0} es no es bisiesto.", a);
                    }
                    break;
            }

            Console.WriteLine("Presione una tecla para volver al menu");
            Console.ReadKey();
        }
        public static void serie_fibonacci()
        {
            Console.WriteLine("----------------");
            Console.WriteLine("Serie de Fibonacci");
            string msj = "Ingrese la cantidad de iteraciones que desea";
            int limite = leer_entero(msj);
            int primero = 1;
            int segundo = 1;
            if (limite == 1){
                Console.WriteLine("La serie hasta la posicion {0} es:", limite);
                Console.Write("{0}", primero);
            }
            else if (limite == 2)
            {
                Console.WriteLine("La serie hasta la posicion {0} es:", limite);
                Console.Write("{0}, {1}", primero, segundo);
            }
            else
            {
                Console.WriteLine("La serie hasta la posicion {0} es:", limite);
                Console.Write("{0}, {1}", primero, segundo);
                int aux = 0;
                for (int i = 3; i <= limite; i++)
                {
                    aux = segundo;
                    segundo = primero + segundo;
                    primero = aux;
                    Console.Write(", {0}", segundo);
                } 
            }
            Console.WriteLine("");
            Console.WriteLine("Presione una tecla para volver al menu");
            Console.ReadKey();
        }
        public static void pares_1_a_100()
        {
            Console.WriteLine("----------------");
            Console.WriteLine("Los numeros pares del 1 al 100 son:");
            int limite = 100;
            for (int i = 1; i <= limite; i++)
            {
                if (i % 2 == 0)
                {
                    if (i != limite) 
                    {
                        Console.Write("{0}, ", i);
                    }
                    else
                    {
                        Console.Write("{0}.", limite);
                    }
                }
            }
            Console.WriteLine("");
            Console.WriteLine("Presione una tecla para volver al menu");
            Console.ReadKey();
        }
        public static void mes_numero()
        {
            Console.WriteLine("----------------");
            bool bandera = true;
            do
            {
                Console.WriteLine("Ingrese el nombre de un mes para concer su numero en el calendario: ");
                string mes = Console.ReadLine();
                switch (mes.ToLower())
                {
                    case ("enero"):
                        Console.WriteLine("{0} + 1", mes);
                        bandera = true;
                        break;
                    case ("febrero"):
                        Console.WriteLine("{0} + 2", mes);
                        bandera = true;
                        break;
                    case ("marzo"):
                        Console.WriteLine("{0} + 3", mes);
                        bandera = true;
                        break;
                    case ("abril"):
                        Console.WriteLine("{0} + 4", mes);
                        bandera = true;
                        break;
                    case ("mayo"):
                        Console.WriteLine("{0} + 5", mes);
                        bandera = true;
                        break;
                    case ("junio"):
                        Console.WriteLine("{0} + 6", mes);
                        bandera = true;
                        break;
                    case ("julio"):
                        Console.WriteLine("{0} + 7", mes);
                        bandera = true;
                        break;
                    case ("agosto"):
                        Console.WriteLine("{0} + 8", mes);
                        bandera = true;
                        break;
                    case ("septiembre"):
                        Console.WriteLine("{0} + 9", mes);
                        bandera = true;
                        break;
                    case ("octubre"):
                        Console.WriteLine("{0} + 10", mes);
                        bandera = true;
                        break;
                    case ("noviembre"):
                        Console.WriteLine("{0} + 11", mes);
                        bandera = true;
                        break;
                    case ("diciembre"):
                        Console.WriteLine("{0} + 12", mes);
                        bandera = true;
                        break;
                    default:
                        Console.WriteLine("Opcion ingresada incorrecta, intente nuevamente");
                        bandera = false;
                        break;
                }
            } while (bandera != true);
            Console.WriteLine("Presione una tecla para volver al menu");
            Console.ReadKey();
        }
        public static void entero_a_romano()
        {
            Console.WriteLine("----------------");
            string mensaje = "Ingrese un numero entero menor a 3999 para transformarlo a notacion romana:";
            int numero = leer_entero(mensaje);
            string romano = "";
            int unidad_mil = (numero / 1000); 
            if (unidad_mil != 0)
            {
                for (int i = 0; i < unidad_mil; i++)
                {
                    romano = romano + "M";
                }
                numero = numero - 1000 * unidad_mil;
            }
            int centena = numero / 100;
            if (centena != 0)
            {
                switch (centena)
                {
                    case (1):
                        romano = romano + "C";
                        break;
                    case (2):
                        romano = romano + "CC";
                        break;
                    case (3):
                        romano = romano + "CCC";
                        break;
                    case (4):
                        romano = romano + "CD";
                        break;
                    case (5):
                        romano = romano + "D";
                        break;
                    case (6):
                        romano = romano + "DC";
                        break;
                    case (7):
                        romano = romano + "DCC";
                        break;
                    case (8):
                        romano = romano + "DCCC";
                        break;
                    case (9):
                        romano = romano + "CM";
                        break;
                }
                numero = numero - 100 * centena; 
            }
            int decena = numero / 10;
            if (decena != 0)
            {
                switch (decena)
                {
                    case (1):
                        romano = romano + "X";
                        break;
                    case (2):
                        romano = romano + "XX";
                        break;
                    case (3):
                        romano = romano + "XXX";
                        break;
                    case (4):
                        romano = romano + "XL";
                        break;
                    case (5):
                        romano = romano + "L";
                        break;
                    case (6):
                        romano = romano + "LX";
                        break;
                    case (7):
                        romano = romano + "LXX";
                        break;
                    case (8):
                        romano = romano + "LXXX";
                        break;
                    case (9):
                        romano = romano + "XC";
                        break;
                }
                numero = numero - 10 * decena;
            }
            if (numero != 0)
            {
                switch (numero)
                {
                    case (1):
                        romano = romano + "I";
                        break;
                    case (2):
                        romano = romano + "II";
                        break;
                    case (3):
                        romano = romano + "III";
                        break;
                    case (4):
                        romano = romano + "IV";
                        break;
                    case (5):
                        romano = romano + "V";
                        break;
                    case (6):
                        romano = romano + "VI";
                        break;
                    case (7):
                        romano = romano + "VII";
                        break;
                    case (8):
                        romano = romano + "VIII";
                        break;
                    case (9):
                        romano = romano + "IX";
                        break;
                }
            }
            Console.WriteLine("");
            Console.WriteLine(romano);
            Console.WriteLine("Presione una tecla para volver al menu");
            Console.ReadKey();
        }
        public static void primos_gemelos()
        {
            Console.WriteLine("----------------");
            Console.WriteLine(" NO REALIZADO" +
                "");           
            Console.WriteLine("Presione una tecla para volver al menu");
            Console.ReadKey();
        }
        public static void validar_clave()
        {
            Console.WriteLine("----------------");
            int intentos = 0;
            Boolean estado = false;
            string clave_correcta = "nEt2021";
            do
            {
                intentos = intentos + 1;
                Console.WriteLine("Introduzca la clave (intento {0} de 4)    ----  \"nEt2021\"", intentos);
                string clave_ingresada = Console.ReadLine();
                if (clave_correcta == clave_ingresada)
                {
                    estado = true;
                }
            } while ((intentos < 4) && (estado == false)) ;
            if (estado == true)
            {
                Console.WriteLine("Clave correcta");
            }
            else
            {
                Console.WriteLine("Clave incorrecta en los {0} intentos posibles", intentos);
            }
            Console.WriteLine("Presione una tecla para volver al menu");
            Console.ReadKey();
        }
        public static void piramide_asteriscos()
        {
            Console.WriteLine("----------------");
            string mensaje = "Ingrese cantidad de pisos de la piramide";
            int cantidad = leer_entero(mensaje);
            string piramide = "*";
            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (piramide.Length / 2)) + "}", piramide));
                piramide = piramide + "**";
            }
            Console.WriteLine("Presione una tecla para volver al menu");
            Console.ReadKey();
        }
        // Validadores de ingresos por teclado
        public static int leer_entero(string mensaje)
        {
            bool bandera = false;
            int entero = 0;
            do
            {
                Console.WriteLine(mensaje);
                string lectura = Console.ReadLine();
                try
                {
                    entero = Int32.Parse(lectura);
                    bandera = true;
                }
                catch
                {
                    Console.WriteLine("No se ingreso un entero intente nuevamente");
                }
            } while (bandera != true);
            return entero;
        }
       
    }
}

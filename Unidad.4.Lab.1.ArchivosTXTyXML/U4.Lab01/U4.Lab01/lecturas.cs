using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace U4.Lab01
{
    class lecturas
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Presione una tecla para generar el archivo agendaxml.xml con los datos de agenda.txt");
            Console.ReadKey();
            archivoxml.EscribirXML();
            Console.WriteLine("Archivo agendaxml.xml generado correctamente \n\n Presione una tecla para ver su contenido");
            Console.ReadKey();
            Console.WriteLine();
            archivoxml.leerXML();
            Console.ReadKey();
            /*
            #region byteabyte
            Console.WriteLine("---- Lectura byte a byte ----");
            FileStream lector = new FileStream("Agenda.txt", FileMode.Open, FileAccess.Read, FileShare.Read);
            while (lector.Length > lector.Position)
            {
                Console.Write((char)lector.ReadByte());
            }
            lector.Close();
            Console.WriteLine();
            #endregion
            #region PorLinea
            Console.WriteLine("---- Lectura por linea ----");
            StreamReader lector2 = File.OpenText("Agenda.txt");
            string linea;
            do
            {
                linea = lector2.ReadLine();
                if (linea != null)
                {
                    Console.WriteLine(linea);
                }
            } while (linea != null);
            lector2.Close();
            Console.WriteLine();
            #endregion
            #region PorLineaSplit
            Console.WriteLine("---- Lectura por linea + split ----");
            StreamReader lector3 = File.OpenText("Agenda.txt");
            Console.WriteLine("Nombre\tApellido\tE-mail\t\t\tTelefono");
            do
            {
                linea = lector3.ReadLine();
                if (linea != null)
                {
                    string[] valores = linea.Split(';');
                    Console.WriteLine("{0}\t{1}\t{2}\t{3}", valores[0], valores[1], valores[2], valores[3]);
                }
            } while (linea != null);
            lector3.Close();
            Console.WriteLine();
            #endregion

            Console.WriteLine("----------");

            leer();
            escribir();
            leer();

            Console.ReadKey();
            */
        }

        private static void leer()
        {
            StreamReader lector4 = File.OpenText("Agenda.txt");
            string linea2;
            Console.WriteLine("Nombre\tApellido\tE-mail\t\t\tTelefono");
            do
            {
                linea2 = lector4.ReadLine();
                if (linea2 != null)
                {
                    string[] valores = linea2.Split(';');
                    Console.WriteLine("{0}\t{1}\t{2}\t{3}", valores[0], valores[1], valores[2], valores[3]);
                }
            } while (linea2 != null);
            lector4.Close();
        }
        private static void escribir()
        {
            StreamWriter escritor = File.AppendText("agenda.txt");
            Console.WriteLine("Ingrese nuevo contacto");
            string rta = "S";
            while (rta == "S")
            {
                Console.Write("Ingrese nombre:");
                string nombre = Console.ReadLine();
                Console.WriteLine();
                Console.Write("Ingrese apellido:");
                string apellido = Console.ReadLine();
                Console.WriteLine();
                Console.Write("Ingrese e-mail:");
                string email = Console.ReadLine();
                Console.WriteLine();
                Console.Write("Ingrese telefono:");
                string telefono = Console.ReadLine();
                Console.WriteLine();
                escritor.WriteLine(nombre + ";" + apellido + ";" + email + ";" + telefono);
                Console.Write("Desea ingresar un nuevo contacto? (S/N)");
                rta = Console.ReadLine();
            }
            escritor.Close();
        }
    }
}

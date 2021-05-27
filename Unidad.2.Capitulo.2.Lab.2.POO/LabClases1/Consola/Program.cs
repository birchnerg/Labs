using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClasesPersonas;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona Marcos = new Persona("Marcos", "Perze", 2000, 6, 11, 32565465);
            Console.WriteLine(Marcos.Apellido);
            Console.WriteLine(Marcos.Nombre);
            Console.WriteLine(Marcos.Dni);
            Console.WriteLine(Marcos.GetAge());
            Console.WriteLine(Marcos.GetFullName());
            Console.ReadLine();
        }
    }
}

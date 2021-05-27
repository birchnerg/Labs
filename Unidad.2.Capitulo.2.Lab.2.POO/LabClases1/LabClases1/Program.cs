using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases;

namespace LabClases1
{
    class Program
    {
        static void Main(string[] args)
        {
            A instancia_a1 = new A();
            A instancia_a2 = new A("Instancia con el segundo constructor");
            B instancia_b = new B();

            instancia_a1.MostrarNombre();
            instancia_a2.MostrarNombre();
            instancia_b.MostrarNombre();
            instancia_a1.M1();
            instancia_a2.M2();
            instancia_b.M3();
            instancia_b.M4();
            Console.ReadKey();
        }
    }
}

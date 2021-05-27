using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseJuego
{
    class JugadaConAyuda : Jugada
    {
        public JugadaConAyuda(int maxNumero) : base (maxNumero)
        {
        }
        new public bool Comparar(int numero_jugador)
        {
            Intentos++;
            if (Math.Abs(numero_jugador - Numero) >= 100)
            {
                if (numero_jugador > Numero)
                {
                    Console.WriteLine("El numero es mucho menor(mas de 100 de diferencia)");
                }
                else
                {
                    Console.WriteLine("El numero es mucho mayor(mas de 100 de diferencia)");
                }
            }
            else if (Math.Abs(numero_jugador - Numero) >= 10)
            {
                if (numero_jugador > Numero)
                {
                    Console.WriteLine("El numero es menor((menos de 100 de diferencia))");
                }
                else
                {
                    Console.WriteLine("El numero es mayor(menos de 100 de diferencia)");
                }
            }
            else if (Math.Abs(numero_jugador - Numero) >= 1)
            {
                if (numero_jugador > Numero)
                {
                    Console.WriteLine("El numero es un poco menor(menos de 10 de diferencia)");
                }
                else
                {
                    Console.WriteLine("El numero es un poco mayor(menos de 10 de diferencia)");
                }
            }
            if (numero_jugador == Numero)
            {
                Adivino = true;
            }
            return Adivino;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseJuego
{
    class Jugada
    {
        private bool _adivino;
        private int _intentos;
        private int _numero;

        public Jugada(int maxNumero)
        {
            Random rnd = new Random();
            Numero = rnd.Next(maxNumero);
        }

        public bool Adivino
        {
            get
            {
                return _adivino;
            }
            set
            {
                _adivino = value;
            }
        }

        public int Intentos
        {
            get
            {
                return _intentos;
            }
            set
            {
                _intentos = value;
            }
        }

        public int Numero
        {
            get
            {
                return _numero;
            }
            set
            {
                _numero = value;
            }
        }

        public bool Comparar(int numero_jugador)
        {
            Intentos++;
            if (numero_jugador == Numero)
            {
                Adivino = true;
            }
            return Adivino;
        }
    }
}
    
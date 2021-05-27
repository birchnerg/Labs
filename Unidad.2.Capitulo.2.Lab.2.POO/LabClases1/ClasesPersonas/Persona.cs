using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesPersonas
{
    public class Persona
    {
        string _nombre;
        string _apellido;
        int _año;
        int _mes;
        int _dia;
        int _dni;
        public Persona(string nombre, string apellido, int año, int mes, int dia, int dni)
        {
            _nombre = nombre;
            _apellido = apellido;
            _año = año;
            _mes = mes;
            _dia = dia;
            _dni = dni;
            Console.WriteLine("Instancia de persona creada con exito. Presione una tecla.");
            Console.ReadKey();
        }
        ~Persona()
        {
            Console.WriteLine("Instancia eliminada. Presione una tecla");
            Console.ReadKey();
        }
        public string Nombre
        {
            get
            {
                return _nombre;
            }
            set
            {
                _nombre = value;
            }
        }
        public string Apellido
        {
            get
            {
                return _apellido;
            }
            set
            {
                _apellido = value;
            }
        }
        public int Año
        {
            get
            {
                return _año;
            }
            set
            {
                _año = value;
            }
        }
        public int Mes
        {
            get
            {
                return _mes;
            }
            set
            {
                _mes = value;
            }
        }
        public int Dia
        {
            get
            {
                return _dia;
            }
            set
            {
                _dia = value;
            }
        }
        public int Dni
        {
            get
            {
                return _dni;
            }
            set
            {
                _dni = value;
            }
        }
        public string GetFullName()
        {
            return (_nombre + " " + _apellido);
        }
        public int GetAge()
        {
            int edad = 0;
            DateTime fechaActual = DateTime.Today;
            string nacimiento_string = (_dia.ToString()+"/"+ _mes.ToString()+"/"+_año.ToString() );
            DateTime fechaNacimiento = DateTime.Parse(nacimiento_string);
            edad = fechaActual.Year - fechaNacimiento.Year;
            if (fechaActual.Month < fechaNacimiento.Month)
            {
                edad = edad - 1;
            }
            if (fechaActual.Month == fechaNacimiento.Month)
            {
                if (fechaActual.Day < fechaNacimiento.Day)
                {
                    edad = edad - 1;
                }             
            }
            return edad;
        }
    }
}
    
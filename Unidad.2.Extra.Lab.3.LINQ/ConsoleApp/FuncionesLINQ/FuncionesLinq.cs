using System;
using System.Collections.Generic;
using System.Linq;

namespace FuncionesLINQ
{
    public class FuncionesLinq
    {
        public IEnumerable<string> ObtenerProvinciasQueEmpiezanConDeterminadasLetras(IEnumerable<string> provincias)
        {
            var provincias_filtradas = from provincia in provincias
                                                       where provincia.StartsWith("S") || provincia.StartsWith("T")
                                                       select provincia;
            return provincias_filtradas;
        }

        public IEnumerable<int> ObtenerNumerosMayoresA20(IEnumerable<int> numeros)
        {
            {
                var mayores_a_20 = from numero in numeros
                                           where numero > 20
                                           select numero;
                return mayores_a_20;
            }
        }

        public IEnumerable<int> ObtenerCodigoPostalDeCiudadesQueTenganEnSuNombreTresCarateresDeterminados(IEnumerable<Ciudad> ciudades, string ciudad)
        {
            {
                var ciudades_filtradas = from _ciudad in ciudades
                                         where _ciudad.Nombre.ToLower().Contains(ciudad)
                                         select _ciudad.CodigoPostal;
                return ciudades_filtradas;
            }
        }

        public IEnumerable<Empleado> AgregarEmpleadoListaDevolviendolaOrdenadaPorSueldo(IEnumerable<Empleado> empleados, IEnumerable<Empleado> empleadosParaAgregar, string order)
        {   

            List<Empleado> empleados_extendida = new List<Empleado>(empleados);
            empleados_extendida.AddRange(empleadosParaAgregar);
            IEnumerable<Empleado> empleados_ordenados = null;
            if (order == "ASC")
            {
                 empleados_ordenados = from _empleado in empleados_extendida
                                       orderby _empleado.Sueldo
                                       select _empleado;
            }
            else
            {
                 empleados_ordenados = from _empleado in empleados_extendida
                                       orderby _empleado.Sueldo descending
                                       select _empleado;
            }           
            return empleados_ordenados;
        }
    }
}

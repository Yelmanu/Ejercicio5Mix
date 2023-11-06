using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5Mix.Servicios
{
    internal class PedirMesAnyoImplementacion : PedirMesAnyoInterfaz
    {
        /// <summary>
        /// Método que se encarga de pedir el mes en número al usuario
        /// 061123 - MDN
        /// </summary>
        /// <returns></returns>
        public int pedirMes()
        {
            int mes;
            Console.WriteLine("Introduzca un mes del anyo (en número): ");
            mes = Convert.ToInt32(Console.ReadLine());
            return mes;
        }

        /// <summary>
        /// Método que se encarga de pedir el año al usuario
        /// 061123 - MDN
        /// </summary>
        /// <returns></returns>
        public int pedirAnyo()
        {
            int anyo;
            Console.WriteLine("Introduzca un año: ");
            anyo = Convert.ToInt32(Console.ReadLine());
            return anyo;
        }
    }
}

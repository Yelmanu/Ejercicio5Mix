using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5Mix.Servicios
{
    /// <summary>
    /// Interfaz que se encarga de la operativa de la aplicación
    /// 061123 - MDN
    /// </summary>
    internal interface OperativaInterfaz
    {
        /// <summary>
        /// Método que se encargara de recoger el mes y el año introducido por el usuario y mostrar los dias de ese mes
        /// 061123 - MDN
        /// </summary>
        /// <param name="mes"></param>
        /// <param name="anyo"></param>
        public void mostrarDias(int mes, int anyo);
    }
}

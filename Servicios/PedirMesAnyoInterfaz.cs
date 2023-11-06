using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5Mix.Servicios
{
    /// <summary>
    /// Interfaz que se encargara de solicitar el mes y el año al usuario
    /// </summary>
    internal interface PedirMesAnyoInterfaz
    {
        /// <summary>
        /// Método para pedir mes al usuario
        /// 061123 - MDN
        /// </summary>
        /// <returns></returns>
        public int pedirMes();

        /// <summary>
        /// Método para pedir año al usuario
        /// 061123 - MDN
        /// </summary>
        /// <returns></returns>
        public int pedirAnyo();
    }
}

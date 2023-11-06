using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5Mix.Servicios
{
    internal class OperativaImplementacion : OperativaInterfaz
    {
        public void mostrarDias(int mes, int anyo)
        {
            if (anyo%4 == 0 && anyo%100 == 0 && anyo%400 == 0)
            {
                Console.WriteLine("El año es bisiesto");
                switch (mes)
                {
                    case 1:
                        Console.WriteLine("el mes {0} en el año {1} tiene 31 dias", mes, anyo);
                        break;
                    case 2:
                        Console.WriteLine("el mes {0} en el año {1} tiene 29 dias",mes, anyo);
                        break;
                    case 3:
                        Console.WriteLine("el mes {0} en el año {1} tiene 31 dias", mes, anyo);
                        break;
                    case 4:
                        Console.WriteLine("El mes {0} en el año {1} tiene 30 dias",mes, anyo);
                        break;
                    case 5:
                        Console.WriteLine("el mes {0} en el año {1} tiene 31 dias", mes, anyo);
                        break;
                    case 6:
                        Console.WriteLine("El mes {0} en el año {1} tiene 30 dias", mes, anyo);
                        break;
                    case 7:
                        Console.WriteLine("el mes {0} en el año {1} tiene 31 dias", mes, anyo);
                        break;
                    case 8:
                        Console.WriteLine("el mes {0} en el año {1} tiene 31 dias", mes, anyo);
                        break;
                    case 9:
                        Console.WriteLine("El mes {0} en el año {1} tiene 30 dias", mes, anyo);
                        break;
                    case 10:
                        Console.WriteLine("el mes {0} en el año {1} tiene 31 dias", mes, anyo);
                        break;
                    case 11:
                        Console.WriteLine("El mes {0} en el año {1} tiene 30 dias", mes, anyo);
                        break;
                    case 12:
                        Console.WriteLine("el mes {0} en el año {1} tiene 31 dias", mes, anyo);
                        break;
                    default:
                        Console.WriteLine("El mes introducido no es correcto");
                        break;

                }
            }
            else
            {
                Console.WriteLine("El año no es bisiesto");
                switch (mes)
                {
                    case 1:
                        Console.WriteLine("el mes {0} en el año {1} tiene 31 dias", mes, anyo);
                        break;
                    case 2:
                        Console.WriteLine("el mes {0} en el año {1} tiene 28 dias", mes, anyo);
                        break;
                    case 3:
                        Console.WriteLine("el mes {0} en el año {1} tiene 31 dias", mes, anyo);
                        break;
                    case 4:
                        Console.WriteLine("El mes {0} en el año {1} tiene 30 dias", mes, anyo);
                        break;
                    case 5:
                        Console.WriteLine("el mes {0} en el año {1} tiene 31 dias", mes, anyo);
                        break;
                    case 6:
                        Console.WriteLine("El mes {0} en el año {1} tiene 30 dias", mes, anyo);
                        break;
                    case 7:
                        Console.WriteLine("el mes {0} en el año {1} tiene 31 dias", mes, anyo);
                        break;
                    case 8:
                        Console.WriteLine("el mes {0} en el año {1} tiene 31 dias", mes, anyo);
                        break;
                    case 9:
                        Console.WriteLine("El mes {0} en el año {1} tiene 30 dias", mes, anyo);
                        break;
                    case 10:
                        Console.WriteLine("el mes {0} en el año {1} tiene 31 dias", mes, anyo);
                        break;
                    case 11:
                        Console.WriteLine("El mes {0} en el año {1} tiene 30 dias", mes, anyo);
                        break;
                    case 12:
                        Console.WriteLine("el mes {0} en el año {1} tiene 31 dias", mes, anyo);
                        break;
                    default:
                        Console.WriteLine("El mes introducido no es correcto");
                        break;
                }
            }
        }
    }
}

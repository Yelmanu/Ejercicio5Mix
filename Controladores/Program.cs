using Ejercicio5Mix.Servicios;

namespace Ejercicio5Mix.Controladores
{
    class Program
    {
        static public void Main(string[] args)
        {
            //Declaramos las variables
            int mes, anyo;
            char respuesta;

            //Llamamos a las clases que contienen los métodos
            PedirMesAnyoInterfaz pmai = new PedirMesAnyoImplementacion();
            OperativaInterfaz oi = new OperativaImplementacion();

            //bucle para controlar la continuidad o no de la aplicación
            do
            {
                //Pedimos el mes y el anyo
                anyo = pmai.pedirAnyo();
                mes = pmai.pedirMes();

                //Realizamos la muestra de los dias
                oi.mostrarDias(mes, anyo);

                //Preguntamos si quiere seguir usando la aplicación
                Console.WriteLine("¿Quiere hacer otra consulta? (s=si otra tecla=no) ");
                respuesta = Convert.ToChar(Console.ReadLine());
            } while (respuesta == 's');
        }
    }
}
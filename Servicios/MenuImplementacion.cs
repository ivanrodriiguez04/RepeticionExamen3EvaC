using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeticionExamenC.Servicios
{
    /// <summary>
    /// Clase que implementa a la interfaz de los menus de la aplicacion
    /// irodhan -> 05/03/2024
    /// </summary>
    internal class MenuImplementacion : MenuInterfaz
    {
        public int mostrarMenuYSeleccion()
        {
            Console.WriteLine("|------------------------|");
            Console.WriteLine("|          Menú          |");
            Console.WriteLine("|________________________|");
            Console.WriteLine("| 0. Cerrar aplicacion   |");
            Console.WriteLine("| 1. Menu Gerencia       |");
            Console.WriteLine("| 2. Menu Empleados      |");
            Console.WriteLine("|________________________|");
            Console.WriteLine("\nIntroduzca la opcion deseada:");
            int opcion = Console.ReadKey(true).KeyChar - ('0');
            return opcion;
        }

        public int mostrarMenuYSeleccionEmpleados()
        {
            Console.WriteLine("|---------------------------|");
            Console.WriteLine("|      Menú  Empleados      |");
            Console.WriteLine("|___________________________|");
            Console.WriteLine("| 0. Salir                  |");
            Console.WriteLine("| 1. Añadir ventas          |");
            Console.WriteLine("| 2. Calculo total ventas   |");
            Console.WriteLine("|___________________________|");
            Console.WriteLine("\nIntroduzca la opcion deseada:");
            int opcion = Console.ReadKey(true).KeyChar - ('0');
            return opcion;
        }

        public int mostrarMenuYSeleccionGerencia()
        {
            Console.WriteLine("|-------------------------------|");
            Console.WriteLine("|        Menú  Gerencia         |");
            Console.WriteLine("|_______________________________|");
            Console.WriteLine("| 0. Salir                      |");
            Console.WriteLine("| 1. Escribir un fichero        |");
            Console.WriteLine("| 2. Nuevo pedido proveedores   |");
            Console.WriteLine("|_______________________________|");
            Console.WriteLine("\nIntroduzca la opcion deseada:");
            int opcion = Console.ReadKey(true).KeyChar - ('0');
            return opcion;
        }
    }
}

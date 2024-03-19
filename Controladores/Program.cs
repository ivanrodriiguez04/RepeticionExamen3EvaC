using RepeticionExamenC.Dtos;
using RepeticionExamenC.Servicios;

namespace RepeticionExamenC.Controladores
{
    /// <summary>
    /// Clase principal de la aplicacion
    /// irodhan -> 05/03/2024
    /// </summary>
    class Program
    {
        //Atributos
        static int opcionSeleccionada = 0;
        //Objetos 
        static MenuInterfaz mI=new MenuImplementacion();
        static OperacionalEmpleadosInterfaz oE = new OperacionalEmpleadosImplementacion();
        static OperacionalGerenciaInterfaz oG = new OperacionalGerenciaImplementacion();
        //Listas
        static List<VentasDto> listaVentas = new List<VentasDto>();

        /// <summary>
        /// Método principal de la aplicacion
        /// irodhan -> 05/03/2024
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Atributos
            bool cerrarMenu=false;

            //Bucle de la aplicacion
            while(!cerrarMenu) 
            {
                //Obtenemos la opcion deseada por el usuario
                opcionSeleccionada = mI.mostrarMenuYSeleccion();
                //Creamos un switch a través de la opcion del usuario
                switch(opcionSeleccionada) 
                { 
                    case 0:
                        Console.WriteLine("[INFO] - Ha selccionada la opcion 0");
                        Console.WriteLine("[INFO] - La aplicacion se va a cerrar");
                        cerrarMenu = true;
                        break;
                    case 1:
                        Console.WriteLine("[INFO] - Ha seleccionado la opcion 1");
                        menuGerencia();
                        break;
                    case 2:
                        Console.WriteLine("[INFO] - Ha seleccionado la opcion 2");
                        menuEmpleados();
                        break;
                    default:
                        Console.WriteLine("[INFO] - La opcion seleccionada no coincide con ninguna opcion mostrada anteriormente");
                        break;
                }
            }
        }

        /// <summary>
        /// Metodo que muestra el menu de la gerencia y sus opciones
        /// irodhan -> 05/03/2024
        /// </summary>
        static void menuGerencia() 
        {
            //Obtenemos la opcion deseada por el usuario
            opcionSeleccionada = mI.mostrarMenuYSeleccionGerencia();
            //Creamos un switch a través de la opcion del usuario
            switch (opcionSeleccionada) 
            {
                case 0:
                    Console.WriteLine("[INFO] - Ha seleccionado la opcion la opcion 0");
                    Console.WriteLine("[INFO] -  Se va a volver al menu principal");
                    break;
                case 1:
                    Console.WriteLine("[INFO] - Ha seleccionado la opcion 1");
                    oG.crearFichero(listaVentas);
                    break;
                case 2:
                    Console.WriteLine("[INFO] - Ha seleccionado la opcion 2");
                    oG.nuevoPedidoProveedor();
                    break;
                default:
                    Console.WriteLine("[INFO] - La opcion seleccionada no coincide con ninguna opcion mostrada anteriormente");
                    break;
            }
        }

        /// <summary>
        /// Metodo que muestra el menu de los empleados y sus opciones
        /// irodhan -> 05/03/2024
        /// </summary>
        static void menuEmpleados() 
        {
            //Obtenemos la opcion deseada por el usuario
            opcionSeleccionada = mI.mostrarMenuYSeleccionEmpleados();
            //Creamos un switch a través de la opcion del usuario
            switch (opcionSeleccionada)
            {
                case 0:
                    Console.WriteLine("[INFO] - Ha seleccionado la opcion la opcion 0");
                    Console.WriteLine("[INFO] -  Se va a volver al menu principal");
                    break;
                case 1:
                    Console.WriteLine("[INFO] - Ha seleccionado la opcion 1");
                    oE.anadirVentas(listaVentas);
                    break;
                case 2:
                    Console.WriteLine("[INFO] - Ha seleccionado la opcion 2");
                    oE.calculoTotalVentas(listaVentas);
                    break;
                default:
                    Console.WriteLine("[INFO] - La opcion seleccionada no coincide con ninguna opcion mostrada anteriormente");
                    break;
            }
        }
    }
}

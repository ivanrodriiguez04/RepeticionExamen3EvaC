using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeticionExamenC.Servicios
{
    /// <summary>
    /// Interfaz de los menus de la aplicacion
    /// irodhan -> 05/03/2024
    /// </summary>
    internal interface MenuInterfaz
    {
        /// <summary>
        /// Metodo que muestra el menu principaly obtiene la opcion que el usuario indica
        /// irodhan -> 05/03/2024
        /// </summary>
        /// <returns></returns>
        public int mostrarMenuYSeleccion();
        /// <summary>
        /// Metodo que muestra el menu de los empleados y obtiene la opcion que el usuario indica
        /// irodhan -> 05/03/2024
        /// </summary>
        /// <returns></returns>
        public int mostrarMenuYSeleccionEmpleados();
        /// <summary>
        /// Metodo que muestra el menu de la gerenciay obtiene la opcion que el usuario indica
        /// irodhan -> 05/03/2024
        /// </summary>
        /// <returns></returns>
        public int mostrarMenuYSeleccionGerencia();
    }
}

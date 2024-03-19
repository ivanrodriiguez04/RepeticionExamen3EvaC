using RepeticionExamenC.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeticionExamenC.Servicios
{
    internal interface OperacionalEmpleadosInterfaz
    {
        /// <summary>
        /// Metodo que añade las ventas de la tienda
        /// irodhan -> 05/03/2024
        /// </summary>
        public void anadirVentas(List<VentasDto> listaVentas);

        /// <summary>
        /// metodo que hace el calculo total de las ventas del dia especificado
        /// irodhan -> 05/03/2024
        /// </summary>
        public void calculoTotalVentas(List<VentasDto>listaVentas);
    }
}

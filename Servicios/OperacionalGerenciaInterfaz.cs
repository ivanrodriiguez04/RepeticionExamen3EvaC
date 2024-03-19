using RepeticionExamenC.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeticionExamenC.Servicios
{
    /// <summary>
    /// Interfaz de las operaciones de la gerencia 
    /// irodhan -> 05/03/2024
    /// </summary>
    internal interface OperacionalGerenciaInterfaz
    {
        /// <summary>
        /// Método que escribe en un fichero la informacion necesaria
        /// irodhan -> 05/03/2024
        /// </summary>
        public void crearFichero(List<VentasDto> listaVentas);

        /// <summary>
        /// Método que hace un nuevo pedido de productos al proveedor
        /// irodhan -> 05/03/2024
        /// </summary>
        public void nuevoPedidoProveedor();

    }
}

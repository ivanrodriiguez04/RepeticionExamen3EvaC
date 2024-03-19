using RepeticionExamenC.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeticionExamenC.Servicios
{
    /// <summary>
    /// Clase que implementa a la interfaz de las operaciones de la gerencia
    /// irodhan -> 05/03/2024
    /// </summary>
    internal class OperacionalGerenciaImplementacion : OperacionalGerenciaInterfaz
    {
        public void crearFichero(List<VentasDto> listaVentas)
        {
            Console.WriteLine("Fecha a consulta (dd-MM-yyyy): ");
            string fechaConsultar=Console.ReadLine();
            string contenidoFichero = crearContenido(listaVentas, fechaConsultar);

            StreamWriter sw = new StreamWriter(fechaConsultar.Replace("-","")+".txt");
            escribirFichero(sw, contenidoFichero);
            sw.Close();
        }
        /// <summary>
        /// Metodo que escribe el contenido dentro del fichero
        /// irodhan -> 05/03/2024
        /// </summary>
        /// <param name="sw"></param>
        /// <param name="contenido"></param>
        private void escribirFichero(StreamWriter sw, string contenido) 
        { 
            sw.Write(contenido);
        }
        /// <summary>
        /// Metodo que crea el contenido que se va a escribir en el fichero
        /// irodhan -> 05/03/2024
        /// </summary>
        /// <param name="listaVentas"></param>
        /// <param name="fechaConsulta"></param>
        private string crearContenido(List<VentasDto> listaVentas,string fechaConsultar) 
        {
            string contenido = "";
            foreach(VentasDto venta in listaVentas) 
            { 
                string fechaVenta=venta.FchInstanteVenta.ToString("dd-MM-yyyy");
                if (fechaVenta.Equals(fechaConsultar)) 
                { 
                    contenido=contenido+venta.ToString();
                }
            }
            return contenido;
        }

        public void nuevoPedidoProveedor()
        {
            List<ProductoDto> listaProducto = new List<ProductoDto>();
            string confirmacion="";
            do 
            {
                ProductoDto pedido = new ProductoDto();
                pedido.IdPedido = calculoId(listaProducto);
                Console.WriteLine("Introduzca el producto que necesita:");
                pedido.NombreProducto = Console.ReadLine();
                Console.WriteLine("Introduzca la cantidad que necesita:");
                pedido.CantidadProducto=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Introduzca el dia que desea la entrega(dd-MM-yyyy)");
                pedido.FchEntrega = Console.ReadLine();
                Console.WriteLine("Desea hacer otro pedido:(si || no)");
                confirmacion = Console.ReadLine();
                listaProducto.Add(pedido);
            } while (confirmacion.Equals("si"));

            foreach (ProductoDto pedidos in listaProducto) 
            {
                Console.WriteLine(pedidos.ToString());
            }
        }
        private long calculoId(List<ProductoDto> listaProducto)
        {
            long nuevoId;
            int tamañoLista = listaProducto.Count;
            if (tamañoLista > 0)
            {
                nuevoId = listaProducto[tamañoLista - 1].IdPedido + 1;
            }
            else
            {
                nuevoId = 1;
            }
            return nuevoId;
        }
    }
}

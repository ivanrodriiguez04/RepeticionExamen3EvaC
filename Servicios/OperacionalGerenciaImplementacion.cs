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
        public void escribirFichero(List<ProductoDto> listaProductoAntigua)
        {
            throw new NotImplementedException();
        }

        public void nuevoPedidoProveedor(List<ProductoDto> listaProductoAntigua)
        {
            ProductoDto pedido= new ProductoDto();
            string confirmacion;
            do 
            {
                pedido.IdPedido = calcularId();
                Console.WriteLine("Introduzca el producto que necesita:");
                pedido.NombreProducto = Console.ReadLine();
                Console.WriteLine("Introduzca la cantidad que necesita:");
                pedido.CantidadProducto=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Introduzca el dia que desea la entrega(dd-MM-yyyy)");
                pedido.FchEntrega = Console.ReadLine();
                Console.WriteLine("Desea hacer otro pedido:(si || no)");
                confirmacion = Console.ReadLine();
                listaProductoAntigua.Add(pedido);
            } while (confirmacion.Equals("si"));
            //Recorremos la lista para mostrar todos los pedidos
            foreach (ProductoDto pedidos in listaProductoAntigua)
            {
                for (int i=0;i<listaProductoAntigua.Count;i++) 
                { 
                    if(pedido.)
                }
                Console.WriteLine(pedidos.ToString());
            }
        }
    }
}

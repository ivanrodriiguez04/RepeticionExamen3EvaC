using Microsoft.VisualBasic;
using RepeticionExamenC.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeticionExamenC.Servicios
{
    /// <summary>
    /// Clase que implementa a la interfaz de las operaciones de los empleados
    /// irodhan -> 05/03/2024
    /// </summary>
    internal class OperacionalEmpleadosImplementacion : OperacionalEmpleadosInterfaz
    {
        public void anadirVentas(List<VentasDto> listaVentas)
        {
            VentasDto ventas = new VentasDto();
            ventas.IdVenta = calculoId(listaVentas);
            Console.WriteLine("Introduzca el importe de la venta: ");
            double importeVentaFacilitado = Convert.ToDouble(Console.ReadLine());
            ventas.ImporteVenta=importeVentaFacilitado;
            listaVentas.Add(ventas);
        }

        public void calculoTotalVentas(List<VentasDto> listaVentas)
        {
            Console.WriteLine("Fecha a consulta (dd-MM-yyyy): ");
            string fchConsulta=Console.ReadLine();
            
            List<DateTime> listaFechaVentas=new List<DateTime>();
            
            foreach(VentasDto venta in listaVentas) 
            {
                string fchVenta = venta.FchInstanteVenta.ToString("dd-MM-yyyy");
                if (fchVenta.Equals(fchConsulta)) 
                { 
                    
                }
            }
        }

        private long calculoId(List<VentasDto>listaVentas) 
        {
            long nuevoId;
            int tamañoLista=listaVentas.Count;
            if (tamañoLista > 0)
            {
                nuevoId = listaVentas[tamañoLista - 1].IdVenta + 1;
            }
            else 
            { 
                nuevoId=1;
            }
            return nuevoId;
        }
    }
}

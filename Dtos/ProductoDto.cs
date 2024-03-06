using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeticionExamenC.Dtos
{
    /// <summary>
    /// Clase que contiene los dtos de los productos
    /// irodhan -> 05/03/2024
    /// </summary>
    internal class ProductoDto
    {
        //Atributos
        long idPedido;
        string nombreProducto = "aaaaa";
        int cantidadProducto = 0;
        string fchEntrega="aaaaa";
        //Constructores
        public ProductoDto(string nombreProducto, int cantidadProducto, string fchEntrega, long idPedido)
        {
            this.nombreProducto = nombreProducto;
            this.cantidadProducto = cantidadProducto;
            this.fchEntrega = fchEntrega;
            this.idPedido = idPedido;
        }
        public ProductoDto() 
        { 
        }

        //Getters & Setters
        public string NombreProducto { get => nombreProducto; set => nombreProducto = value; }
        public int CantidadProducto { get => cantidadProducto; set => cantidadProducto = value; }
        public string FchEntrega { get => fchEntrega; set => fchEntrega = value; }
        public long IdPedido { get => idPedido; set => idPedido = value; }

        //Metodos
        public string ToString() 
        {
            string concatenacion = 
                "Producto: "+this.nombreProducto
                +"\nCantidad: "+this.cantidadProducto
                +"\nFecha entrega: "+this.fchEntrega;
            return concatenacion;
        }
    
    }
}

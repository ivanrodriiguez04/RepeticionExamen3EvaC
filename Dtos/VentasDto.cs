using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeticionExamenC.Dtos
{
    /// <summary>
    /// Clase que contiene los dto de las ventas
    /// irodhan -> 05/03/2024
    /// </summary>
    internal class VentasDto
    {
        //Atributos
        long idVenta;
        double importeVenta = 0;
        DateTime fchInstanteVenta = DateTime.Now;

        //Getters & Setters
        public long IdVenta { get => idVenta; set => idVenta = value; }
        public double ImporteVenta { get => importeVenta; set => importeVenta = value; }
        public DateTime FchInstanteVenta { get => FchInstanteVenta; set => FchInstanteVenta = value; }
        
        //ToString 
        public string ToString() 
        {
            string concatenacion = ".........." +
                "\nVenta número: " + this.idVenta +
                "\nEuros: " + this.importeVenta +
                "\nInstante de compra: " + this.fchInstanteVenta +
                "\n.........."+"\n";
            return concatenacion;
        }

    }
}

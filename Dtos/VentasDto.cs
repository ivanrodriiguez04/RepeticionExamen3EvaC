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
        int dineroVenta = 0;
        DateTime fchVenta = DateTime.Now;
        
        //Constructores
        public VentasDto(long idVenta, int dineroVenta, DateTime fchVenta)
        {
            this.idVenta = idVenta;
            this.dineroVenta = dineroVenta;
            this.fchVenta = fchVenta;
        }
        public VentasDto() 
        { 
        
        }

        //Getters & Setters
        public long IdVenta { get => idVenta; set => idVenta = value; }
        public int DineroVenta { get => dineroVenta; set => dineroVenta = value; }
        public DateTime FchVenta { get => fchVenta; set => fchVenta = value; }


    }
}

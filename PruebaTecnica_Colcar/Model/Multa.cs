using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnica_Colcar.Model
{
    public class Multa
    {
       public  string identificador_infraccion { get; set; }
       public int dni { get; set; } 
       public DateTime fecha_infraccion { get; set; }
       public double importe { get; set; }
       public DateTime? fecha_pago { get; set; }

        public Multa(string identificador, int dni, DateTime fechaInfraccion, double importe, DateTime? fechaPago)
        {
            this.identificador_infraccion = identificador;
            this.dni = dni;
            this.fecha_infraccion = fechaInfraccion;
            this.importe = importe;
            this.fecha_pago = fechaPago;
        }
        public Multa( )
        {
                
        }

    }
}

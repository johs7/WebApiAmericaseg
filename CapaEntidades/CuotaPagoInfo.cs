using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class CuotaPagoInfo
    {
        public int NoRecibo { get; set; }
        public int NoCuota { get; set; }
        public int NoSubCuota { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public decimal MontoCuota { get; set; }
        public int NoPago { get; set; }
        public DateTime FechaCaja { get; set; }
        public decimal MontoPagado { get; set; }
        public int NoCaja { get; set; }
        public int EstadoCuenta { get; set; }
    }
}

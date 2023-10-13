using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class InformacionReciboDetalle
    {
        public int NoRecibo { get; set; }
        public string Cliente { get; set; }
        public string Ramo { get; set; }
        public string Plan { get; set; }
        public decimal MontoTotal { get; set; }
        public decimal Pagado { get; set; }
        public decimal Pendiente { get; set; }
        public string Mora { get; set; }
    }

}

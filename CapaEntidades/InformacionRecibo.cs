using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class InformacionRecibo
    {
        public int NoRecibo { get; set; }
        public DateTime FechaEmision { get; set; }
        public string Ramo { get; set; }
        public string Plan { get; set; }
        public int CodigoTenedor { get; set; }
        public int CantidadCoberturasSuman { get; set; }
        public decimal MontoPrima { get; set; }
        public decimal MontoImpuesto { get; set; }
        public decimal MontoDerechoEmision { get; set; }
        public decimal MontoTotal { get; set; }
        public decimal Pagado { get; set; }
        public decimal Pendiente { get; set; }
        public int CantidadCuotasPendientes { get; set; }
        public string Vigencia { get; set; }

    }
}

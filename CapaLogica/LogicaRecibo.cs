using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CapaDatos;
using System.Threading.Tasks;
using CapaEntidades;

namespace CapaLogica
{
    public class LogicaRecibo
    {
        public static InformacionRecibo ObtenerInformacionRecibo(int noRecibo)
        {
            // Llama a la capa de datos para obtener la información del recibo
            return InformacionReciboData.Obtener(noRecibo);
        }

        public static CuotaPagoInfo ObtenerInformacionCuotas(int noRecibo)
        {
            // Llama a la capa de datos para obtener la información de cuotas
            return CuotaPagoInfoData.Obtener(noRecibo);
        }

        public static InformacionReciboDetalle ObtenerDetalles(int noRecibo)
        {
            return InformacionReciboDetalladaData.ObtenerInformacionReciboDetallada(noRecibo);
        }
      
    }
}

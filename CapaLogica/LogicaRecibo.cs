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

        public static string CalcularDiasDeMora(int noRecibo, DateTime fechaActual)
        {
            // Obtén la información del recibo
            InformacionRecibo informacionRecibo = ObtenerInformacionRecibo(noRecibo);

            // Implementa la lógica para calcular los días de mora
            if (informacionRecibo == null)
            {
                return "Recibo no encontrado";
            }

            DateTime fechaVencimiento = informacionRecibo.FechaEmision; // Debes usar la fecha de vencimiento real del recibo

            int diasDeMora = (fechaActual - fechaVencimiento).Days;

            if (diasDeMora <= 0)
            {
                return "Al Corriente";
            }
            else if (diasDeMora <= 30)
            {
                return "Mora de 1 a 30 días";
            }
            else if (diasDeMora <= 60)
            {
                return "Mora de 31 a 60 días";
            }
            else if (diasDeMora <= 90)
            {
                return "Mora de 61 a 90 días";
            }
            else
            {
                return "Mora más de 90 días";
            }
        }
    }

}

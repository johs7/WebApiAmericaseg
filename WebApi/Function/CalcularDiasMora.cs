using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApi.Data;
using WebApi.Models;

namespace WebApi.Function
{
    public class CalcularDiasMora
    {
        public static string CalculateDaysOfMora(int noRecibo, DateTime currentDate)
        {
            CuotaPagoInfo cuotaPagoInfo = CuotaPagoInfoData.Obtener(noRecibo);
          

            if (cuotaPagoInfo == null)
            {
                return "Recibo no encontrado"; // Mensaje para indicar que el recibo no fue encontrado
            }

            DateTime lastPaymentDate = cuotaPagoInfo.FechaCaja;
            int daysOfMora = (currentDate - lastPaymentDate).Days;

            return daysOfMora <= 0 ? "Al Corriente" :
                   daysOfMora <= 30 ? "Mora de 1 a 30 días" :
                   daysOfMora <= 60 ? "Mora de 31 a 60 días" :
                   daysOfMora <= 90 ? "Mora de 61 a 90 días" :
                   "Mora más de 90 días";
        }


    }
}
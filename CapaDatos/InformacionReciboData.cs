using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
   public class InformacionReciboData
    {
        public static InformacionRecibo Obtener(int noRecibo)
        {
            InformacionRecibo oRecibo = new InformacionRecibo();
            using (SqlConnection connection = new SqlConnection(Conexion.conection))
            {

                SqlCommand cmd = new SqlCommand("ObtenerInformacionRecibo", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NoRecibo", noRecibo);
                try
                {
                    connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Mapea los resultados a un objeto InformacionRecibo
                            oRecibo = new InformacionRecibo
                            {
                                NoRecibo = (int)reader["NoRecibo"],
                                FechaEmision = (DateTime)reader["Fecha Emisión"],
                                Ramo = reader["Ramo"].ToString(),
                                Plan = reader["Plan"].ToString(),
                                CodigoTenedor = (int)reader["Código del Tenedor"],
                                CantidadCoberturasSuman = (int)reader["Cantidad de Coberturas Suman"],
                                MontoPrima = (decimal)reader["Monto de Prima"],
                                MontoImpuesto = (decimal)reader["Monto Impuesto"],
                                MontoDerechoEmision = (decimal)reader["Monto Derecho Emisión"],
                                MontoTotal = (decimal)reader["Monto Total"],
                                Pagado = (decimal)reader["Pagado"],
                                Pendiente = (decimal)reader["Pendiente"],
                                CantidadCuotasPendientes = (int)reader["Cantidad Cuotas Pendientes"],
                                Vigencia = reader["Vigencia"].ToString()

                            };

                        }
                    }
                    return oRecibo;
                }
                catch (Exception ex)
                {
                    return oRecibo;
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;

namespace CapaDatos
{
   public class CuotaPagoInfoData
    {
        public static CuotaPagoInfo Obtener(int noRecibo)
        {
            CuotaPagoInfo oCuotaPago = new CuotaPagoInfo();
            using (SqlConnection connection = new SqlConnection(Conexion.conection))
            {
                SqlCommand cmd = new SqlCommand("ListarCuotasYPagos", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NoRecibo", noRecibo);
                try
                {
                    connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            oCuotaPago = new CuotaPagoInfo
                            {
                                NoRecibo = (int)reader["NoRecibo"],
                                NoCuota = (int)reader["No Cuota"],
                                NoSubCuota = (int)reader["No SubCuota"],
                                FechaVencimiento = (DateTime)reader["Fecha Vencimiento"],
                                MontoCuota = (decimal)reader["Monto Cuota"],
                                NoPago = (int)reader["No Pago"],
                                FechaCaja = (DateTime)reader["Fecha Caja"],
                                MontoPagado = (decimal)reader["Monto Pagado"],
                                NoCaja = (int)reader["No Caja"],
                                EstadoCuenta = (int)reader["Estado de Cuenta"]
                            };

                        }
                    }
                    return oCuotaPago;
                }
                catch (Exception ex)
                {
                    // Handle the exception appropriately, e.g., logging or re-throwing
                    return oCuotaPago; // Returning an empty list may be suitable
                }
            }
        }
    }
}

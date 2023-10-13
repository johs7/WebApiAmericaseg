using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using CapaEntidades;

namespace CapaDatos
{
    public class InformacionReciboDetalladaData
    {
        public static InformacionReciboDetalle ObtenerInformacionReciboDetallada(int noRecibo)
        {
            InformacionReciboDetalle oDetallada = new InformacionReciboDetalle();
            using (SqlConnection connection = new SqlConnection(Conexion.conection))
            {
                SqlCommand cmd = new SqlCommand("Sp_ObtenerInformacionReciboDetallada", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NoRecibo", noRecibo);
                try
                {
                    connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            oDetallada = new InformacionReciboDetalle
                            {
                            NoRecibo = (int)reader["Numero de Recibo"],
                            Cliente = reader["Cliente"].ToString(),
                            Ramo = reader["Ramo"].ToString(),
                            Plan = reader["Plan"].ToString(),
                            MontoTotal = (decimal)reader["Monto Total"],
                            Pagado = (decimal)reader["Monto Pagado"],
                            Pendiente = (decimal)reader["Monto Pendiente"],
                            Mora = reader["Mora"].ToString(),
                        };
                    }
                    }
                    return oDetallada;
                }
                catch (Exception ex)
                {
                    // Maneja la excepción apropiadamente, por ejemplo, registrándola o volviéndola a lanzar
                    return oDetallada; // Devolver un objeto vacío puede ser adecuado
                }
            }
        }
    }
}

using ENTITY;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    namespace DAL
    {
    public class AlertaRepository
    {
        private readonly SqlConnection _connection;
        private const string cadenaConexion = "Server=.\\SQLEXPRESS;Database=SistemaAlertas;Trusted_Connection=True;";

        public AlertaRepository()
        {
            _connection = new SqlConnection(cadenaConexion);
        }

      
        public string InsertarAlerta(Alerta alerta)
        {
            string ssql = @"INSERT INTO [dbo].[Alertas]
                   ([IdAlerta]
                   ,[FechaHora]
                   ,[Latitud]

                   ,[Longitud]
                   ,[NombreTipoAlerta])
             VALUES
                   (@IdAlerta
                   ,@FechaHora
                   ,@Latitud
                   ,@Longitud
                   ,@NombreTipoAlerta)";

            try
            {
                using (SqlCommand cmd = new SqlCommand(ssql, _connection))
                {
                    cmd.Parameters.AddWithValue("@IdAlerta", alerta.Id);
                    cmd.Parameters.AddWithValue("@FechaHora", alerta.FechaHora);
                    cmd.Parameters.AddWithValue("@Latitud", alerta.obtenerLatitud(alerta.Ubicacion));
                    cmd.Parameters.AddWithValue("@Longitud", alerta.obtenerLongitud(alerta.Ubicacion));
                    cmd.Parameters.AddWithValue("@NombreTipoAlerta", alerta.Tipo.Nombre);

                    _connection.Open();
                    int filasAfectadas = cmd.ExecuteNonQuery();
                    _connection.Close();

                    return filasAfectadas > 0
                        ? $"Se agregó la alerta con ID {alerta.Id} correctamente"
                        : "No se pudo agregar la alerta";
                }
            }
            catch (Exception ex)
            {
                return $"Error al insertar alerta: {ex.Message}";
            }
        }

      
        public string EliminarAlerta(int idAlerta)
        {
            string ssql = "DELETE FROM [dbo].[Alertas] WHERE [IdAlerta] = @IdAlerta";

            try
            {
                using (SqlCommand cmd = new SqlCommand(ssql, _connection))
                {
                    cmd.Parameters.AddWithValue("@IdAlerta", idAlerta);

                    _connection.Open();
                    int filasAfectadas = cmd.ExecuteNonQuery();
                    _connection.Close();

                    return filasAfectadas > 0
                        ? $"Se eliminó la alerta con ID {idAlerta} correctamente"
                        : $"No se encontró ninguna alerta con ID {idAlerta}";
                }
            }
            catch (Exception ex)
            {
                return $"Error al eliminar la alerta: {ex.Message}";
            }
        }

      
        public List<Alerta> SeleccionarAlertas()
        {
            List<Alerta> alertas = new List<Alerta>();
            string ssql = "SELECT * FROM [dbo].[Alertas]";

            try
            {
                using (SqlCommand cmd = new SqlCommand(ssql, _connection))
                {
                    _connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            alertas.Add(MapearAlerta(reader));
                        }
                    }
                }
                return alertas;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al seleccionar alertas: {ex.Message}", ex);
            }
            finally
            {
                if (_connection.State == System.Data.ConnectionState.Open)
                    _connection.Close();
            }
        }
        
        
        private Alerta MapearAlerta(SqlDataReader reader)
        {
            var tipoNombre = reader.GetString(reader.GetOrdinal("NombreTipoAlerta"));
            TipoAlerta tipo;
            switch (tipoNombre)
            {
                case "Accidente":
                    tipo = TipoAlerta.Accidente;
                    break;
                case "Robo":
                    tipo = TipoAlerta.Robo;
                    break;
                case "Actividad Sospechosa":
                    tipo = TipoAlerta.ActividadSospechosa;
                    break;
                default:
                    throw new ArgumentException($"Tipo de alerta no válido: {tipoNombre}");
            }

            
            var coordenada = new Coordenada(
                Convert.ToDouble(reader.GetDecimal(reader.GetOrdinal("Latitud"))),
                Convert.ToDouble(reader.GetDecimal(reader.GetOrdinal("Longitud")))
            );

            var alerta = new Alerta(tipo, coordenada);
            alerta.Id = reader.GetInt32(reader.GetOrdinal("IdAlerta"));
            alerta.FechaHora = reader.GetDateTime(reader.GetOrdinal("FechaHora"));

            return alerta;
        }
    }
}

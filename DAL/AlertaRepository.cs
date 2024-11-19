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
        private const string cadenaConexion = "Server=.\\SQLEXPRESS;Database=grupo3;Trusted_Connection=True;";

        public AlertaRepository()
        {
            _connection = new SqlConnection(cadenaConexion);
        }

        public string Insertar(Alerta alerta)
        {
            string ssql = @"INSERT INTO [Alertas]([Descripcion],[FechaHora],[Ubicacion_Latitud],
                           [Ubicacion_Longitud],[UsuarioId],[Tipo]) 
                           VALUES(@Descripcion, @FechaHora, @Latitud, @Longitud, @UsuarioId, @Tipo)";

            try
            {
                using (SqlCommand cmd = new SqlCommand(ssql, _connection))
                {
                    cmd.Parameters.AddWithValue("@Descripcion", alerta.Descripcion);
                    cmd.Parameters.AddWithValue("@FechaHora", alerta.FechaHora);
                    cmd.Parameters.AddWithValue("@Latitud", alerta.Ubicacion.Latitud);
                    cmd.Parameters.AddWithValue("@Longitud", alerta.Ubicacion.Longitud);
                    cmd.Parameters.AddWithValue("@UsuarioId", alerta.UsuarioId);
                    cmd.Parameters.AddWithValue("@Tipo", alerta.Tipo.ToString());

                    _connection.Open();
                    int filasAfectadas = cmd.ExecuteNonQuery();
                    _connection.Close();

                    return filasAfectadas > 0
                        ? $"Se agregó la alerta correctamente"
                        : "No se pudo agregar la alerta";
                }
            }
            catch (Exception ex)
            {
                return $"Error al insertar alerta: {ex.Message}";
            }
            finally
            {
                if (_connection.State == System.Data.ConnectionState.Open)
                    _connection.Close();
            }
        }

        public List<Alerta> Seleccionar()
        {
            List<Alerta> alertas = new List<Alerta>();
            string ssql = "SELECT * FROM Alertas";

            try
            {
                using (SqlCommand cmd = new SqlCommand(ssql, _connection))
                {
                    _connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            alertas.Add(Mapper(reader));
                        }
                    }
                }
                return alertas;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (_connection.State == System.Data.ConnectionState.Open)
                    _connection.Close();
            }
        }

        private Alerta Mapper(SqlDataReader reader)
        {
            var tipo = (Alerta.TipoAlerta)Enum.Parse(typeof(Alerta.TipoAlerta),
                reader.GetString(reader.GetOrdinal("Tipo")));

            var coordenada = new Coordenada(
                reader.GetDouble(reader.GetOrdinal("Latitud")),
                reader.GetDouble(reader.GetOrdinal("Longitud"))
            );

            var alerta = new Alerta(
                tipo,
                reader.GetString(reader.GetOrdinal("Descripcion")),
                coordenada,
                reader.GetInt32(reader.GetOrdinal("UsuarioId"))
            );

            // Establecer el Id después de la creación
            var id = reader.GetInt32(reader.GetOrdinal("Id"));
            typeof(Alerta).GetProperty("Id").SetValue(alerta, id);

            return alerta;
        }
    }
}

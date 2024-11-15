
using DAL;
using ENTITY;

namespace BLL
{
    public class AlertaService
    {
        private readonly AlertaRepository _alertaRepository;

        public AlertaService()
        {
            _alertaRepository = new AlertaRepository();
        }

        public string InsertarAlerta(string descripcion, Alerta.TipoAlerta tipo,
            Coordenada ubicacion, int usuarioId)
        {
            try
            {
                // Validaciones de negocio
                if (string.IsNullOrWhiteSpace(descripcion))
                    return "La descripci�n de la alerta no puede estar vac�a";

                if (ubicacion == null)
                    return "La ubicaci�n es requerida";

                if (usuarioId <= 0)
                    return "El ID de usuario no es v�lido";

                // Crear nueva alerta
                var alerta = new Alerta(tipo, descripcion, ubicacion, usuarioId);

                // Insertar en la base de datos
                return _alertaRepository.Insertar(alerta);
            }
            catch (Exception ex)
            {
                // Log del error aqu� si es necesario
                return $"Error al insertar la alerta: {ex.Message}";
            }
        }

        public List<Alerta> ObtenerTodasLasAlertas()
        {
            try
            {
                return _alertaRepository.Seleccionar();
            }
            catch (Exception ex)
            {
                // Log del error aqu� si es necesario
                throw new Exception($"Error al obtener las alertas: {ex.Message}", ex);
            }
        }

        public List<Alerta> ObtenerAlertasPorTipo(Alerta.TipoAlerta tipo)
        {
            try
            {
                return _alertaRepository.Seleccionar()
                    .FindAll(a => a.Tipo == tipo);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener las alertas por tipo: {ex.Message}", ex);
            }
        }

        public List<Alerta> ObtenerAlertasPorUsuario(int usuarioId)
        {
            try
            {
                return _alertaRepository.Seleccionar()
                    .FindAll(a => a.UsuarioId == usuarioId);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener las alertas del usuario: {ex.Message}", ex);
            }
        }

        public List<Alerta> ObtenerAlertasRecientes(int horasAtras = 24)
        {
            try
            {
                var fechaLimite = DateTime.Now.AddHours(-horasAtras);
                return _alertaRepository.Seleccionar()
                    .FindAll(a => a.FechaHora >= fechaLimite);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener las alertas recientes: {ex.Message}", ex);
            }
        }
    }

}

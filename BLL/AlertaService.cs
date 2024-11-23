using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;


namespace BLL
{
    public class AlertaService
    {
        private readonly AlertaRepository _alertaRepository;

        public AlertaService()
        {
            _alertaRepository = new AlertaRepository();
        }

        public string InsertarAlerta(TipoAlerta tipo, Coordenada ubicacion)
        {
            try
            {
                if (ubicacion == null)
                    return "La ubicación es requerida";

                if (!TipoAlerta.EsTipoValido(tipo))
                    return "El tipo de alerta no es válido";

                var alerta = new Alerta(tipo, ubicacion);

                return _alertaRepository.Insertar(alerta);
            }
            catch (Exception ex)
            {
                
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
                throw new Exception($"Error al obtener las alertas: {ex.Message}", ex);
            }
        }

        public List<Alerta> ObtenerAlertasPorTipo(TipoAlerta tipo)
        {
            try
            {
                return _alertaRepository.Seleccionar().FindAll(a => a.Tipo == tipo);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener las alertas por tipo: {ex.Message}", ex);
            }
        }

        public List<Alerta> ObtenerAlertasRecientes(int horasAtras = 24)
        {
            try
            {
                var fechaLimite = DateTime.Now.AddHours(-horasAtras);
                return _alertaRepository.Seleccionar().FindAll(a => a.FechaHora >= fechaLimite);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener las alertas recientes: {ex.Message}", ex);
            }
        }
    }
}

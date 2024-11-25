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
        DAL.AlertaRepository AlertaRepository = new DAL.AlertaRepository();
        private readonly AlertaRepository _alertaRepository;

        public AlertaService()
        {
            _alertaRepository = new AlertaRepository();
        }

        private static Random random = new Random();

        //creamos la alerta con una clase de tipo Alerta, con el objetivo de poder recibir informacion
        //de la alerta creada si se necesita en algun momento determinado
        public Alerta CrearAlerta(string tipoAlerta, double latitud, double longitud)
        {
            TipoAlerta tipo = ObtenerTipoAlerta(tipoAlerta);
            Coordenada ubicacion = new Coordenada(latitud, longitud);
            Alerta alerta = new Alerta(tipo, ubicacion);
            alerta.Id = GenerarIdAleatorio();
            alerta.FechaHora = DateTime.Now; 
            AlertaRepository.InsertarAlerta(alerta);
            return alerta;
        }

       
        private TipoAlerta ObtenerTipoAlerta(string tipoAlerta)
        {
            switch (tipoAlerta)
            {
                case "Accidente":
                    return TipoAlerta.Accidente;
                case "Robo":
                    return TipoAlerta.Robo;
                case "Actividad Sospechosa":
                    return TipoAlerta.ActividadSospechosa;
                default:
                    throw new ArgumentException("Tipo de alerta no válido", nameof(tipoAlerta));
            }
        }
  
        private int GenerarIdAleatorio()
        {
            return random.Next(1000000, 9999999);
        }
        public List<Alerta> ObtenerTodasLasAlertas()
        {
            try
            {
                return _alertaRepository.SeleccionarAlertas();
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
                return _alertaRepository.SeleccionarAlertas().FindAll(a => a.Tipo == tipo);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener las alertas por tipo: {ex.Message}", ex);
            }
        }

        public List<Alerta> ObtenerAlertasFiltradas(TipoAlerta tipoAlerta, DateTime? fechaInicio = null, DateTime? fechaFin = null,double? latMin = null, double? latMax = null,double? lonMin = null, double? lonMax = null)
        {
            try
            {
                var alertas = _alertaRepository.SeleccionarAlertas();

                var alertasFiltradas = alertas.Where(a =>
                    (tipoAlerta == null || a.Tipo.Id == tipoAlerta.Id) &&
                    (fechaInicio == null || a.FechaHora >= fechaInicio) &&
                    (fechaFin == null || a.FechaHora <= fechaFin) &&
                    (latMin == null || a.Ubicacion.Latitud >= latMin) &&
                    (latMax == null || a.Ubicacion.Latitud <= latMax) &&
                    (lonMin == null || a.Ubicacion.Longitud >= lonMin) &&
                    (lonMax == null || a.Ubicacion.Longitud <= lonMax)
                ).ToList();

                return alertasFiltradas;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al filtrar las alertas: {ex.Message}", ex);
            }
        }


        public void EliminarAlerta(int idAlerta)
        {
            _alertaRepository.EliminarAlerta(idAlerta);
        }
    }
}

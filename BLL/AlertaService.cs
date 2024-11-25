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
            alerta.FechaHora = DateTime.Now; // se asigna la fecha y la hora del momento en que se crea la alerte, es decir por defecto
            AlertaRepository.InsertarAlerta(alerta);
            return alerta;
        }

        //esta funcion esta encargada de llenar el campo tipo de alerta de la clase alerta 
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

        //funcion para generar una id aleatoria al momneto de crear la alerta
        private int GenerarIdAleatorio()
        {
            return random.Next(1000000, 9999999);
        }

        //esta funcion esta encargada  de recibir la lista de las alerta cea das que se almacenan en la base de datos
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

        //
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

        public void EliminarAlerta(int idAlerta)
        {
            _alertaRepository.EliminarAlerta(idAlerta);
        }
    }
}

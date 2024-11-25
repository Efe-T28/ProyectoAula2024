using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gmap.net.Overlays;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using BLL;
using ENTITY;


namespace ProyectoAula
{
    public partial class FormMapa : Form
    {
        private GMarkerGoogle markerInicial;
        private GMapOverlay markersOverlay;
        private List<PointLatLng> puntos = new List<PointLatLng>();
        private GMarkerGoogle marcadorTemporal;
        private PointLatLng puntoTemporal;

        private const double latInicial = 10.4582;
        private const double lngInicial = -73.2588;

        private AlertaService alertaService;
        private List<Alerta> alertas;

        public FormMapa()
        {
            InitializeComponent();
            alertaService = new AlertaService();
            alertas = new List<Alerta>();
        }

        private void FormMapa_Load(object sender, EventArgs e)
        {
            ConfigurarPanelOpciones();
            ConfigurarMapa();
            AgregarMarcadorInicial();
            InicializarComboBoxAlerta();
        }

        private void ConfigurarPanelOpciones()
        {
            pnlOpciones.BackColor = Color.FromArgb(150, 0, 0, 0);
        }

        //configuracion del mapa 
        private void ConfigurarMapa()
        {
            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.CanDragMap = true;
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            gMapControl1.Position = new PointLatLng(latInicial, lngInicial);
            gMapControl1.MinZoom = 0;
            gMapControl1.MaxZoom = 24;
            gMapControl1.Zoom = 16;
            gMapControl1.AutoScroll = true;
            gMapControl1.ShowCenter = false;

            markersOverlay = new GMapOverlay("Marcadores");
            gMapControl1.Overlays.Add(markersOverlay);
        }

        //esta funcion crea un marcador inicial que es el lugar donde se supone estaremos
        //mas adelante debe ser cambiada por geolocalizacion en tiempo real
        private void AgregarMarcadorInicial()
        {
            markerInicial = new GMarkerGoogle(new PointLatLng(latInicial, lngInicial), GMarkerGoogleType.arrow);
            markerInicial.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            markerInicial.ToolTipText = string.Format("Ubicación Inicial\nLatitud:{0}\nLongitud:{1}", latInicial, lngInicial);
            markersOverlay.Markers.Add(markerInicial);

            ActualizarTextBox(latInicial, lngInicial);
        }

        private void InicializarComboBoxAlerta()
        {
            cbxTipoAlerta.Items.AddRange(new string[] { "Accidente", "Robo", "Actividad Sospechosa" });
            cbxTipoAlerta.SelectedIndex = -1;
            btnCrearAlerta.Enabled = false;
        }

        private void gMapControl1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            double lat = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lat;
            double lng = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lng;

            CrearMarcadorTemporal(lat, lng);
        }

        private void CrearMarcadorTemporal(double lat, double lng)
        {
            if (marcadorTemporal != null)
            {
                markersOverlay.Markers.Remove(marcadorTemporal);
            }

            puntoTemporal = new PointLatLng(lat, lng);
            marcadorTemporal = new GMarkerGoogle(puntoTemporal, GMarkerGoogleType.yellow);
            marcadorTemporal.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            marcadorTemporal.ToolTipText = string.Format("Punto Temporal\nLatitud:{0}\nLongitud:{1}", lat, lng);
            markersOverlay.Markers.Add(marcadorTemporal);

            ActualizarTextBox(lat, lng);
            btnCrearAlerta.Enabled = true;

            gMapControl1.Refresh();
        }

        private void ActualizarTextBox(double lat, double lng)
        {
            txtLatitud.Text = lat.ToString();
            txtLongitud.Text = lng.ToString();
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            irAlHistorial();
        }

        private void irAlHistorial()
        {
            this.Hide();
            FormHistorial formOpciones = new FormHistorial();
            formOpciones.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCrearAlerta_Click(object sender, EventArgs e)
        {
            if (!ValidarDatosAlerta())
            {
                return;
            }

            Alerta nuevaAlerta = alertaService.CrearAlerta(
                cbxTipoAlerta.SelectedItem.ToString(),
                puntoTemporal.Lat,
                puntoTemporal.Lng
            );

            alertas.Add(nuevaAlerta);

            CrearMarcadorAlerta(nuevaAlerta);

            LimpiarEstadoAlerta();

            MessageBox.Show($"Alerta creada con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool ValidarDatosAlerta()
        {
            if (puntoTemporal == null)
            {
                MessageBox.Show("Por favor, seleccione un punto en el mapa haciendo doble clic.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cbxTipoAlerta.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, seleccione un tipo de alerta.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (puntos.Any(p => Math.Abs(p.Lat - puntoTemporal.Lat) < 0.000001 && Math.Abs(p.Lng - puntoTemporal.Lng) < 0.000001))
            {
                MessageBox.Show("Ya existe una alerta en estas coordenadas.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void CrearMarcadorAlerta(Alerta alerta)
        {
            GMarkerGoogleType tipoMarcador = ObtenerTipoMarcador(alerta.Tipo.Nombre);

            GMarkerGoogle marcadorPermanente = new GMarkerGoogle(
                new PointLatLng(alerta.Ubicacion.Latitud, alerta.Ubicacion.Longitud),
                tipoMarcador
            );
            marcadorPermanente.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            marcadorPermanente.ToolTipText = string.Format("Alerta: {0}\nID: {1}\nFecha: {2}\nLatitud:{3}\nLongitud:{4}",
                alerta.Tipo.Nombre, alerta.Id, alerta.FechaHora, alerta.Ubicacion.Latitud, alerta.Ubicacion.Longitud);
            markersOverlay.Markers.Add(marcadorPermanente);

            puntos.Add(new PointLatLng(alerta.Ubicacion.Latitud, alerta.Ubicacion.Longitud));

            markersOverlay.Markers.Remove(marcadorTemporal);
            marcadorTemporal = null;

            gMapControl1.Refresh();
        }

        private void LimpiarEstadoAlerta()
        {
            btnCrearAlerta.Enabled = false;
            cbxTipoAlerta.SelectedIndex = -1;
        }

        private GMarkerGoogleType ObtenerTipoMarcador(string tipoAlerta)
        {
            switch (tipoAlerta)
            {
                case "Accidente":
                    return GMarkerGoogleType.red;
                case "Robo":
                    return GMarkerGoogleType.purple;
                case "Actividad Sospechosa":
                    return GMarkerGoogleType.orange;
                default:
                    return GMarkerGoogleType.red;
            }
        }
    }
}

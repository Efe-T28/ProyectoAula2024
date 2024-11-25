using GMap.NET.MapProviders;
using Gmap.net.Overlays;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms;
using GMap.NET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ENTITY;

namespace ProyectoAula
{
    public partial class FormHistorial : Form
    {
        private GMarkerGoogle markerInicial;
        private readonly BLL.AlertaService _alertaService;
        private readonly GMapOverlay _markersOverlay;
        private const double latInicial = 10.4582;
        private const double longInicial = -73.2588;

        private List<Alerta> todasLasAlertas;

        public FormHistorial()
        {
            InitializeComponent();
            _alertaService = new BLL.AlertaService();
            _markersOverlay = new GMapOverlay("Marcadores");
            ConfigurarEventos();
        }

        private void ConfigurarEventos()
        {
            //quitamos la fila vacia que aparece por defecto en la grid para que esto no nos provoque errores
            dtgAlertas.AllowUserToAddRows = false;
            dtgAlertas.SelectionChanged += DtgAlertas_SelectionChanged;
            Load += FormHistorial_Load;
        }

        private void FormHistorial_Load(object sender, EventArgs e)
        {
            ConfigurarComboBoxFiltro();
            ConfigurarPanelOpciones();
            ConfigurarMapa();
            ConfigurarGrid();
            CargarAlertas();
            AgregarMarcadorInicial();
        }

        private void ConfigurarPanelOpciones()
        {
            pnlOpciones.BackColor = Color.FromArgb(150, 0, 0, 0);
        }

        private void AgregarMarcadorInicial()
        {
            markerInicial = new GMarkerGoogle(new PointLatLng(latInicial, longInicial), GMarkerGoogleType.arrow);
            markerInicial.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            markerInicial.ToolTipText = string.Format("Ubicación Inicial\nLatitud:{0}\nLongitud:{1}", latInicial, longInicial);
            _markersOverlay.Markers.Add(markerInicial);

            ActualizarTextBox(latInicial, longInicial);
            CentrarMapa(latInicial, longInicial);
        }
        private void ActualizarTextBox(double lat, double lng)
        {
            txtLatitud.Text = lat.ToString();
            txtLongitud.Text = lng.ToString();
        }

        private void ConfigurarMapa()
        {
            gmpMapa.DragButton = MouseButtons.Left;
            gmpMapa.CanDragMap = true;
            gmpMapa.MapProvider = GMapProviders.GoogleMap;
            gmpMapa.Position = new PointLatLng(latInicial, longInicial);
            gmpMapa.MinZoom = 0;
            gmpMapa.MaxZoom = 24;
            gmpMapa.Zoom = 16;
            gmpMapa.AutoScroll = true;
            gmpMapa.ShowCenter = false;

            gmpMapa.Overlays.Add(_markersOverlay);
        }

        private void ConfigurarGrid()
        {
            dtgAlertas.Columns.Clear();
            dtgAlertas.Columns.AddRange(new DataGridViewColumn[]
            {
        new DataGridViewTextBoxColumn { Name = "TipoAlerta", HeaderText = "Tipo de Alerta", ReadOnly = true },
        new DataGridViewTextBoxColumn { Name = "FechaHora", HeaderText = "Fecha y Hora", ReadOnly = true },
        new DataGridViewTextBoxColumn { Name = "Latitud", HeaderText = "Latitud", ReadOnly = true },
        new DataGridViewTextBoxColumn { Name = "Longitud", HeaderText = "Longitud", ReadOnly = true },
        new DataGridViewTextBoxColumn { Name = "Id", Visible = false, ReadOnly = true }
            });

            // Hace que toda la grid sea de solo lectura para que no se puedan editar los datos desde la interfaz
            dtgAlertas.ReadOnly = true;
            dtgAlertas.AllowUserToDeleteRows = false;
            dtgAlertas.AllowUserToAddRows = false;
            dtgAlertas.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void CargarAlertas()
        {
            try
            {
                List<Alerta> alertas = _alertaService.ObtenerTodasLasAlertas();
                MostrarAlertasEnGrid(alertas);
                MostrarAlertasEnMapa(alertas);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las alertas: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MostrarAlertasEnGrid(List<Alerta> alertas)
        {
            dtgAlertas.Rows.Clear();
            foreach (var alerta in alertas)
            {
                dtgAlertas.Rows.Add(
                    alerta.Tipo.Nombre,
                    alerta.FechaHora.ToString("dd/MM/yyyy HH:mm:ss"),
                    alerta.Ubicacion.Latitud,
                    alerta.Ubicacion.Longitud,
                    alerta.Id
                );
            }
            dtgAlertas.AutoResizeColumns();
        }

        private void MostrarAlertasEnMapa(List<Alerta> alertas)
        {
            _markersOverlay.Markers.Clear();
            foreach (var alerta in alertas)
            {
                var marker = CrearMarcador(alerta);
                _markersOverlay.Markers.Add(marker);
            }
        }

        private GMarkerGoogle CrearMarcador(Alerta alerta)
        {
            var posicion = new PointLatLng(alerta.Ubicacion.Latitud, alerta.Ubicacion.Longitud);
            var tipoMarcador = ObtenerTipoMarcador(alerta.Tipo.Nombre);
            var marker = new GMarkerGoogle(posicion, tipoMarcador);

            marker.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            marker.ToolTipText = $"Alerta: {alerta.Tipo.Nombre}\n" +
                                $"Fecha: {alerta.FechaHora:dd/MM/yyyy HH:mm:ss}\n" +
                                $"Latitud: {alerta.Ubicacion.Latitud}\n" +
                                $"Longitud: {alerta.Ubicacion.Longitud}";

            return marker;
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
                    return GMarkerGoogleType.blue;
            }
        }

        private void DtgAlertas_SelectionChanged(object sender, EventArgs e)
        {
            seleccionarEnLaGrid();
        }

        public void seleccionarEnLaGrid()
        {
            if (dtgAlertas.CurrentRow == null) return;

            double lat = Convert.ToDouble(dtgAlertas.CurrentRow.Cells["Latitud"].Value);
            double lng = Convert.ToDouble(dtgAlertas.CurrentRow.Cells["Longitud"].Value);

            ActualizarTextBox(lat, lng);
            CentrarMapa(lat, lng);
        }

        private void CentrarMapa(double lat, double lng)
        {
            gmpMapa.Position = new PointLatLng(lat, lng);

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            irAlInicio();
        }

        public void irAlInicio()
        {
            Hide();
            using (var formMapa = new FormMapa())
            {
                formMapa.ShowDialog();
            }
        }

        private void btnUbicacion_Click(object sender, EventArgs e)
        {
            irAMiUbicacion();
        }

        private void irAMiUbicacion()
        {
            CentrarMapa(latInicial, longInicial);
            ActualizarTextBox(latInicial, longInicial);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        public void Eliminar()
        {
            if (VerificarSeleccion())
            {
                int idSeleccionado = ObtenerIdSeleccionado();
                if (ConfirmarEliminacion(idSeleccionado))
                {
                    EliminarAlerta(idSeleccionado);
                }
                else
                {
                    MessageBox.Show("Operación de eliminación cancelada.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private bool VerificarSeleccion()
        {
            if (dtgAlertas.CurrentRow == null)
            {
                MessageBox.Show("Por favor, seleccione una alerta para eliminar.", "Ninguna alerta seleccionada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private int ObtenerIdSeleccionado()
        {
            if (dtgAlertas.CurrentRow.Cells["Id"].Value == null)
            {
                throw new InvalidOperationException("El objeto seleccionado no tiene un ID válido.");
            }

            if (!int.TryParse(dtgAlertas.CurrentRow.Cells["Id"].Value.ToString(), out int idAlerta))
            {
                throw new InvalidOperationException("El ID del objeto seleccionado no es un número válido.");
            }

            return idAlerta;
        }

        private bool ConfirmarEliminacion(int id)
        {
            DialogResult resultado = MessageBox.Show(
                $"¿Está seguro que desea eliminar la alerta?",
                "Confirmar Eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            return resultado == DialogResult.Yes;
        }

        private void EliminarAlerta(int id)
        {
            try
            {
                _alertaService.EliminarAlerta(id);
                MessageBox.Show($"La alerta ha sido eliminada.", "Alerta Eliminada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ActualizarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar la alerta: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarGrid()
        {
            CargarAlertas();
            AgregarMarcadorInicial();
        }

        private void ConfigurarComboBoxFiltro()
        {
            cmbTipoAlerta.SelectedIndex = -1;
        }

        private void CmbFiltroAlertas_SelectedIndexChanged(object sender, EventArgs e)
        {
            string filtroSeleccionado = (sender as ComboBox).SelectedItem.ToString();
            //FiltrarAlertas(filtroSeleccionado);
        }

    }
}

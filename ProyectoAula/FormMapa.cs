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


namespace ProyectoAula
{
    public partial class FormMapa : Form
    {

        GMarkerGoogle marker;
        GMapOverlay markerOverlay;
        //DataTable dt;
        //ruta automatizada(direccion)
        //bool trazarRuta = false;
        //int contadorIndicadoresRuta = 0;
        //PointLatLng inicio;
        //PointLatLng final;

        double latIicial = 10.4582;
        double lngInicial = -73.2588;

        public FormMapa()
        {
            InitializeComponent();
        }

        private void FormMapa_Load(object sender, EventArgs e)
        {
            pnlOpciones.BackColor = Color.FromArgb(150, 0, 0, 0);
          

            //dimendiones del mapa 
            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.CanDragMap = true;
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            gMapControl1.Position = new PointLatLng(latIicial, lngInicial);
            gMapControl1.MinZoom = 0;
            gMapControl1.MaxZoom = 24;
            gMapControl1.Zoom = 16;
            gMapControl1.AutoScroll = true;

            //marcador
            markerOverlay = new GMapOverlay("Marcador");
            marker = new GMarkerGoogle(new PointLatLng(latIicial, lngInicial), GMarkerGoogleType.blue);
            markerOverlay.Markers.Add(marker); //agregar al mapa

            //agregamos un tooltip de texto a los marcadores
            marker.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            marker.ToolTipText = string.Format("Ubicacion\n Latitud:{0}\n Longitud:{1}", latIicial, lngInicial);

            //agregaos el mapa y el marcador al control map 
            gMapControl1.Overlays.Add(markerOverlay);
        }

        private void gMapControl1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormOpciones formOpciones = new FormOpciones();
            formOpciones.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

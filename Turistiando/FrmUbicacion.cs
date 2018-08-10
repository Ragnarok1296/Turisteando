using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace Turistiando
{
    public partial class FrmUbicacion : Form
    {
        GMarkerGoogle marker;
        GMapOverlay markerOverlay;

        private Double latitud;
        private Double longitud;

        public FrmUbicacion()
        {
            InitializeComponent();
        }

        private void FrmUbicacion_Load(object sender, EventArgs e)
        {
            if (Ubicacion.GetLocationProperty()) {
                latitud = Ubicacion.Latitud;
                longitud = Ubicacion.Longitud;
            }
            else
            {
                latitud = 20.1270706;
                longitud = -98.7333546;
            }
            

            gmcMapa.DragButton = MouseButtons.Left;
            gmcMapa.MapProvider = GMapProviders.GoogleMap;
            gmcMapa.Position = new PointLatLng(latitud, longitud);

            gmcMapa.ShowCenter = false;


            markerOverlay = new GMapOverlay("Marcador");
            marker = new GMarkerGoogle(new PointLatLng(latitud, longitud), GMarkerGoogleType.red);
            markerOverlay.Markers.Add(marker);

            marker.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            marker.ToolTipText = string.Format("Ubicacion: \n Latitud:{0} \n Longitud: {1}", latitud, longitud);

            gmcMapa.Overlays.Add(markerOverlay);


        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Ubicacion.Latitud = latitud;
            Ubicacion.Longitud = longitud;

            FrmPrincipal frmPrincipal = new FrmPrincipal();
            frmPrincipal.Show();
            this.Hide();
        }

        private void gmcMapa_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            latitud = gmcMapa.FromLocalToLatLng(e.X, e.Y).Lat;
            longitud = gmcMapa.FromLocalToLatLng(e.X, e.Y).Lng;

            marker.Position = new PointLatLng(latitud, longitud);

            marker.ToolTipText = string.Format("Ubicacion: \n Latitud:{0} \n Longitud: {1}", latitud, longitud);

        }

        private void pbxCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de cerrar el programa?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FrmPrincipal FrmForm1 = new FrmPrincipal();
            FrmForm1.Show();
            this.Hide();
        }
    }
}

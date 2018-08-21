using System;
using System.Windows.Forms;

using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace Turistiando
{
    public partial class FrmUbicacion : Form
    {
        private GMarkerGoogle marker;
        private GMapOverlay markerOverlay;

        private Double latitud;
        private Double longitud;

        public FrmUbicacion()
        {
            InitializeComponent();
        }

        private void FrmUbicacion_Load(object sender, EventArgs e)
        {
            //Se obtiene la ubicacion del dispositivo para ubicarse en el mapa, sino entonces el lugar por defecto es el centro de pachuca 
            if (Ubicacion.GetLocationProperty()) {
                latitud = Ubicacion.Latitud;
                longitud = Ubicacion.Longitud;
            }
            else
            {
                latitud = 20.1270706;
                longitud = -98.7333546;
            }
            
            //Se configura el mapa
            gmcMapa.DragButton = MouseButtons.Left;
            gmcMapa.MapProvider = GMapProviders.GoogleMap;
            gmcMapa.Position = new PointLatLng(latitud, longitud);

            gmcMapa.ShowCenter = false;
            
            //Se crea un layout para añadir el marcador
            markerOverlay = new GMapOverlay("Marcador");
            marker = new GMarkerGoogle(new PointLatLng(latitud, longitud), GMarkerGoogleType.red);
            markerOverlay.Markers.Add(marker);

            gmcMapa.Overlays.Add(markerOverlay);


        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            

            //Se regresa a la pagina principal
            FrmPrincipal frmPrincipal = new FrmPrincipal();
            frmPrincipal.Show();
            this.Hide();
        }

        private void gmcMapa_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //Al gacer doble click se actualiza el marcador
            latitud = gmcMapa.FromLocalToLatLng(e.X, e.Y).Lat;
            longitud = gmcMapa.FromLocalToLatLng(e.X, e.Y).Lng;

            marker.Position = new PointLatLng(latitud, longitud);
            
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

            //Se actualiza la ubicacion
            Ubicacion.Latitud = latitud;
            Ubicacion.Longitud = longitud;


            FrmPrincipal FrmForm1 = new FrmPrincipal();
            FrmForm1.Show();
            this.Hide();
        }
    }
}

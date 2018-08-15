using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Turistiando.Modelos;

namespace Turistiando
{
    public partial class FrmResultados : Form
    {
        public Lugar lugares;
        public String cadenaGenetica;

        private API api;
        private Button[] buttons;

        public FrmResultados()
        {
            InitializeComponent();

            //Configuracion para el scroll
            plButtons.AutoScroll = false;
            plButtons.HorizontalScroll.Enabled = false;
            plButtons.HorizontalScroll.Visible = false;
            plButtons.HorizontalScroll.Maximum = 0;
            plButtons.AutoScroll = true;

            //Configuracion para el mapa
            gmcMapa.DragButton = MouseButtons.Left;
            gmcMapa.MapProvider = GMapProviders.GoogleMap;
            
            gmcMapa.ShowCenter = false;
        }


        private void FrmResultados_Load(object sender, EventArgs e)
        {
            api = new API();
            
            //Se hace el conteo de cuantos lugares fueron seleccionados para asi darle un parametro al array de botones
            int numBotones = 0;
            for (int i = 0; i < cadenaGenetica.Length; i++)
                if (cadenaGenetica[i] == '1')
                    numBotones++;
            
            buttons = new Button[numBotones];

            //Se crean los botones y se selecciona el primero
            crearBotones();

            CargarInformacion_Click(buttons[0], e);
        }

        private void crearBotones()
        {
            //Variables auxiliares para dar formato, tanto para la posicion, como para el texto y asignacion (index)
            int index = 0;
            int posicion = 9; 

            //Se crean dinamicamente los botenes y se les da esas propiedades
            for(int i=0; i<cadenaGenetica.Length; i++)
            {
                if (cadenaGenetica[i] == '1')
                {
                    buttons[index] = (new Button());
                    buttons[index].BackColor = Color.Teal;

                    buttons[index].Size = new Size(40,40);
                    buttons[index].Location = new Point(9,posicion);

                    buttons[index].Name = i.ToString();
                    buttons[index].Text = (index+1).ToString();

                    //A todos se les asigna el mismo evento
                    buttons[index].Click += new EventHandler(this.CargarInformacion_Click);

                    buttons[index].Enabled = true;
                    buttons[index].Visible = true;

                    //Se agregan al panel
                    plButtons.Controls.Add(buttons[index]);

                    index++;
                    posicion += 46;
                }
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            FrmPrincipal frmPrincipal = new FrmPrincipal();
            frmPrincipal.Show();
            this.Hide();
        }

        private void pbxCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de cerrar el programa?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void vsBar_Scroll(object sender, ScrollEventArgs e)
        {
            plButtons.VerticalScroll.Value = vsBar.Value;
        }

        private void CargarInformacion_Click(object sender, EventArgs e)
        {
            //Utilizamos esta variable auxiliar para no estar repitiendo ese codigo cuado se necesite
            int lugarPosicion = Convert.ToInt32(((Button)sender).Name);

            //Cambia de color 
            ((Button)sender).BackColor = Color.SteelBlue;
            
            //Volvemos a los demas al color de no seleccionado
            for(int i=0; i<buttons.Length; i++)
                if(buttons[i].Name != ((Button)sender).Name)
                    buttons[i].BackColor = Color.Teal;

            //Se verifica que se tenga foto en el lugar
            try {
                string url = api.obtenerImagen(lugares.Results[lugarPosicion].Photos[0].PhotoReference);
                pictureBox1.WaitOnLoad = false;
                pbImagen.LoadAsync(@url);
            } catch {
                pbImagen.Image = Properties.Resources.file;
            }

            //Se coloca el nombre del lugar
            lblNombreLugar.Text = lugares.Results[lugarPosicion].Name;

            //Se coloca el mapa
            cargarMapa(lugarPosicion);

            //Se obtiene la latitud y longitud ara mandarsela como parametro al metodo de obtener ruta
            string latitud = lugares.Results[lugarPosicion].Geometry.Location.Lat.ToString();
            string longitud = lugares.Results[lugarPosicion].Geometry.Location.Lng.ToString();

            //Se almacena el tiempo en segundos
            lblTiempo.Text = api.obtenerRuta(latitud, longitud).Routes[0].Legs[0].Duration.Text;

            //Se coloca el rating
            lblRating.Text = lugares.Results[lugarPosicion].Rating.ToString() + " / 5";

        }

        private void cargarMapa(int lugar)
        {
            //Se centra la posicion del mapa en la ubicacion del dispositivo
            gmcMapa.Position = new PointLatLng(Ubicacion.Latitud, Ubicacion.Longitud);

            //Se eliminan las capas
            gmcMapa.Overlays.Clear();
            
            Double latitud = lugares.Results[lugar].Geometry.Location.Lat;
            Double longitud = lugares.Results[lugar].Geometry.Location.Lng;
            
            //Mi ubicacion
            GMapOverlay markerOverlayUbicaacion = new GMapOverlay("Ubicacion");

            GMarkerGoogle markerUbicacion = new GMarkerGoogle(new PointLatLng(Ubicacion.Latitud, Ubicacion.Longitud), GMarkerGoogleType.red);
            markerOverlayUbicaacion.Markers.Add(markerUbicacion);

            gmcMapa.Overlays.Add(markerOverlayUbicaacion);

            //Ubicacion del lugar
            GMapOverlay markerOverlayLugar = new GMapOverlay("Lugar");

            GMarkerGoogle markerLugar = new GMarkerGoogle(new PointLatLng(latitud, longitud), GMarkerGoogleType.blue);
            markerOverlayLugar.Markers.Add(markerLugar);

            gmcMapa.Overlays.Add(markerOverlayLugar);

            generarRuta(lugar);

            //Se actualiza el mapa
            gmcMapa.Zoom = gmcMapa.Zoom + 1;
            gmcMapa.Zoom = gmcMapa.Zoom - 1;
        }

        private void generarRuta(int lugar)
        {
            //Se obtiene los datos del lugar
            String latitud_Lugar = lugares.Results[lugar].Geometry.Location.Lat.ToString();
            String longitud_Lugar = lugares.Results[lugar].Geometry.Location.Lng.ToString();
            
            //Se crea el array de puntos para la ruta
            GMapOverlay Ruta = new GMapOverlay("CapaRuta");
            List<PointLatLng> puntos = new List<PointLatLng>();

            //Variables para almacenar los datos
            Double latitud;
            Double longitud;

            //Se llena el array con todos los pasos generados por el json
            for(int i=0; i<api.obtenerRuta(latitud_Lugar, longitud_Lugar).Routes[0].Legs[0].Steps.Length; i++)
            {
                latitud = api.obtenerRuta(latitud_Lugar, longitud_Lugar).Routes[0].Legs[0].Steps[i].EndLocation.Lat;
                longitud = api.obtenerRuta(latitud_Lugar, longitud_Lugar).Routes[0].Legs[0].Steps[i].EndLocation.Lng;
                
                puntos.Add(new PointLatLng(latitud, longitud));
            }

            //Se crea la ruta con los puntos agregados anteriormente y se agrega la capa de ruta
            GMapRoute PuntosRuta = new GMapRoute(puntos, "Ruta");
            Ruta.Routes.Add(PuntosRuta);
            gmcMapa.Overlays.Add(Ruta);

        }

    }
}

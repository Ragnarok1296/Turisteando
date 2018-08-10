using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Newtonsoft.Json;

namespace Turistiando
{
    public partial class FrmPrincipal : Form
    {
        Lugar lugar;

        public FrmPrincipal()
        {
            InitializeComponent();

            toolTip1.SetToolTip(tbxTiempo, "Tiempo de Estancia");
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            lugar = new Lugar();
            
            cbTiempo.SelectedIndex = 0;

            if(Ubicacion.Latitud != 0 && Ubicacion.Longitud != 0)
            {
                pbCheck.Image = Properties.Resources.success;
                pbCheck.Visible = true;
                btnRecomendar.Enabled = true;
            }
            else
                btnRecomendar.Enabled = false;

            Ubicacion.GetLocationProperty();
        }

        private void pbxCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de cerrar el programa?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnRecomendar_Click_1(object sender, EventArgs e)
        {
            obtenerDatosApi();

            FrmResultados frmResultados = new FrmResultados();

            frmResultados.lugar = lugar;

            frmResultados.Show();

            this.Hide();

        }

        private void obtenerDatosApi()
        {
            
            string url = "https://maps.googleapis.com/maps/api/place/nearbysearch/json";
            string location = "?location=20.0967662,-98.7051163";
            string radius = "&radius=500";
            string types = "&types=point_of_interest";
            string key = "&key=AIzaSyB5oEd0b0RaZdrMujXhC4mVW4-m7fK6kJA";

            //url = url + location + radius + types + key; 

            WebRequest request = WebRequest.Create(url);

            WebResponse response = request.GetResponse();

            Stream data = response.GetResponseStream();

            StreamReader reader = new StreamReader(data);

            // json que se obtiene de la api
            string json = reader.ReadToEnd();

            lugar = JsonConvert.DeserializeObject<Lugar>(json);

            response.Close();
        }

        private void btnMiUbicacion_Click(object sender, EventArgs e)
        {

            if (Ubicacion.GetLocationProperty())
            {
                pbCheck.Image = Properties.Resources.success;
                pbCheck.Visible = true;
                btnRecomendar.Enabled = true;
            }
            else
            {
                pbCheck.Image = Properties.Resources.cancel;
                btnRecomendar.Enabled = false;
                MessageBox.Show("Activa tu ubicacion");
            }

        }

        private void btnEscogerUbicacion_Click(object sender, EventArgs e)
        {
            FrmUbicacion frmUbicacion = new FrmUbicacion();
            
            frmUbicacion.Show();
            this.Hide();
        }
    }
}

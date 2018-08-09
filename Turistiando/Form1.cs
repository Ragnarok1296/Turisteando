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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            toolTip1.SetToolTip(tbxTiempo, "Tiempo de Estancia");
            toolTip1.SetToolTip(tbxUbicacion, "Ubicación");


            cbTiempo.SelectedIndex = 0;
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
            /*Form2 FrmForm2 = new Form2();
            FrmForm2.Show();
            this.Hide();*/

            string url = "https://maps.googleapis.com/maps/api/place/nearbysearch/json?location=-33.8670522,151.1957362&radius=100&types=food&name=harbour&key=AIzaSyB5oEd0b0RaZdrMujXhC4mVW4-m7fK6kJA";

            WebRequest request = WebRequest.Create(url);

            WebResponse response = request.GetResponse();

            Stream data = response.GetResponseStream();

            StreamReader reader = new StreamReader(data);

            // json que se obtiene de la api
            string responseFromServer = reader.ReadToEnd();

            Lugar lugar = new Lugar();

            lugar = JsonConvert.DeserializeObject<Lugar>(responseFromServer);

            response.Close();

        }
    }
}

using System;
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

            plButtons.AutoScroll = false;
            plButtons.HorizontalScroll.Enabled = false;
            plButtons.HorizontalScroll.Visible = false;
            plButtons.HorizontalScroll.Maximum = 0;
            plButtons.AutoScroll = true;
        }


        private void FrmResultados_Load(object sender, EventArgs e)
        {
            api = new API();

            int numBotones = 0;
            for (int i = 0; i < cadenaGenetica.Length; i++)
                if (cadenaGenetica[i] == '1')
                    numBotones++;
            
            buttons = new Button[numBotones];

            crearBotones();

            CargarInformacion_Click(buttons[0], e);
        }

        private void crearBotones()
        {
            int index = 0;
            int posicion = 9; 

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

                    buttons[index].Click += new EventHandler(this.CargarInformacion_Click);

                    buttons[index].Enabled = true;
                    buttons[index].Visible = true;

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

            lblNombreLugar.Text = lugares.Results[lugarPosicion].Name;

            //Se obtiene la latitud y longitud ara mandarsela como parametro al metodo de obtener ruta
            string latitud = lugares.Results[lugarPosicion].Geometry.Location.Lat.ToString();
            string longitud = lugares.Results[lugarPosicion].Geometry.Location.Lng.ToString();

            //Se almacena el tiempo en segundos
            lblTiempo.Text = api.obtenerRuta(latitud, longitud).Routes[0].Legs[0].Duration.Value.ToString();


            lblRating.Text = lugares.Results[lugarPosicion].Rating.ToString() + " / 5";

        }
    }
}

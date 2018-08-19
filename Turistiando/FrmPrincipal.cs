using System;
using System.Windows.Forms;
using Turistiando.Modelos;

namespace Turistiando
{
    public partial class FrmPrincipal : Form
    {
        private Lugar lugares;
        private API api;
        private AlgoritmoGenetico algoritmoGenetico;

        public FrmPrincipal()
        {
            InitializeComponent();

            toolTip1.SetToolTip(tbxTiempo, "Tiempo de Estancia");
            cbTiempo.SelectedIndex = 0;
            cbTipos.SelectedIndex = 0;
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            lugares = new Lugar();
            api = new API();
            
            //Si la ubicacion esta cargada muestra el la palomita
            if(Ubicacion.Latitud != 0 && Ubicacion.Longitud != 0)
            {
                pbCheck.Image = Properties.Resources.success;
                pbCheck.Visible = true;
                btnRecomendar.Enabled = true;
            }
            else
                btnRecomendar.Enabled = false;

            //Se manda llamar la ubicacion antes ya que luego da error si no se hace, es como para activar el servicio
            Ubicacion.GetLocationProperty();
        }
        
        private void btnMiUbicacion_Click(object sender, EventArgs e)
        {
            //Se obtiene la ubicacion, dependiendo de eso muestra una palomita o una tache
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
            //Manda llamar el mapa para escoger ubicacion
            FrmUbicacion frmUbicacion = new FrmUbicacion();
            
            frmUbicacion.Show();
            this.Hide();
        }

        private void btnRecomendar_Click(object sender, EventArgs e)
        {
            //Verifica que se haya introducido el tiempo de estancia
            if (tbxTiempo.Text != "")
            {
                //El tiempo seconvierte a segundos, ya que asi esta en el JSON que devuelve Places
                int estancia = 0;

                if (cbTiempo.SelectedIndex == 0)
                    estancia = Convert.ToInt32(tbxTiempo.Text) * 60 * 60;
                else if (cbTiempo.SelectedIndex == 1)
                    estancia = Convert.ToInt32(tbxTiempo.Text) * 12 * 60 * 60;

                //Se obtieen los lugares con los parametros escogidos en el modelo
                lugares = api.obtenerLugares(tipos());

                //Si existen puntos de interes continua el programa
                if (lugares.Results.Length > 0)
                {

                    algoritmoGenetico = new AlgoritmoGenetico(lugares, estancia);
                    String cadenaGenetica = algoritmoGenetico.main();
                    Ruta[] rutas = algoritmoGenetico.listaRutas();

                    //Se manda llamar a la ventana de resultados y se le pasa, los lugares y la cadena genetica
                    FrmResultados frmResultados = new FrmResultados();

                    frmResultados.lugares = lugares;
                    frmResultados.cadenaGenetica = cadenaGenetica;
                    frmResultados.rutas = rutas;

                    frmResultados.Show();

                    this.Hide();
                }
                else
                    MessageBox.Show("No se encontraron lugares cerca de su ubicacion");
            }
            else
                MessageBox.Show("Introduzca el tiempo de estancia.");
        }

        private String tipos()
        {
            String tipo = "";

            if (cbTipos.SelectedIndex == 0)
                tipo = "park";
            else if (cbTipos.SelectedIndex == 1)
                tipo = "museum";
            else if (cbTipos.SelectedIndex == 2)
                tipo = "zoo";
            else if (cbTipos.SelectedIndex == 3)
                tipo = "art_gallery";
            else if (cbTipos.SelectedIndex == 4)
                tipo = "campground";
            else if (cbTipos.SelectedIndex == 5)
                tipo = "shopping_mall";


            return tipo;

        }

        private void pbxCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de cerrar el programa?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}

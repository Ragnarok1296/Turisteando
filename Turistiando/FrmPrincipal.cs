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
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            lugares = new Lugar();
            api = new API();
            
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

        private void btnRecomendar_Click(object sender, EventArgs e)
        {
            if (tbxTiempo.Text != "")
            {
                int estancia = 0;

                if (cbTiempo.SelectedIndex == 0)
                    estancia = Convert.ToInt32(tbxTiempo.Text) * 60 * 60;
                else if (cbTiempo.SelectedIndex == 1)
                    estancia = Convert.ToInt32(tbxTiempo.Text) * 12 * 60 * 60;


                lugares = api.obtenerLugares();

                if (lugares.Results.Length > 0)
                {
                    algoritmoGenetico = new AlgoritmoGenetico(estancia);
                    String cadenaGenetica = algoritmoGenetico.main(lugares);


                    FrmResultados frmResultados = new FrmResultados();

                    frmResultados.lugares = lugares;
                    frmResultados.cadenaGenetica = cadenaGenetica;

                    frmResultados.Show();

                    this.Hide();
                }
                else
                    MessageBox.Show("No se encontraron lugares cerca de su ubicacion");
            }
            else
                MessageBox.Show("Introduzca el tiempo de estancia.");
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

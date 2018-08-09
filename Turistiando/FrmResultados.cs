using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Turistiando
{
    public partial class FrmResultados : Form
    {
        public Lugar lugar;

        public FrmResultados()
        {
            InitializeComponent();

        }

        private void pbxCerrar_Click(object sender, EventArgs e)
        {
            FrmPrincipal FrmForm1 = new FrmPrincipal();
            FrmForm1.Show();
            this.Hide();
        }



    }
}

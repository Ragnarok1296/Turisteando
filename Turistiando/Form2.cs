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
    public partial class Form2 : Form
    {
        //public List<Lugar> lugaresn;

        public Form2()
        {
            InitializeComponent();

            //lugares = new List<Lugar>();

        }

        private void pbxCerrar_Click(object sender, EventArgs e)
        {
            Form1 FrmForm1 = new Form1();
            FrmForm1.Show();
            this.Hide();
        }



    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpressaoLambda
{
    public partial class FrmLambda : Form
    {
        public FrmLambda()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnConcatenar_Click(object sender, EventArgs e)
        {
            Func<string, string, string> concatenador = (x1, x2) => { return x1 + " " + x2; };
            Action<string> escritor = (x1) =>
            {
                txbResultado.Text = x1;
            };
            escritor(concatenador(txbTexto1.Text, txbTexto2.Text));
        }
    }
}

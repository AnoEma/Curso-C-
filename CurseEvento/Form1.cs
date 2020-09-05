using System;
using System.Windows.Forms;

namespace CurseEvento
{
    public partial class FrmGerenciador : Form
    {
        private GerenciadorLatidos _gerenciadorLatidos;
        public FrmGerenciador()
        {
            InitializeComponent();
            _gerenciadorLatidos = new GerenciadorLatidos();
            _gerenciadorLatidos.ExessoDecibeiEvent += (sender, args) =>
            {
                ExcessoDecibeisEventArgs eventArgs = (ExcessoDecibeisEventArgs)args;
                MessageBox.Show(string.Format("O cachorro passou dos limites, com {0} decibeis.", eventArgs.IntensidadeLatido), "Excesso de decibéis", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            };
        }

        private void FrmGerenciador_Load(object sender, EventArgs e)
        {
            pgbIntensidadeLatid.Value = 0;
        }

        private void btnLatir_Click(object sender, EventArgs e)
        {
            pgbIntensidadeLatid.Value = _gerenciadorLatidos.Latir();
        }
    }
}

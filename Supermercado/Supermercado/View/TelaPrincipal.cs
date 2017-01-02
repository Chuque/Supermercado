using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Supermercado.Model;

namespace Supermercado
{
    public partial class frmTelaPrincipal : Form
    {
        public frmTelaPrincipal()
        {
            InitializeComponent();
        }

        private void TelaPrincipal_Load(object sender, EventArgs e)
        {
            estilizar();

            txtFuncionario.Focus();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            Hide();
            new View.frmTelaClientes().ShowDialog();
            Show();
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            Hide();
            new View.frmTelaProduto().ShowDialog();
            Show();
        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
            Hide();
            new View.frmTelaVenda(txtFuncionario.Text).ShowDialog();
            Show();
        }

        private void txtFuncionario_TextChanged(object sender, EventArgs e)
        {
            if (txtFuncionario.TextLength > 0)
            {
                btnVendas.Enabled = true;
                AcceptButton = btnVendas;
            }
            else
            {
                btnVendas.Enabled = false;
                AcceptButton = null;
            }
        }

        private void estilizar()
        {
            this.BackColor = Color.White;
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnProdutos.FlatStyle = FlatStyle.Flat;
            btnVendas.FlatStyle = FlatStyle.Flat;
        }
    }
}

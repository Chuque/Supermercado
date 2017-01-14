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
using Supermercado.Model.DAO;

namespace Supermercado.View
{
    public partial class frmTelaClientes : Form
    {
        private bool editando = false;
        private string cpfAntigo = null;

        public frmTelaClientes()
        {
            InitializeComponent();
        }
        
        private void frmTelaClientes_Load(object sender, EventArgs e)
        {
            estilizar();

            //a primeira coluna armazenará um objeto do tipo Cliente
            dgvClientes.Columns.Add("cliente", "Cliente");
            dgvClientes.Columns[0].Visible = false;
            
            //a segunda coluna armazenará o seu nome
            dgvClientes.Columns.Add("nome", "Nome");
            dgvClientes.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            carregarTabelaClientes(new ClienteDAO().read(""));
            bloquearFormulario(true);
            selecionarPrimeiraLinhaTabelaClientes();

            txtPesquisar.Focus();
        }
        
        private void btnNovoSalvar_Click(object sender, EventArgs e)
        {
            if(btnNovoSalvar.Text == "Novo")
            {
                txtPesquisar.Text = "";
                limparFormulario();
                bloquearFormulario(false);
                dgvClientes.ClearSelection();
                btnEditar.Enabled = false;
                txtNome.Focus();

                btnApagarCancelar.Enabled = true;
                btnApagarCancelar.Text = "Cancelar";
                btnNovoSalvar.Text = "Salvar";
            }
            else //if text == salvar
            {
                Cliente cliente = new Cliente();

                cliente.Nome = txtNome.Text;
                cliente.Cpf = txtCpf.Text;
                cliente.Telefone = txtTelefone.Text;
                cliente.Cep = txtCep.Text;
                cliente.Rua = txtRua.Text;
                if (txtNumero.Text.Length > 1)
                    cliente.Numero = int.Parse(txtNumero.Text);
                cliente.Bairro = txtBairro.Text;

                if (editando == false)
                {
                    new ClienteDAO().create(cliente);
                }
                else //if editando == true
                {
                    new ClienteDAO().update(cliente, cpfAntigo);
                }

                carregarTabelaClientes(new ClienteDAO().read(""));
                btnNovoSalvar.Text = "Novo";
                btnApagarCancelar.Text = "Apagar";
                btnEditar.Enabled = true;
                bloquearFormulario(true);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            editando = true;
            cpfAntigo = txtCpf.Text;
            btnApagarCancelar.Text = "Cancelar";
            btnNovoSalvar.Text = "Salvar";
            btnEditar.Enabled = false;
            bloquearFormulario(false);
        }

        private void btnApagarCancelar_Click(object sender, EventArgs e)
        {
            if (btnApagarCancelar.Text == "Apagar")
            {
                Cliente cliente = new Cliente();
                cliente.Cpf = txtCpf.Text;

                new ClienteDAO().delete(cliente);

                limparFormulario();
                carregarTabelaClientes(new ClienteDAO().read(""));
                selecionarPrimeiraLinhaTabelaClientes();
            }
            else //if text == Cancelar
            {
                editando = false;
                cpfAntigo = null;
                bloquearFormulario(true);
                limparFormulario();
                btnNovoSalvar.Text = "Novo";
                btnApagarCancelar.Text = "Apagar";
                btnEditar.Enabled = true;
                carregarTabelaClientes(new ClienteDAO().read(""));
                dgvClientes_CellClick(null, null);
            }
        }
        
        private void limparFormulario()
        {
            txtNome.Text = "";
            txtCpf.Text = "";
            txtTelefone.Text = "";
            txtCep.Text = "";
            txtRua.Text = "";
            txtNumero.Text = "";
            txtBairro.Text = "";
        }

        private void carregarTabelaClientes(List<Cliente> clientes)
        {
            dgvClientes.Rows.Clear();
            
            foreach (Cliente cliente in clientes)
            {
                dgvClientes.Rows.Add(cliente, cliente.Nome);
            }

            dgvClientes.ClearSelection();
            
            btnApagarCancelar.Enabled = dgvClientes.RowCount > 0;
            btnEditar.Enabled = dgvClientes.RowCount > 0;
        }

        private void bloquearFormulario(bool bloqueio)
        {
            txtNome.ReadOnly = bloqueio;
            txtCpf.ReadOnly = bloqueio;
            txtTelefone.ReadOnly = bloqueio;
            txtCep.ReadOnly = bloqueio;
            txtRua.ReadOnly = bloqueio;
            txtNumero.ReadOnly = bloqueio;
            txtBairro.ReadOnly = bloqueio;
            /*
            if (bloqueio == false)
                txtPesquisar.Text = "";*/
            pnlClientes.Enabled = bloqueio;
        }

        private void selecionarPrimeiraLinhaTabelaClientes()
        {
            try
            {
                dgvClientes.CurrentCell = dgvClientes.Rows[0].Cells[1];
                dgvClientes.Rows[0].Cells[1].Selected = true;
                dgvClientes_CellClick(null, null);
            }
            catch (Exception) { }
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            carregarTabelaClientes(new ClienteDAO().read(txtPesquisar.Text));

            selecionarPrimeiraLinhaTabelaClientes();
        }
        
        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvClientes.RowCount < 1)
                return;

            Cliente cliente = (Cliente)dgvClientes.Rows[dgvClientes.CurrentRow.Index].Cells[0].Value;

            txtNome.Text = cliente.Nome;
            txtCpf.Text = cliente.Cpf;
            txtTelefone.Text = cliente.Telefone;
            txtCep.Text = cliente.Cep;
            txtRua.Text = cliente.Rua;
            txtNumero.Text = cliente.Numero.ToString();
            txtBairro.Text = cliente.Bairro;
        }

        private void txtTelefone_TextChanged(object sender, EventArgs e)
        {
            if (txtTelefone.Text.Length > 10)
                txtTelefone.Mask = "(00)00000-0000";
            else
                txtTelefone.Mask = "(00)0000-00000";
        }

        private void estilizar()
        {
            this.BackColor = Color.White;

            dgvClientes.DefaultCellStyle.SelectionBackColor = Color.White;
            dgvClientes.DefaultCellStyle.SelectionForeColor = Color.FromArgb(254, 27, 72);
            dgvClientes.ForeColor = Color.Black;
            dgvClientes.BackgroundColor = Color.White;
            dgvClientes.GridColor = Color.White;

            dgvClientes.RowsDefaultCellStyle.Font = new Font(DataGridView.DefaultFont, FontStyle.Bold);

            btnNovoSalvar.FlatStyle = FlatStyle.Flat;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnApagarCancelar.FlatStyle = FlatStyle.Flat;
        }

        private void txtCpf_TextChanged(object sender, EventArgs e)
        {
          btnNovoSalvar.Enabled = new ClienteDAO().readOneByCpf(txtCpf.Text).Cpf == null;
        }
    }
}

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
    public partial class frmTelaProduto : Form
    {
        private bool editando;

        public frmTelaProduto()
        {
            InitializeComponent();
        }
        
        private void TelaProduto_Load(object sender, EventArgs e)
        {
            estilizar();

            //a primeira coluna armazenará um objeto do tipo Produto
            dgvProdutos.Columns.Add("produto", "Produto");
            dgvProdutos.Columns[0].Visible = false;

            //a segunda coluna armazenará o seu nome
            dgvProdutos.Columns.Add("nome", "Nome");
            dgvProdutos.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            carregarTabelaProdutos(new ProdutoDAO().read(""));
            bloquearFormulario(true);
            selecionarPrimeiraLinhaTabelaProdutos();
        }
        
        private void carregarTabelaProdutos(List<Produto> produtos)
        {
            dgvProdutos.Rows.Clear();

            foreach (Produto produto in produtos)
            {
                dgvProdutos.Rows.Add(produto, produto.Nome);
            }

            dgvProdutos.ClearSelection();

            btnApagarCancelar.Enabled = dgvProdutos.RowCount > 0;
            btnEditar.Enabled = dgvProdutos.RowCount > 0;
        }

        private void btnNovoSalvar_Click(object sender, EventArgs e)
        {
            if (btnNovoSalvar.Text == "Novo")
            {
                limparFormulario();
                bloquearFormulario(false);
                dgvProdutos.ClearSelection();
                btnEditar.Enabled = false;
                txtNome.Focus();

                btnApagarCancelar.Enabled = true;
                btnApagarCancelar.Text = "Cancelar";
                btnNovoSalvar.Text = "Salvar";
            }
            else //if text == salvar
            {
                Produto produto = new Produto();

                produto.Nome = txtNome.Text;
                produto.Codigo = int.Parse(lblNumeroCodigo.Text);
                produto.Descricao = txtDescricao.Text;
                produto.Categoria = txtCategoria.Text;
                if (txtPreco.Text.Length > 0)
                    produto.Preco = float.Parse(txtPreco.Text);

                if (editando == false)
                {
                    new ProdutoDAO().create(produto);
                }
                else //if editando == true
                {
                    new ProdutoDAO().update(produto);
                }

                carregarTabelaProdutos(new ProdutoDAO().read(""));
                btnNovoSalvar.Text = "Novo";
                btnApagarCancelar.Text = "Apagar";
                btnEditar.Enabled = true;
                bloquearFormulario(true);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            editando = true;
            btnApagarCancelar.Text = "Cancelar";
            btnNovoSalvar.Text = "Salvar";
            btnEditar.Enabled = false;
            bloquearFormulario(false);
        }

        private void btnApagarCancelar_Click(object sender, EventArgs e)
        {
            if (btnApagarCancelar.Text == "Apagar")
            {
                Produto produto = new Produto();
                produto.Codigo = int.Parse(lblNumeroCodigo.Text);

                new ProdutoDAO().delete(produto);

                limparFormulario();
                carregarTabelaProdutos(new ProdutoDAO().read(""));
                selecionarPrimeiraLinhaTabelaProdutos();
            }
            else //if text == Cancelar
            {
                editando = false;
                bloquearFormulario(true);
                limparFormulario();
                btnNovoSalvar.Text = "Novo";
                btnApagarCancelar.Text = "Apagar";
                btnEditar.Enabled = true;
                //btnApagarCancelar.Enabled = false;
                carregarTabelaProdutos(new ProdutoDAO().read(""));
                dgvProdutos_CellEnter(null, null);
            }
        }

        private void limparFormulario()
        {
            txtNome.Text = "";
            txtDescricao.Text = "";
            txtCategoria.Text = "";
            txtPreco.Text = "";
        }

        private void bloquearFormulario(bool bloqueio)
        {
            txtNome.ReadOnly = bloqueio;
            txtDescricao.ReadOnly = bloqueio;
            txtCategoria.ReadOnly = bloqueio;
            txtPreco.ReadOnly = bloqueio;

            if (bloqueio == false)
                txtPesquisar.Text = "";
            pnlProdutos.Enabled = bloqueio;
        }

        private void selecionarPrimeiraLinhaTabelaProdutos()
        {
            try
            {
                dgvProdutos.CurrentCell = dgvProdutos.Rows[0].Cells[1];
                dgvProdutos.Rows[0].Cells[1].Selected = true;
                dgvProdutos_CellEnter(null, null);
            }
            catch (Exception) { }
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            carregarTabelaProdutos(new ProdutoDAO().read(txtPesquisar.Text));

            selecionarPrimeiraLinhaTabelaProdutos();
        }

        private void dgvProdutos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProdutos.RowCount < 1)
                return;

            Produto produto = (Produto)dgvProdutos.Rows[dgvProdutos.CurrentRow.Index].Cells[0].Value;

            txtNome.Text = produto.Nome;
            lblNumeroCodigo.Text = produto.Codigo.ToString();
            txtDescricao.Text = produto.Descricao;
            txtCategoria.Text = produto.Categoria;
            txtPreco.Text = produto.Preco.ToString();
        }

        private void estilizar()
        {
            this.BackColor = Color.White;
            
            dgvProdutos.DefaultCellStyle.SelectionBackColor = Color.White;
            dgvProdutos.DefaultCellStyle.SelectionForeColor = Color.FromArgb(254, 27, 72);
            dgvProdutos.ForeColor = Color.Black;
            dgvProdutos.BackgroundColor = Color.White;
            dgvProdutos.GridColor = Color.White;
            
            dgvProdutos.RowsDefaultCellStyle.Font = new Font(DataGridView.DefaultFont, FontStyle.Bold);

            btnNovoSalvar.FlatStyle = FlatStyle.Flat;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnApagarCancelar.FlatStyle = FlatStyle.Flat;
        }
    }
}

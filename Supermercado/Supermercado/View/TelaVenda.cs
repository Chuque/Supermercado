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
    public partial class frmTelaVenda : Form
    {
        private string nomeFuncionarioAtual;
        private bool editando = false;
        private float total = 0;

        public frmTelaVenda(string nomeFuncionario)
        {
            this.nomeFuncionarioAtual = nomeFuncionario;
            InitializeComponent();
        }

        private void frmTelaVenda_Load(object sender, EventArgs e)
        {
            //teste autocompletesource



            //fim autocomplete source

            estilizar();

            //a primeira coluna armazenará um objeto do tipo Venda e ficará oculta
            dgvVendas.Columns.Add("venda", "Venda");
            dgvVendas.Columns[0].Visible = false;
            //a segunda coluna armazenará o nome do cliente
            dgvVendas.Columns.Add("nomeCliente", "NomeCliente");
            dgvVendas.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            
            //a primeira coluna armazenará um objeto do tipo Produto e ficará oculta
            dgvProdutos.Columns.Add("produto", "Produto");
            dgvProdutos.Columns[0].Visible = false;
            //a segunda coluna armazenará o seu nome
            dgvProdutos.Columns.Add("nome", "Nome");
            dgvProdutos.Columns[1].Width = 100;
            //a terceira coluna armazenará o seu valor
            dgvProdutos.Columns.Add("valor", "Valor");
            dgvProdutos.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            //a primeira coluna armazenará um objeto do tipo Produto e ficará oculta
            dgvProdutosVenda.Columns.Add("produto", "Produto");
            dgvProdutosVenda.Columns[0].Visible = false;
            //a segunda coluna armazenará o seu nome
            dgvProdutosVenda.Columns.Add("nome", "Nome");
            dgvProdutosVenda.Columns[1].Width = 110;
            //a terceira coluna armazenará a quantidade
            dgvProdutosVenda.Columns.Add("quantidade", "Qtd");
            dgvProdutosVenda.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            
            carregarTabelaVendas(new VendaDAO().read(""));
            carregarTabelaProdutos(new ProdutoDAO().read(""));
            carregarTextBoxCliente(new ClienteDAO().read(""));
            bloquearFormulario(true);
            selecionarPrimeiraLinhaTabelaVendas();

            txtPesquisar.Focus();
        }

        private void carregarTabelaVendas(List<Venda> vendas)
        {
            dgvVendas.Rows.Clear();

            foreach (Venda venda in vendas)
            {
                dgvVendas.Rows.Add(venda, venda.Cliente.Nome);
            }

            dgvVendas.ClearSelection();

            btnApagarCancelar.Enabled = dgvVendas.RowCount > 0;
            btnEditar.Enabled = dgvVendas.RowCount > 0;
        }

        private void carregarTabelaProdutos(List<Produto> produtos)
        {
            dgvProdutos.Rows.Clear();

            foreach (Produto produto in produtos)
            {
                dgvProdutos.Rows.Add(produto, produto.Nome, produto.Preco.ToString("0.00"));
            }

            dgvProdutos.ClearSelection();
        }

        private void selecionarPrimeiraLinhaTabelaVendas()
        {
            try
            {
                dgvVendas.CurrentCell = dgvVendas.Rows[0].Cells[1];
                dgvVendas.Rows[0].Cells[1].Selected = true;
                dgvVendas_CellClick(null, null);
            }
            catch (Exception) { }
        }
        /*
        private void dgvVendas_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvVendas.RowCount < 1)
                return;

            Venda venda = (Venda)dgvVendas.Rows[dgvVendas.CurrentRow.Index].Cells[0].Value;
            /*
            txtNome.Text = venda.Nome;
            lblNumeroCodigo.Text = venda.Codigo.ToString();
            txtDescricao.Text = venda.Descricao;
            txtCategoria.Text = venda.Categoria;
            txtPreco.Text = venda.Preco.ToString();*//*
        }*/
        
        //funções copiadas

        private void btnNovoSalvar_Click(object sender, EventArgs e)
        {
            if (btnNovoSalvar.Text == "Novo")
            {
                limparFormulario();
                bloquearFormulario(false);
                dgvVendas.ClearSelection();
                btnEditar.Enabled = false;
                txtNomeFuncionario.Text = nomeFuncionarioAtual;
                txtCliente.Focus();

                btnApagarCancelar.Enabled = true;
                btnApagarCancelar.Text = "Cancelar";
                btnNovoSalvar.Text = "Salvar";
            }
            else //if text == salvar
            {
                Venda venda = new Venda();

                venda.Cliente = new ClienteDAO().readOneByCpf(txtCliente.Text);
                if (txtTotal.Text != "")
                    venda.ValorTotal = float.Parse(txtTotal.Text);
                else
                    venda.ValorTotal = 0;
                venda.NomeFuncionario = txtNomeFuncionario.Text;
                venda.DataHora = DateTime.Now;
                for(int linha = 0;linha < dgvProdutosVenda.RowCount;linha++)
                {
                    venda.adicionarProduto((Produto)dgvProdutosVenda.Rows[linha].Cells[0].Value);
                }

                if (editando == false)
                {
                    new VendaDAO().create(venda);
                }
                else //if editando == true
                {
                    new VendaDAO().update(venda);
                }

                carregarTabelaVendas(new VendaDAO().read(""));
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
                Venda venda = new Venda();
                venda.Numero = int.Parse(txtNumero.Text);

                new VendaDAO().delete(venda);

                limparFormulario();
                carregarTabelaVendas(new VendaDAO().read(""));
                selecionarPrimeiraLinhaTabelaVendas();
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
                carregarTabelaVendas(new VendaDAO().read(""));
                dgvVendas_CellClick(null, null);
            }
        }

        private void limparFormulario()
        {
            txtCliente.Text = "";
            txtNumero.Text = "";
            txtNomeFuncionario.Text = "";
            txtDataHora.Text = "";
            zerarTotal();

            dgvProdutosVenda.Rows.Clear();
        }

        private void carregarTextBoxCliente(List<Cliente> clientes)
        {/*
            txtCliente.DataSource = clientes;
            txtCliente.DisplayMember = "Nome";
            txtCliente.ValueMember = "Nome";
            */
            
            /*
            cbbClientes.Items.Clear();

            foreach (Cliente cliente in clientes)
            {
                cbbClientes.Items.Add(cliente);
            }
            */
        }

        private void bloquearFormulario(bool bloqueio)
        {
            txtPesquisarProdutos.Text = "";
            txtPesquisarProdutos.ReadOnly = bloqueio;
            txtCliente.ReadOnly = bloqueio;
            dgvProdutosVenda.Enabled = !bloqueio;
            dgvProdutos.Enabled = !bloqueio;
            //dgvProdutosVenda.Enabled = true;
            if(bloqueio)
            {
                btnAdicionar.Enabled = !bloqueio;
                btnRemover.Enabled = !bloqueio;
                txtQuantidade.Enabled = !bloqueio;
            }

            if(bloqueio == false)
                txtPesquisar.Text = "";
            pnlVendas.Enabled = bloqueio;
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            carregarTabelaVendas(new VendaDAO().read(txtPesquisar.Text));

            selecionarPrimeiraLinhaTabelaVendas();
        }

        private void dgvVendas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvVendas.RowCount < 1)
                return;

            Venda venda = (Venda)dgvVendas.Rows[dgvVendas.CurrentRow.Index].Cells[0].Value;

            txtCliente.Text = venda.Cliente.Cpf;
            txtNumero.Text = venda.Numero.ToString();
            txtNomeFuncionario.Text = venda.NomeFuncionario;
            txtDataHora.Text = venda.DataHora.ToString("dd/MM/yyyy HH:mm:ss");
            atualizarTextBoxTotal(venda.ValorTotal);

            carregarTabelaProdutosVenda(venda.Produtos);
        }

        //fim de funções copiadas

        private void carregarTabelaProdutosVenda(List<Produto> produtosVenda)
        {
            dgvProdutosVenda.Rows.Clear();

            foreach(Produto produto in produtosVenda)
            {
                dgvProdutosVenda.Rows.Add(produto, produto.Nome, produto.Quantidade);
            }
        }

        private void dgvProdutos_CellEnter(object sender, EventArgs e)
        {
            btnRemover.Enabled = false;
            dgvProdutosVenda.ClearSelection();
            txtQuantidade.Enabled = true;
            txtQuantidade.Focus();
            txtQuantidade.Select(0, txtQuantidade.Text.Length);
        }

        private void dgvProdutosVenda_CellEnter(object sender, EventArgs e)
        {
            btnRemover.Enabled = true;
            btnAdicionar.Enabled = false;
            txtQuantidade.Text = "";
            txtQuantidade.Enabled = false;
            dgvProdutos.ClearSelection();
            AcceptButton = btnRemover;
            btnRemover.Focus();
        }

        private void cbbClientes_TextChanged(object sender, EventArgs e)
        {
            carregarTextBoxCliente(new ClienteDAO().read(txtCliente.Text));
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Produto produto = (Produto)dgvProdutos.Rows[dgvProdutos.CurrentRow.Index].Cells[0].Value;
            produto.Quantidade = int.Parse(txtQuantidade.Text);
            dgvProdutosVenda.Rows.Add(produto, produto.Nome, produto.Quantidade);
            somarTotal(produto.Preco, produto.Quantidade);
            dgvProdutos.ClearSelection();
            dgvProdutosVenda.ClearSelection();
            txtQuantidade.Text = "";
            txtQuantidade.Enabled = false;
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            Produto produto = (Produto)dgvProdutosVenda.Rows[dgvProdutosVenda.CurrentRow.Index].Cells[0].Value;
            dgvProdutosVenda.Rows.Remove(dgvProdutosVenda.Rows[dgvProdutosVenda.CurrentRow.Index]);
            subtrairTotal(produto.Preco, produto.Quantidade);
            if (total == 0)
                zerarTotal();
            if (dgvProdutosVenda.RowCount == 0)
                btnRemover.Enabled = false;
        }

        private void txtQuantidade_TextChanged(object sender, EventArgs e)
        {
            if (txtQuantidade.Text != "")
            {
                btnAdicionar.Enabled = int.Parse(txtQuantidade.Text) > 0;
                AcceptButton = btnAdicionar;
            }
            else
            {
                btnAdicionar.Enabled = false;
                AcceptButton = null;
            }
        }

        private void somarTotal(float valor, int quantidade)
        {
            total = total + (valor * quantidade);
            atualizarTextBoxTotal(total);
        }

        private void subtrairTotal(float valor, int quantidade)
        {
            total = total - (valor * quantidade);
            atualizarTextBoxTotal(total);
        }

        private void zerarTotal()
        {
            total = 0;
            atualizarTextBoxTotal(total);
        }

        private void atualizarTextBoxTotal(float valor)
        {
            txtTotal.Text = valor.ToString("0.00");
        }

        private void estilizar()
        {
            this.BackColor = Color.White;

            dgvVendas.DefaultCellStyle.SelectionBackColor = Color.White;
            dgvVendas.DefaultCellStyle.SelectionForeColor = Color.FromArgb(254, 27, 72);
            dgvVendas.ForeColor = Color.Black;
            dgvVendas.BackgroundColor = Color.White;
            dgvVendas.GridColor = Color.White;

            dgvProdutos.DefaultCellStyle.SelectionBackColor = Color.White;
            dgvProdutos.DefaultCellStyle.SelectionForeColor = Color.FromArgb(254, 27, 72);
            dgvProdutos.ForeColor = Color.Black;
            dgvProdutos.BackgroundColor = Color.White;
            dgvProdutos.GridColor = Color.White;

            dgvProdutosVenda.DefaultCellStyle.SelectionBackColor = Color.White;
            dgvProdutosVenda.DefaultCellStyle.SelectionForeColor = Color.FromArgb(254, 27, 72);
            dgvProdutosVenda.ForeColor = Color.Black;
            dgvProdutosVenda.BackgroundColor = Color.White;
            dgvProdutosVenda.GridColor = Color.White;

            dgvVendas.RowsDefaultCellStyle.Font = new Font(DataGridView.DefaultFont, FontStyle.Bold);

            btnNovoSalvar.FlatStyle = FlatStyle.Flat;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnApagarCancelar.FlatStyle = FlatStyle.Flat;
        }

        private void txtPesquisarProdutos_TextChanged(object sender, EventArgs e)
        {
            carregarTabelaProdutos(new ProdutoDAO().read(txtPesquisar.Text));
        }

        private void txtCliente_TextChanged(object sender, EventArgs e)
        {
            Cliente cliente = new ClienteDAO().readOneByCpf(txtCliente.Text);
            
            btnNovoSalvar.Enabled = (cliente.Cpf != null);
            txtNomeCliente.Text = cliente.Nome;
        }
    }
}

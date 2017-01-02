namespace Supermercado.View
{
    partial class frmTelaVenda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnNovoSalvar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnApagarCancelar = new System.Windows.Forms.Button();
            this.pnlDadosVenda = new System.Windows.Forms.Panel();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.lblNomeCliente = new System.Windows.Forms.Label();
            this.txtPesquisarProdutos = new System.Windows.Forms.TextBox();
            this.txtCliente = new System.Windows.Forms.MaskedTextBox();
            this.txtTotal = new System.Windows.Forms.MaskedTextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtDataHora = new System.Windows.Forms.TextBox();
            this.txtNomeFuncionario = new System.Windows.Forms.TextBox();
            this.lblNomeFuncionario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDataHora = new System.Windows.Forms.Label();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.MaskedTextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.dgvProdutosVenda = new System.Windows.Forms.DataGridView();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.pnlVendas = new System.Windows.Forms.Panel();
            this.dgvVendas = new System.Windows.Forms.DataGridView();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.pnlDadosVenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutosVenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.pnlVendas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNovoSalvar
            // 
            this.btnNovoSalvar.Location = new System.Drawing.Point(465, 323);
            this.btnNovoSalvar.Name = "btnNovoSalvar";
            this.btnNovoSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnNovoSalvar.TabIndex = 14;
            this.btnNovoSalvar.TabStop = false;
            this.btnNovoSalvar.Text = "Novo";
            this.btnNovoSalvar.UseVisualStyleBackColor = true;
            this.btnNovoSalvar.Click += new System.EventHandler(this.btnNovoSalvar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Enabled = false;
            this.btnEditar.Location = new System.Drawing.Point(384, 323);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 13;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnApagarCancelar
            // 
            this.btnApagarCancelar.Enabled = false;
            this.btnApagarCancelar.Location = new System.Drawing.Point(303, 323);
            this.btnApagarCancelar.Name = "btnApagarCancelar";
            this.btnApagarCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnApagarCancelar.TabIndex = 12;
            this.btnApagarCancelar.Text = "Apagar";
            this.btnApagarCancelar.UseVisualStyleBackColor = true;
            this.btnApagarCancelar.Click += new System.EventHandler(this.btnApagarCancelar_Click);
            // 
            // pnlDadosVenda
            // 
            this.pnlDadosVenda.Controls.Add(this.txtNomeCliente);
            this.pnlDadosVenda.Controls.Add(this.lblNomeCliente);
            this.pnlDadosVenda.Controls.Add(this.txtPesquisarProdutos);
            this.pnlDadosVenda.Controls.Add(this.txtCliente);
            this.pnlDadosVenda.Controls.Add(this.txtTotal);
            this.pnlDadosVenda.Controls.Add(this.lblTotal);
            this.pnlDadosVenda.Controls.Add(this.txtNumero);
            this.pnlDadosVenda.Controls.Add(this.txtDataHora);
            this.pnlDadosVenda.Controls.Add(this.txtNomeFuncionario);
            this.pnlDadosVenda.Controls.Add(this.lblNomeFuncionario);
            this.pnlDadosVenda.Controls.Add(this.label1);
            this.pnlDadosVenda.Controls.Add(this.lblDataHora);
            this.pnlDadosVenda.Controls.Add(this.lblQuantidade);
            this.pnlDadosVenda.Controls.Add(this.lblNumero);
            this.pnlDadosVenda.Controls.Add(this.txtQuantidade);
            this.pnlDadosVenda.Controls.Add(this.lblCliente);
            this.pnlDadosVenda.Controls.Add(this.btnRemover);
            this.pnlDadosVenda.Controls.Add(this.btnAdicionar);
            this.pnlDadosVenda.Controls.Add(this.dgvProdutosVenda);
            this.pnlDadosVenda.Controls.Add(this.dgvProdutos);
            this.pnlDadosVenda.Location = new System.Drawing.Point(217, 12);
            this.pnlDadosVenda.Name = "pnlDadosVenda";
            this.pnlDadosVenda.Size = new System.Drawing.Size(325, 305);
            this.pnlDadosVenda.TabIndex = 11;
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Location = new System.Drawing.Point(98, 45);
            this.txtNomeCliente.MaxLength = 50;
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.ReadOnly = true;
            this.txtNomeCliente.Size = new System.Drawing.Size(144, 20);
            this.txtNomeCliente.TabIndex = 46;
            this.txtNomeCliente.TabStop = false;
            // 
            // lblNomeCliente
            // 
            this.lblNomeCliente.AutoSize = true;
            this.lblNomeCliente.Location = new System.Drawing.Point(98, 29);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Size = new System.Drawing.Size(85, 13);
            this.lblNomeCliente.TabIndex = 45;
            this.lblNomeCliente.Text = "Nome do Cliente";
            // 
            // txtPesquisarProdutos
            // 
            this.txtPesquisarProdutos.Location = new System.Drawing.Point(3, 282);
            this.txtPesquisarProdutos.Name = "txtPesquisarProdutos";
            this.txtPesquisarProdutos.ReadOnly = true;
            this.txtPesquisarProdutos.Size = new System.Drawing.Size(144, 20);
            this.txtPesquisarProdutos.TabIndex = 44;
            this.txtPesquisarProdutos.TextChanged += new System.EventHandler(this.txtPesquisarProdutos_TextChanged);
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(3, 45);
            this.txtCliente.Mask = "000.000.000-00";
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.ReadOnly = true;
            this.txtCliente.Size = new System.Drawing.Size(85, 20);
            this.txtCliente.TabIndex = 43;
            this.txtCliente.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtCliente.TextChanged += new System.EventHandler(this.txtCliente_TextChanged);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(248, 282);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(74, 20);
            this.txtTotal.TabIndex = 42;
            this.txtTotal.TabStop = false;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(211, 285);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 13);
            this.lblTotal.TabIndex = 41;
            this.lblTotal.Text = "Total";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(284, 45);
            this.txtNumero.MaxLength = 50;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.ReadOnly = true;
            this.txtNumero.Size = new System.Drawing.Size(38, 20);
            this.txtNumero.TabIndex = 40;
            this.txtNumero.TabStop = false;
            // 
            // txtDataHora
            // 
            this.txtDataHora.Location = new System.Drawing.Point(178, 87);
            this.txtDataHora.MaxLength = 50;
            this.txtDataHora.Name = "txtDataHora";
            this.txtDataHora.ReadOnly = true;
            this.txtDataHora.Size = new System.Drawing.Size(144, 20);
            this.txtDataHora.TabIndex = 39;
            this.txtDataHora.TabStop = false;
            // 
            // txtNomeFuncionario
            // 
            this.txtNomeFuncionario.Location = new System.Drawing.Point(3, 87);
            this.txtNomeFuncionario.MaxLength = 50;
            this.txtNomeFuncionario.Name = "txtNomeFuncionario";
            this.txtNomeFuncionario.ReadOnly = true;
            this.txtNomeFuncionario.Size = new System.Drawing.Size(144, 20);
            this.txtNomeFuncionario.TabIndex = 38;
            this.txtNomeFuncionario.TabStop = false;
            // 
            // lblNomeFuncionario
            // 
            this.lblNomeFuncionario.AutoSize = true;
            this.lblNomeFuncionario.Location = new System.Drawing.Point(3, 71);
            this.lblNomeFuncionario.Name = "lblNomeFuncionario";
            this.lblNomeFuncionario.Size = new System.Drawing.Size(62, 13);
            this.lblNomeFuncionario.TabIndex = 37;
            this.lblNomeFuncionario.Text = "Funcionario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(281, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 36;
            // 
            // lblDataHora
            // 
            this.lblDataHora.AutoSize = true;
            this.lblDataHora.Location = new System.Drawing.Point(178, 71);
            this.lblDataHora.Name = "lblDataHora";
            this.lblDataHora.Size = new System.Drawing.Size(95, 13);
            this.lblDataHora.TabIndex = 35;
            this.lblDataHora.Text = "Data              Hora";
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(150, 144);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(24, 13);
            this.lblQuantidade.TabIndex = 5;
            this.lblQuantidade.Text = "Qtd";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(284, 29);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(29, 13);
            this.lblNumero.TabIndex = 33;
            this.lblNumero.Text = "Num";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Enabled = false;
            this.txtQuantidade.Location = new System.Drawing.Point(151, 160);
            this.txtQuantidade.Mask = "000";
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(23, 20);
            this.txtQuantidade.TabIndex = 4;
            this.txtQuantidade.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtQuantidade.TextChanged += new System.EventHandler(this.txtQuantidade_TextChanged);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(3, 29);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(76, 13);
            this.lblCliente.TabIndex = 31;
            this.lblCliente.Text = "CPF do cliente";
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(151, 215);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(23, 23);
            this.btnRemover.TabIndex = 3;
            this.btnRemover.Text = "<";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Enabled = false;
            this.btnAdicionar.Location = new System.Drawing.Point(151, 186);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(23, 23);
            this.btnAdicionar.TabIndex = 2;
            this.btnAdicionar.Text = ">";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // dgvProdutosVenda
            // 
            this.dgvProdutosVenda.AllowUserToAddRows = false;
            this.dgvProdutosVenda.AllowUserToDeleteRows = false;
            this.dgvProdutosVenda.AllowUserToResizeColumns = false;
            this.dgvProdutosVenda.AllowUserToResizeRows = false;
            this.dgvProdutosVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutosVenda.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvProdutosVenda.Enabled = false;
            this.dgvProdutosVenda.Location = new System.Drawing.Point(178, 113);
            this.dgvProdutosVenda.Name = "dgvProdutosVenda";
            this.dgvProdutosVenda.ReadOnly = true;
            this.dgvProdutosVenda.RowHeadersVisible = false;
            this.dgvProdutosVenda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProdutosVenda.Size = new System.Drawing.Size(144, 160);
            this.dgvProdutosVenda.TabIndex = 24;
            this.dgvProdutosVenda.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdutosVenda_CellEnter);
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AllowUserToAddRows = false;
            this.dgvProdutos.AllowUserToDeleteRows = false;
            this.dgvProdutos.AllowUserToResizeColumns = false;
            this.dgvProdutos.AllowUserToResizeRows = false;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvProdutos.Enabled = false;
            this.dgvProdutos.Location = new System.Drawing.Point(3, 113);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.ReadOnly = true;
            this.dgvProdutos.RowHeadersVisible = false;
            this.dgvProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProdutos.Size = new System.Drawing.Size(144, 160);
            this.dgvProdutos.TabIndex = 15;
            this.dgvProdutos.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdutos_CellEnter);
            // 
            // pnlVendas
            // 
            this.pnlVendas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlVendas.Controls.Add(this.dgvVendas);
            this.pnlVendas.Controls.Add(this.txtPesquisar);
            this.pnlVendas.Location = new System.Drawing.Point(12, 12);
            this.pnlVendas.Name = "pnlVendas";
            this.pnlVendas.Size = new System.Drawing.Size(199, 337);
            this.pnlVendas.TabIndex = 10;
            // 
            // dgvVendas
            // 
            this.dgvVendas.AllowUserToAddRows = false;
            this.dgvVendas.AllowUserToDeleteRows = false;
            this.dgvVendas.AllowUserToResizeColumns = false;
            this.dgvVendas.AllowUserToResizeRows = false;
            this.dgvVendas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVendas.ColumnHeadersVisible = false;
            this.dgvVendas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvVendas.Location = new System.Drawing.Point(3, 29);
            this.dgvVendas.MultiSelect = false;
            this.dgvVendas.Name = "dgvVendas";
            this.dgvVendas.ReadOnly = true;
            this.dgvVendas.RowHeadersVisible = false;
            this.dgvVendas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVendas.Size = new System.Drawing.Size(193, 305);
            this.dgvVendas.TabIndex = 3;
            this.dgvVendas.TabStop = false;
            this.dgvVendas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVendas_CellClick);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPesquisar.Location = new System.Drawing.Point(3, 3);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(193, 20);
            this.txtPesquisar.TabIndex = 1;
            this.txtPesquisar.TextChanged += new System.EventHandler(this.txtPesquisar_TextChanged);
            // 
            // frmTelaVenda
            // 
            this.AcceptButton = this.btnNovoSalvar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 361);
            this.Controls.Add(this.btnNovoSalvar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnApagarCancelar);
            this.Controls.Add(this.pnlDadosVenda);
            this.Controls.Add(this.pnlVendas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmTelaVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendas";
            this.Load += new System.EventHandler(this.frmTelaVenda_Load);
            this.pnlDadosVenda.ResumeLayout(false);
            this.pnlDadosVenda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutosVenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.pnlVendas.ResumeLayout(false);
            this.pnlVendas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNovoSalvar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnApagarCancelar;
        private System.Windows.Forms.Panel pnlDadosVenda;
        private System.Windows.Forms.DataGridView dgvProdutosVenda;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.Panel pnlVendas;
        private System.Windows.Forms.DataGridView dgvVendas;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.MaskedTextBox txtQuantidade;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDataHora;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtDataHora;
        private System.Windows.Forms.TextBox txtNomeFuncionario;
        private System.Windows.Forms.Label lblNomeFuncionario;
        private System.Windows.Forms.MaskedTextBox txtTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.MaskedTextBox txtCliente;
        private System.Windows.Forms.TextBox txtPesquisarProdutos;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.Label lblNomeCliente;
    }
}
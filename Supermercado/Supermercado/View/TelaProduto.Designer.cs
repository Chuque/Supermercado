namespace Supermercado.View
{
    partial class frmTelaProduto
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
            this.pnlDadosProduto = new System.Windows.Forms.Panel();
            this.lblNumeroCodigo = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.MaskedTextBox();
            this.lblPreco = new System.Windows.Forms.Label();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.pnlProdutos = new System.Windows.Forms.Panel();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.pnlDadosProduto.SuspendLayout();
            this.pnlProdutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNovoSalvar
            // 
            this.btnNovoSalvar.Location = new System.Drawing.Point(465, 323);
            this.btnNovoSalvar.Name = "btnNovoSalvar";
            this.btnNovoSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnNovoSalvar.TabIndex = 9;
            this.btnNovoSalvar.Text = "Novo";
            this.btnNovoSalvar.UseVisualStyleBackColor = true;
            this.btnNovoSalvar.Click += new System.EventHandler(this.btnNovoSalvar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(384, 323);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 8;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnApagarCancelar
            // 
            this.btnApagarCancelar.Location = new System.Drawing.Point(303, 323);
            this.btnApagarCancelar.Name = "btnApagarCancelar";
            this.btnApagarCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnApagarCancelar.TabIndex = 7;
            this.btnApagarCancelar.Text = "Apagar";
            this.btnApagarCancelar.UseVisualStyleBackColor = true;
            this.btnApagarCancelar.Click += new System.EventHandler(this.btnApagarCancelar_Click);
            // 
            // pnlDadosProduto
            // 
            this.pnlDadosProduto.Controls.Add(this.lblNumeroCodigo);
            this.pnlDadosProduto.Controls.Add(this.txtPreco);
            this.pnlDadosProduto.Controls.Add(this.lblPreco);
            this.pnlDadosProduto.Controls.Add(this.txtCategoria);
            this.pnlDadosProduto.Controls.Add(this.lblCategoria);
            this.pnlDadosProduto.Controls.Add(this.txtDescricao);
            this.pnlDadosProduto.Controls.Add(this.lblCodigo);
            this.pnlDadosProduto.Controls.Add(this.txtNome);
            this.pnlDadosProduto.Controls.Add(this.lblNome);
            this.pnlDadosProduto.Controls.Add(this.lblDescricao);
            this.pnlDadosProduto.Location = new System.Drawing.Point(217, 12);
            this.pnlDadosProduto.Name = "pnlDadosProduto";
            this.pnlDadosProduto.Size = new System.Drawing.Size(325, 305);
            this.pnlDadosProduto.TabIndex = 6;
            // 
            // lblNumeroCodigo
            // 
            this.lblNumeroCodigo.AutoSize = true;
            this.lblNumeroCodigo.Location = new System.Drawing.Point(281, 52);
            this.lblNumeroCodigo.Name = "lblNumeroCodigo";
            this.lblNumeroCodigo.Size = new System.Drawing.Size(13, 13);
            this.lblNumeroCodigo.TabIndex = 30;
            this.lblNumeroCodigo.Text = "0";
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(269, 186);
            this.txtPreco.Mask = "00000,00";
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(53, 20);
            this.txtPreco.TabIndex = 29;
            this.txtPreco.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(269, 170);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(35, 13);
            this.lblPreco.TabIndex = 28;
            this.lblPreco.Text = "Preco";
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(3, 186);
            this.txtCategoria.MaxLength = 50;
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(254, 20);
            this.txtCategoria.TabIndex = 27;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(3, 170);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(52, 13);
            this.lblCategoria.TabIndex = 26;
            this.lblCategoria.Text = "Categoria";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(3, 95);
            this.txtDescricao.MaxLength = 200;
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(319, 60);
            this.txtDescricao.TabIndex = 25;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(281, 29);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(26, 13);
            this.lblCodigo.TabIndex = 23;
            this.lblCodigo.Text = "Cod";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(3, 45);
            this.txtNome.MaxLength = 50;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(254, 20);
            this.txtNome.TabIndex = 2;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(3, 29);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(3, 79);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(55, 13);
            this.lblDescricao.TabIndex = 0;
            this.lblDescricao.Text = "Descrição";
            // 
            // pnlProdutos
            // 
            this.pnlProdutos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlProdutos.Controls.Add(this.dgvProdutos);
            this.pnlProdutos.Controls.Add(this.txtPesquisar);
            this.pnlProdutos.Location = new System.Drawing.Point(12, 12);
            this.pnlProdutos.Name = "pnlProdutos";
            this.pnlProdutos.Size = new System.Drawing.Size(199, 337);
            this.pnlProdutos.TabIndex = 5;
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AllowUserToAddRows = false;
            this.dgvProdutos.AllowUserToDeleteRows = false;
            this.dgvProdutos.AllowUserToResizeColumns = false;
            this.dgvProdutos.AllowUserToResizeRows = false;
            this.dgvProdutos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.ColumnHeadersVisible = false;
            this.dgvProdutos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvProdutos.Location = new System.Drawing.Point(3, 29);
            this.dgvProdutos.MultiSelect = false;
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.ReadOnly = true;
            this.dgvProdutos.RowHeadersVisible = false;
            this.dgvProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvProdutos.Size = new System.Drawing.Size(193, 305);
            this.dgvProdutos.TabIndex = 3;
            this.dgvProdutos.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdutos_CellEnter);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPesquisar.Location = new System.Drawing.Point(3, 3);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(193, 20);
            this.txtPesquisar.TabIndex = 2;
            this.txtPesquisar.TextChanged += new System.EventHandler(this.txtPesquisar_TextChanged);
            // 
            // frmTelaProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 361);
            this.Controls.Add(this.btnNovoSalvar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnApagarCancelar);
            this.Controls.Add(this.pnlDadosProduto);
            this.Controls.Add(this.pnlProdutos);
            this.MaximizeBox = false;
            this.Name = "frmTelaProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produtos";
            this.Load += new System.EventHandler(this.TelaProduto_Load);
            this.pnlDadosProduto.ResumeLayout(false);
            this.pnlDadosProduto.PerformLayout();
            this.pnlProdutos.ResumeLayout(false);
            this.pnlProdutos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNovoSalvar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnApagarCancelar;
        private System.Windows.Forms.Panel pnlDadosProduto;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Panel pnlProdutos;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.MaskedTextBox txtPreco;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Label lblNumeroCodigo;
    }
}
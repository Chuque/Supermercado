using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermercado.Model
{
    class Venda
    {
        private int numero;
        private DateTime dataHora;
        private float valorTotal;
        private string nomeFuncionario;
        private Cliente cliente;
        private List<Produto> produtos;

        public Venda()
        {
            produtos = new List<Produto>();
        }

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        public DateTime DataHora
        {
            get { return dataHora; }
            set { dataHora = value; }
        }
        public float ValorTotal
        {
            get { return valorTotal; }
            set { valorTotal = value; }
        }
        public string NomeFuncionario
        {
            get { return nomeFuncionario; }
            set { nomeFuncionario = value; }
        }
        public Cliente Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }
        public List<Produto> Produtos
        {
            get { return produtos; }
            set { produtos = value; }
        }

        public void adicionarProduto(Produto produto)
        {
            produtos.Add(produto);
        }

        public void removerProduto(Produto produto)
        {
            produtos.Remove(produto);
        }
    }
}

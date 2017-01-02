using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Supermercado.Model.DAO
{
    class ProdutoVendaDAO
    {
        public void create(int numeroVenda, Produto produto)
        {
            MySqlConnection connection = ConnectionFactory.GetInstance().GetConnection();

            string query = "insert into produtoVenda(numeroVenda, codigoProduto, quantidade) values(@numeroVenda, @codigoProduto, @quantidade)";

            if (connection.State != System.Data.ConnectionState.Open)
                connection.Open();

            MySqlCommand command = new MySqlCommand(query, connection);

            command.Parameters.Add("@numeroVenda", MySqlDbType.Int32);
            command.Parameters.Add("@codigoProduto", MySqlDbType.Int32);
            command.Parameters.Add("@quantidade", MySqlDbType.Int32);

            command.Parameters["@numeroVenda"].Value = numeroVenda;
            command.Parameters["@codigoProduto"].Value = produto.Codigo;
            command.Parameters["@quantidade"].Value = produto.Quantidade;

            command.ExecuteNonQuery();
            connection.Close();
        }
        
        public List<Produto> readByNumeroVenda(int numeroVenda)
        {
            MySqlConnection connection = ConnectionFactory.GetInstance().GetConnection();
            
            string query = "select codigoProduto, quantidade from produtoVenda where numeroVenda = @numeroVenda";
            
            if (connection.State != System.Data.ConnectionState.Open)
                connection.Open();

            MySqlCommand command = new MySqlCommand(query, connection);

            command.Parameters.Add("@numeroVenda", MySqlDbType.Int32);

            command.Parameters["@numeroVenda"].Value = numeroVenda;

            MySqlDataReader dataReader = command.ExecuteReader();

            List<Produto> produtos = new List<Produto>();

            while (dataReader.Read())
            {
                Produto produto = new ProdutoDAO().readOneByCodigo(dataReader.GetInt32("codigoProduto"));

                produtos.Add(produto);
            }

            connection.Close();

            return produtos;
        }

        public void update(int numeroVenda, Produto produto)
        {
            MySqlConnection connection = ConnectionFactory.GetInstance().GetConnection();

            string query = "update produtoVenda set codigoProduto = @codigoProduto, quantidade = @quantidade where numeroVenda = @numeroVenda";

            if (connection.State != System.Data.ConnectionState.Open)
                connection.Open();

            MySqlCommand command = new MySqlCommand(query, connection);

            command.Parameters.Add("@numeroVenda", MySqlDbType.Int32);
            command.Parameters.Add("@codigoProduto", MySqlDbType.Int32);
            command.Parameters.Add("@quantidade", MySqlDbType.Int32);

            command.Parameters["@numeroVenda"].Value = numeroVenda;
            command.Parameters["@codigoProduto"].Value = produto.Codigo;
            command.Parameters["@quantidade"].Value = produto.Quantidade;

            command.ExecuteNonQuery();
            connection.Close();
        }
        
        public void delete(int numeroVenda, Produto produto)
        {
            MySqlConnection connection = ConnectionFactory.GetInstance().GetConnection();

            string query = "delete from produtoVenda where numeroVenda = @numeroVenda and codigoProduto = @codigoProduto";

            if (connection.State != System.Data.ConnectionState.Open)
                connection.Open();

            MySqlCommand command = new MySqlCommand(query, connection);

            command.Parameters.Add("@numeroVenda", MySqlDbType.Int32);
            command.Parameters.Add("@codigoProduto", MySqlDbType.Int32);

            command.Parameters["@numeroVenda"].Value = produto.Codigo;
            command.Parameters["@codigoProduto"].Value = produto.Codigo;

            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}

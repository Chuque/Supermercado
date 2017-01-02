using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Supermercado.Model.DAO
{
    class ProdutoDAO
    {
        public void create(Produto produto)
        {
            MySqlConnection connection = ConnectionFactory.GetInstance().GetConnection();

            string query = "insert into produto(nome, descricao, categoria, preco) values(@nome, @descricao, @categoria, @preco)";

            if (connection.State != System.Data.ConnectionState.Open)
                connection.Open();

            MySqlCommand command = new MySqlCommand(query, connection);
            
            command.Parameters.Add("@nome", MySqlDbType.String);
            command.Parameters.Add("@descricao", MySqlDbType.String);
            command.Parameters.Add("@categoria", MySqlDbType.String);
            command.Parameters.Add("@preco", MySqlDbType.Decimal);
            
            command.Parameters["@nome"].Value = produto.Nome;
            command.Parameters["@descricao"].Value = produto.Descricao;
            command.Parameters["@categoria"].Value = produto.Categoria;
            command.Parameters["@preco"].Value = produto.Preco;

            command.ExecuteNonQuery();
            connection.Close();
        }
        
        public List<Produto> read(string nomeOuCodigo)
        {
            MySqlConnection connection = ConnectionFactory.GetInstance().GetConnection();

            /*
            caso a string nomeOuCodigo:
            
            - seja vazia (""), a pesquisa retornará todos os registros.
            - contenha apenas numeros, a pesquisa retornará as buscas por codigo.
            - contenha algum outro caractere, a pesquisa retornará as buscas por nome.
            */

            string query;

            try
            {
                int.Parse(nomeOuCodigo); //caso a conversão para int não lance exception, a string representará uma busca por codigo...
                query = "select codigo, nome, descricao, categoria, preco from produto where codigo like @nomeOuCodigo order by nome asc";
            }
            catch (Exception)
            {
                //caso a conversão falhe, a string representará uma busca por nome.
                query = "select codigo, nome, descricao, categoria, preco from produto where nome like @nomeOuCodigo order by nome asc";
            }

            if (connection.State != System.Data.ConnectionState.Open)
                connection.Open();

            MySqlCommand command = new MySqlCommand(query, connection);

            command.Parameters.Add("@nomeOuCodigo", MySqlDbType.String);

            command.Parameters["@nomeOuCodigo"].Value = "%" + nomeOuCodigo + "%";

            MySqlDataReader dataReader = command.ExecuteReader();

            List<Produto> produtos = new List<Produto>();

            while (dataReader.Read())
            {
                Produto produto = new Produto();

                produto.Codigo = dataReader.GetInt32("codigo");
                produto.Nome = dataReader.GetString("nome");
                produto.Descricao = dataReader.GetString("descricao");
                produto.Categoria = dataReader.GetString("categoria");
                produto.Preco = dataReader.GetFloat("preco");

                produtos.Add(produto);
            }

            connection.Close();

            return produtos;
        }

        public Produto readOneByCodigo(int codigo)
        {
            MySqlConnection connection = ConnectionFactory.GetInstance().GetConnection();
            
            string query = "select codigo, nome, descricao, categoria, preco from produto where codigo = @codigo";
            
            if (connection.State != System.Data.ConnectionState.Open)
                connection.Open();

            MySqlCommand command = new MySqlCommand(query, connection);

            command.Parameters.Add("@codigo", MySqlDbType.Int32);

            command.Parameters["@codigo"].Value = codigo;

            MySqlDataReader dataReader = command.ExecuteReader();

            Produto produto = new Produto();

            while (dataReader.Read())
            {
                produto.Codigo = dataReader.GetInt32("codigo");
                produto.Nome = dataReader.GetString("nome");
                produto.Descricao = dataReader.GetString("descricao");
                produto.Categoria = dataReader.GetString("categoria");
                produto.Preco = dataReader.GetFloat("preco");
            }

            connection.Close();

            return produto;
        }

        public void update(Produto produto)
        {
            MySqlConnection connection = ConnectionFactory.GetInstance().GetConnection();

            string query = "update produto set nome = @nome, descricao = @descricao, categoria = @categoria, preco = @preco where codigo = @codigo";

            if (connection.State != System.Data.ConnectionState.Open)
                connection.Open();

            MySqlCommand command = new MySqlCommand(query, connection);
            
            command.Parameters.Add("@nome", MySqlDbType.String);
            command.Parameters.Add("@descricao", MySqlDbType.String);
            command.Parameters.Add("@categoria", MySqlDbType.String);
            command.Parameters.Add("@preco", MySqlDbType.String);
            command.Parameters.Add("@codigo", MySqlDbType.Int32);
            
            command.Parameters["@nome"].Value = produto.Nome;
            command.Parameters["@descricao"].Value = produto.Descricao;
            command.Parameters["@categoria"].Value = produto.Categoria;
            command.Parameters["@preco"].Value = produto.Preco;
            command.Parameters["@codigo"].Value = produto.Codigo;

            command.ExecuteNonQuery();
            connection.Close();
        }

        public void delete(Produto produto)
        {
            MySqlConnection connection = ConnectionFactory.GetInstance().GetConnection();

            string query = "delete from produto where codigo = @codigo";

            if (connection.State != System.Data.ConnectionState.Open)
                connection.Open();

            MySqlCommand command = new MySqlCommand(query, connection);

            command.Parameters.Add("@codigo", MySqlDbType.Int32);

            command.Parameters["@codigo"].Value = produto.Codigo;

            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}

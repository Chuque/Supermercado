using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Supermercado.Model.DAO
{
    class ClienteDAO
    {
        public void create(Cliente cliente)
        {
            MySqlConnection connection = ConnectionFactory.GetInstance().GetConnection();

            string query = "insert into cliente(cpf, nome, telefone, cep, rua, numero, bairro) values(@cpf, @nome, @telefone, @cep, @rua, @numero, @bairro)";

            if (connection.State != System.Data.ConnectionState.Open)
                connection.Open();

            MySqlCommand command = new MySqlCommand(query, connection);

            command.Parameters.Add("@cpf", MySqlDbType.String);
            command.Parameters.Add("@nome", MySqlDbType.String);
            command.Parameters.Add("@telefone", MySqlDbType.String);
            command.Parameters.Add("@cep", MySqlDbType.String);
            command.Parameters.Add("@rua", MySqlDbType.String);
            command.Parameters.Add("@numero", MySqlDbType.UInt32);
            command.Parameters.Add("@bairro", MySqlDbType.String);

            command.Parameters["@cpf"].Value = cliente.Cpf;
            command.Parameters["@nome"].Value = cliente.Nome;
            command.Parameters["@telefone"].Value = cliente.Telefone;
            command.Parameters["@cep"].Value = cliente.Cep;
            command.Parameters["@rua"].Value = cliente.Rua;
            command.Parameters["@numero"].Value = cliente.Numero;
            command.Parameters["@bairro"].Value = cliente.Bairro;

            command.ExecuteNonQuery();
            connection.Close();
        }

        public List<Cliente> read(string nomeOuCpf)
        {
            MySqlConnection connection = ConnectionFactory.GetInstance().GetConnection();

            /*
            caso a string nomeOuCpf:
            
            - seja vazia (""), a pesquisa retornará todos os registros.
            - contenha apenas numeros, a pesquisa retornará as buscas por CPF.
            - contenha algum outro caractere, a pesquisa retornará as buscas por nome.
            */

            string query;
            
            try
            {
                long.Parse(nomeOuCpf); //caso a conversão para long não lance exception, a string representará uma busca por CPF...
                query = "select cpf, nome, telefone, cep, rua, numero, bairro from cliente where cpf like @nomeOuCpf order by nome asc";
            }
            catch(Exception)
            {
                //caso a conversão falhe, a string representará uma busca por nome.
                query = "select cpf, nome, telefone, cep, rua, numero, bairro from cliente where nome like @nomeOuCpf order by nome asc";
            }

            if (connection.State != System.Data.ConnectionState.Open)
                connection.Open();

            MySqlCommand command = new MySqlCommand(query, connection);

            command.Parameters.Add("@nomeOuCpf", MySqlDbType.String);

            command.Parameters["@nomeOuCpf"].Value = "%" + nomeOuCpf + "%";

            MySqlDataReader dataReader = command.ExecuteReader();

            List<Cliente> clientes = new List<Cliente>();

            while (dataReader.Read())
            {
                Cliente cliente = new Cliente();

                cliente.Cpf = dataReader.GetString("cpf");
                cliente.Nome = dataReader.GetString("nome");
                cliente.Telefone = dataReader.GetString("telefone");
                cliente.Cep = dataReader.GetString("cep");
                cliente.Rua = dataReader.GetString("rua");
                cliente.Numero = dataReader.GetInt32("numero");
                cliente.Bairro = dataReader.GetString("bairro");

                clientes.Add(cliente);
            }

            connection.Close();

            return clientes;
        }

        public Cliente readOneByCpf(string cpf)
        {
            MySqlConnection connection = ConnectionFactory.GetInstance().GetConnection();
            
            string query = "select cpf, nome, telefone, cep, rua, numero, bairro from cliente where cpf = @cpf";
            
            if (connection.State != System.Data.ConnectionState.Open)
                connection.Open();

            MySqlCommand command = new MySqlCommand(query, connection);

            command.Parameters.Add("@cpf", MySqlDbType.String);

            command.Parameters["@cpf"].Value = cpf;

            MySqlDataReader dataReader = command.ExecuteReader();

            Cliente cliente = new Cliente();

            if(dataReader.Read())
            {
                cliente.Cpf = dataReader.GetString("cpf");
                cliente.Nome = dataReader.GetString("nome");
                cliente.Telefone = dataReader.GetString("telefone");
                cliente.Cep = dataReader.GetString("cep");
                cliente.Rua = dataReader.GetString("rua");
                cliente.Numero = dataReader.GetInt32("numero");
                cliente.Bairro = dataReader.GetString("bairro");
            }

            connection.Close();

            return cliente;
        }

        public void update(Cliente cliente, string cpfAntigo)
        {
            MySqlConnection connection = ConnectionFactory.GetInstance().GetConnection();

            string query = "update cliente set cpf = @cpf, nome = @nome, telefone = @telefone, cep = @cep, rua = @rua, numero = @numero, bairro = @bairro where cpf = @cpfAntigo";

            if (connection.State != System.Data.ConnectionState.Open)
                connection.Open();

            MySqlCommand command = new MySqlCommand(query, connection);

            command.Parameters.Add("@cpfAntigo", MySqlDbType.String);
            command.Parameters.Add("@cpf", MySqlDbType.String);
            command.Parameters.Add("@nome", MySqlDbType.String);
            command.Parameters.Add("@telefone", MySqlDbType.String);
            command.Parameters.Add("@cep", MySqlDbType.String);
            command.Parameters.Add("@rua", MySqlDbType.String);
            command.Parameters.Add("@numero", MySqlDbType.UInt16);
            command.Parameters.Add("@bairro", MySqlDbType.String);

            command.Parameters["@cpfAntigo"].Value = cpfAntigo;
            command.Parameters["@cpf"].Value = cliente.Cpf;
            command.Parameters["@nome"].Value = cliente.Nome;
            command.Parameters["@telefone"].Value = cliente.Telefone;
            command.Parameters["@cep"].Value = cliente.Cep;
            command.Parameters["@rua"].Value = cliente.Rua;
            command.Parameters["@numero"].Value = cliente.Numero;
            command.Parameters["@bairro"].Value = cliente.Bairro;

            command.ExecuteNonQuery();
            connection.Close();
        }

        public void delete(Cliente cliente)
        {
            MySqlConnection connection = ConnectionFactory.GetInstance().GetConnection();

            string query = "delete from cliente where cpf = @cpf";

            if (connection.State != System.Data.ConnectionState.Open)
                connection.Open();

            MySqlCommand command = new MySqlCommand(query, connection);

            command.Parameters.Add("@cpf", MySqlDbType.String);

            command.Parameters["@cpf"].Value = cliente.Cpf;

            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}

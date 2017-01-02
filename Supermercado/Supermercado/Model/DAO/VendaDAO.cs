using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Supermercado.Model.DAO
{
    class VendaDAO
    {
        public void create(Venda venda)
        {
            MySqlConnection connection = ConnectionFactory.GetInstance().GetConnection();

            string query = "insert into venda(dataHora, valorTotal, nomeFuncionario, cpfCliente) values(@dataHora, @valorTotal, @nomeFuncionario, @cpfCliente)";

            if (connection.State != System.Data.ConnectionState.Open)
                connection.Open();

            MySqlCommand command = new MySqlCommand(query, connection);
            
            command.Parameters.Add("@dataHora", MySqlDbType.DateTime);
            command.Parameters.Add("@valorTotal", MySqlDbType.Decimal);
            command.Parameters.Add("@nomeFuncionario", MySqlDbType.String);
            command.Parameters.Add("@cpfCliente", MySqlDbType.String);
            
            command.Parameters["@dataHora"].Value = venda.DataHora;
            command.Parameters["@valorTotal"].Value = venda.ValorTotal;
            command.Parameters["@nomeFuncionario"].Value = venda.NomeFuncionario;
            command.Parameters["@cpfCliente"].Value = venda.Cliente.Cpf;

            command.ExecuteNonQuery();
            connection.Close();
        }
        
        public List<Venda> read(string nomeClienteOuNumero)
        {
            MySqlConnection connection = ConnectionFactory.GetInstance().GetConnection();

            /*
            caso a string nomeClienteOuNumero:
            
            - seja vazia (""), a pesquisa retornará todos os registros.
            - contenha apenas numeros, a pesquisa retornará as buscas por numero.
            - contenha algum outro caractere, a pesquisa retornará as buscas por nome do cliente.
            */
            
            string query;
            string parameter;

            try
            {
                int.Parse(nomeClienteOuNumero); //caso a conversão para int não lance exception, a string representará uma busca por numero...
                query = "select v.numero, v.dataHora, v.valorTotal, v.nomeFuncionario, v.cpfCliente, c.nome from venda v, cliente c where v.numero like @nomeClienteOuNumero and c.cpf = v.cpfcliente order by c.nome asc";//adicionar order by
                parameter = nomeClienteOuNumero;
            }
            catch (Exception)
            {
                //caso a conversão falhe, a string representará uma busca por nome de cliente.
                query = "select v.numero, v.dataHora, v.valorTotal, v.nomeFuncionario, v.cpfCliente, c.nome from venda v, cliente c where c.nome in (select nome from cliente where nome like @nomeClienteOuNumero order by nome asc) and v.cpfCliente = c.cpf";
                parameter = "%" + nomeClienteOuNumero + "%";
            }

            if (connection.State != System.Data.ConnectionState.Open)
                connection.Open();
            

            MySqlCommand command = new MySqlCommand(query, connection);

            command.Parameters.Add("@nomeClienteOuNumero", MySqlDbType.String);

            command.Parameters["@nomeClienteOuNumero"].Value = parameter;

            MySqlDataReader dataReader = command.ExecuteReader();

            List<Venda> vendas = new List<Venda>();
            List<string> cpfs = new List<string>();
            List<int> numerosVenda = new List<int>();

            while (dataReader.Read())
            {
                Venda venda = new Venda();

                venda.Numero = dataReader.GetInt32("numero");
                venda.DataHora = dataReader.GetDateTime("dataHora");
                venda.ValorTotal = dataReader.GetFloat("valorTotal");
                venda.NomeFuncionario = dataReader.GetString("nomeFuncionario");
                //venda.Cliente = new ClienteDAO().readOneByCpf(dataReader.GetString("cpfCliente"));
                //venda.Produtos = new ProdutoVendaDAO().readByNumeroVenda(dataReader.GetInt32("numero"));
                cpfs.Add(dataReader.GetString("cpfCliente"));
                numerosVenda.Add(dataReader.GetInt32("numero"));

                vendas.Add(venda);
            }

            connection.Close();

            for(int i=0;i<vendas.Count;i++)
            {
                vendas[i].Cliente = new ClienteDAO().readOneByCpf(cpfs[i]);
                vendas[i].Produtos = new ProdutoVendaDAO().readByNumeroVenda(numerosVenda[i]);
            }
            
            return vendas;
        }

        public void update(Venda venda)
        {
            MySqlConnection connection = ConnectionFactory.GetInstance().GetConnection();

            string query = "update venda set dataHora = @dataHora, valorTotal = @valorTotal, nomeFuncionario = @nomefuncionario, cpfCliente = @cpfCliente where numero = @numero";

            if (connection.State != System.Data.ConnectionState.Open)
                connection.Open();

            MySqlCommand command = new MySqlCommand(query, connection);
            
            command.Parameters.Add("@dataHora", MySqlDbType.DateTime);
            command.Parameters.Add("@valorTotal", MySqlDbType.Float);
            command.Parameters.Add("@nomeFuncionario", MySqlDbType.String);
            command.Parameters.Add("@cpfCliente", MySqlDbType.String);
            
            command.Parameters["@dataHora"].Value = venda.DataHora;
            command.Parameters["@valorTotal"].Value = venda.ValorTotal;
            command.Parameters["@nomeFuncionario"].Value = venda.NomeFuncionario;
            command.Parameters["@cpfCliente"].Value = venda.Cliente.Cpf;

            command.ExecuteNonQuery();
            connection.Close();
        }

        public void delete(Venda venda)
        {
            MySqlConnection connection = ConnectionFactory.GetInstance().GetConnection();

            string query = "delete from venda where numero = @numero";

            if (connection.State != System.Data.ConnectionState.Open)
                connection.Open();

            MySqlCommand command = new MySqlCommand(query, connection);

            command.Parameters.Add("@numero", MySqlDbType.Int32);

            command.Parameters["@numero"].Value = venda.Numero;

            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Supermercado.Model.DAO
{
    class ConnectionFactory
    {
        private static MySqlConnection connection;
        private static ConnectionFactory instance;
        private const string URL = "Server=127.0.0.1;Database=supermercado;Uid=root;Pwd=root;";

        private ConnectionFactory()
        {
            //instancia conexão ao SGBD
            connection = new MySqlConnection(URL);
        }

        public static ConnectionFactory GetInstance()
        {
            //instancia uma nova conexao apenas se ela não estiver instanciada. caso esteja, apenas retorna a instancia
            if (instance == null)
                instance = new ConnectionFactory();

            return instance;
        }
        public MySqlConnection GetConnection()
        {
            return connection;
        }
    }
}

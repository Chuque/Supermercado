using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermercado.Model
{
    class Cliente
    {
        private string cpf;
        private string nome;
        private string telefone;
        private string cep;
        private string rua;
        private int numero;
        private string bairro;

        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }
        public string Cep
        {
            get { return cep; }
            set { cep = value; }
        }
        public string Rua
        {
            get { return rua; }
            set { rua = value; }
        }
        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        public string Bairro
        {
            get { return bairro; }
            set { bairro = value; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_MaterialContrucao.Models
{
    class ClienteModel
    {
        private Int32 id;
        private string nome;
        private string telefone;
        private string cpf;
        private string dataCadastro;
        private string cep;
        private string cidade;
        private string bairro;
        private string rua;
        private Int32 numero;
        private string email;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string DataCadastro { get => dataCadastro; set => dataCadastro = value; }
        public string Cep { get => cep; set => cep = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public string Bairro { get => bairro; set => bairro = value; }
        public string Rua { get => rua; set => rua = value; }
        public int Numero { get => numero; set => numero = value; }
        public string Email { get => email; set => email = value; }
    }
}

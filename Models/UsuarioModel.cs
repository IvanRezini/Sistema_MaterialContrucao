using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_MaterialContrucao.Models
{
    class UsuarioModel
    {
        private Int32 id;
        private string nome;
        private string telefone;
        private string nomeUsuario;
        private string senha;
        private string email;
        private Int32 tipo;//tipo "1" usuario comum; tipo "2" gerente; tipo "3" Administrador

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string NomeUsuario { get => nomeUsuario; set => nomeUsuario = value; }
        public string Senha { get => senha; set => senha = value; }
        public string Email { get => email; set => email = value; }
        public int Tipo { get => tipo; set => tipo = value; }
    }
}

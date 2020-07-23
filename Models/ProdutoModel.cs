using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_MaterialContrucao.Models
{
    class ProdutoModel
    {
        private int id;
        private string nome;
        private string descricao;
        private float valor;
        private float quantidadeEstoque;
        private string unidade; //quantidade Kg L U
        private string fornecedor;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public float Valor { get => valor; set => valor = value; }
        public float QuantidadeEstoque { get => quantidadeEstoque; set => quantidadeEstoque = value; }
        public string Unidade { get => unidade; set => unidade = value; }
        public string Fornecedor { get => fornecedor; set => fornecedor = value; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_MaterialContrucao.Models
{
    class ItensPedidoModel
    {
        private Int32 codPedido;
        private Int32 codProduto; 
        private Int32 quantia; 
        private Int32 valor;

        public int CodPedido { get => codPedido; set => codPedido = value; }
        public int CodProduto { get => codProduto; set => codProduto = value; }
        public int Quantia { get => quantia; set => quantia = value; }
        public int Valor { get => valor; set => valor = value; }
    }
}

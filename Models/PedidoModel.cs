using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_MaterialContrucao.Models
{
    class PedidoModel
    {
        private Int32 id; 
        private Int32 codCliente; 
        private DateTime dataPedido;
        private Int32 desconto;

        public int Id { get => id; set => id = value; }
        public int CodCliente { get => codCliente; set => codCliente = value; }
        public DateTime DataPedido { get => dataPedido; set => dataPedido = value; }
        public int Desconto { get => desconto; set => desconto = value; }
    }
}

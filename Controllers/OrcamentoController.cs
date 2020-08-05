using Sistema_MaterialContrucao.Dao;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_MaterialContrucao.Controllers
{
    class OrcamentoController
    {
        public static DataTable preencherDataGridView()
        {
            DataTable dt = new DataTable();
            DataTable prod = new DataTable();
            dt = ProdutoDao.ListaProduto();


            string[] pro = { "Codigo", "Produto", "Descrição", "Valor", "Estoque", "Fornecedor" };
            //adiciona as colunas
            for (int i = 0; i < pro.Length; i++)
            {
                prod.Columns.Add(pro[i]);
            }

            //adiciona as linhas a tabela
            foreach (DataRow linha in dt.Rows)
            {
                pro[0] = linha["id"].ToString();//codigo
                pro[1] = linha["nome"].ToString();//Produto
                pro[2] = linha["descricao"].ToString();//Descrição
                pro[3] = Math.Round(((decimal.Parse(linha["valor"].ToString()) / 100) + (((decimal.Parse(linha["valor"].ToString()) / 100) / 100) * (decimal.Parse(linha["margemLucro"].ToString())))), 2).ToString("F");//Valor de venda
                pro[4] = linha["quantidadeEStoque"].ToString() + " " + linha["unidade"].ToString();//Estoque
                pro[5] = linha["fornecedor"].ToString();//Fornecedor

                prod.Rows.Add(pro);
            }
            return prod;
        }

        public static List<string> preencherComboBox()
        {
            List<string> cliente = new List<string>();
            DataTable dt = new DataTable();
            dt = ClienteDao.ListaClientes();

            foreach (DataRow linha in dt.Rows)
            {
                cliente.Add(linha["id"].ToString() + " - " + linha["nome"].ToString());
            }
                return cliente;
        }


    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_MaterialContrucao.Models;
using Sistema_MaterialContrucao.Dao;
using System.Data;
using System.Collections;

namespace Sistema_MaterialContrucao.Controllers
{
    class ProdutoController
    {
        public static DataTable preencherDataGridView()
        {
            DataTable dt = new DataTable();
            DataTable prod = new DataTable();
            dt = ProdutoDao.ListaProduto();

            
            string[] pro = { "Codigo", "Produto","Descrição","Valor","Margem de luccro", "Valor de venda", "Estoque","Un","Fornecedor" };
            //adiciona as colunas
            for (int i = 0; i < pro.Length; i++)
            {
                prod.Columns.Add(pro[i]);
            }

         //adiciona as linhas a tabela
            foreach (DataRow linha in dt.Rows)
            {
                pro[0] =linha["id"].ToString();//codigo
                pro[1] = linha["nome"].ToString();//Produto
                pro[2] = linha["descricao"].ToString();//Descrição
                pro[3] = (decimal.Parse(linha["valor"].ToString())/100).ToString();//Valor
                pro[4] = linha["margemLucro"].ToString()+" %";//Margem de luccro
                pro[5] = ((decimal.Parse(linha["valor"].ToString()) / 100) + (((decimal.Parse(linha["valor"].ToString()) / 100)/100 )* (decimal.Parse(linha["margemLucro"].ToString())))).ToString();//Valor de venda
                pro[6] = linha["quantidadeEStoque"].ToString();//Estoque
                pro[7] = linha["unidade"].ToString();//Un
                pro[8] = linha["fornecedor"].ToString();//Fornecedor

                prod.Rows.Add(pro);
            }


            return prod;
        }
        public static string salvar(ProdutoModel pro)
        {
            string resposata = "";
            if (pro.Nome.Trim() != "")
            {
                pro.Nome = char.ToUpper(pro.Nome[0]) + pro.Nome.Substring(1);
                if (pro.Descricao.Trim() != "")
                {
                    if (pro.Fornecedor.Trim() != "")
                    {
                        ProdutoDao.insert(pro);
                    }
                    else
                    {
                        resposata = "Adicione um fornecedor";
                    }
                }
                else
                {
                    resposata = "Descreva o produto para facilitar sua indentificação";
                }
            }
            else
            {
                resposata = "O campo nome não pode estar em branco";
            }

            return resposata;
        }

        public static string alterarEstoque(string id, string quantiaEmEstoque, string valor, string novaQuantia, string lucro)
        {
            int quantia = 0;
            string[] tirarUnidade = quantiaEmEstoque.Split(' ');
            quantiaEmEstoque = tirarUnidade[0];
            double val = Int64.Parse(valor)*100; 
            if (novaQuantia.Trim() != "0")
            {
                Console.WriteLine("\ngh" + quantiaEmEstoque +"gk\n"+ novaQuantia+"\n" );
              quantia = Int32.Parse(quantiaEmEstoque) + Int32.Parse(novaQuantia);
            }
            ProdutoDao.alterarProduto(id, 5, quantia, lucro);


            return "";
        }

    }
}

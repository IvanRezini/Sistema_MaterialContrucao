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


            string[] pro = { "Codigo", "Produto", "Descrição", "Valor", "Margem de lucro", "Valor de venda", "Estoque", "Un", "Fornecedor" };
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
                pro[3] = Math.Round((decimal.Parse(linha["valor"].ToString()) / 100), 2).ToString("F");//Valor
                pro[4] = linha["margemLucro"].ToString() + " %";//Margem de luccro
                pro[5] = Math.Round(((decimal.Parse(linha["valor"].ToString()) / 100) + (((decimal.Parse(linha["valor"].ToString()) / 100) / 100) * (decimal.Parse(linha["margemLucro"].ToString())))), 2).ToString("F");//Valor de venda
                pro[6] = linha["quantidadeEStoque"].ToString();//Estoque
                pro[7] = linha["unidade"].ToString();//Un
                pro[8] = linha["fornecedor"].ToString();//Fornecedor

                prod.Rows.Add(pro);
            }
            return prod;
        }
        public static string salvar(ProdutoModel pro)
        {
            string resposta = "";
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
                        resposta = "Adicione um fornecedor";
                    }
                }
                else
                {
                    resposta = "Descreva o produto para facilitar sua indentificação";
                }
            }
            else
            {
                resposta = "O campo nome não pode estar em branco";
            }

            return resposta;
        }

        public static bool alterarEstoque(string id, string quantiaEmEstoque, string valor, string novaQuantia, string lucro)
        {
            string[] tirarUnidade = quantiaEmEstoque.Split(' ');
            quantiaEmEstoque = tirarUnidade[0];
            int quantia = Int32.Parse(quantiaEmEstoque.Trim());
            decimal val = decimal.Parse(valor.Trim()) * 100;
            val = Math.Round(val, 0);//tira as casas decimais
            if (novaQuantia.Trim() != "0")
            {
                quantia = Int32.Parse(quantiaEmEstoque) + Int32.Parse(novaQuantia);
            }
            bool resposta = ProdutoDao.entradaDeValorEQuantia(id, val, quantia, lucro);


            return resposta;
        }

        public static string editar(string id, string nome, string desc, string quantia, string quantiaBaixa, string motivoBaixa)
        {
            string resposta = "";
            if (nome.Trim() != "")
            {
                nome = char.ToUpper(nome[0]) + nome.Substring(1);
                if (desc.Trim() != "")
                {

                    if (quantiaBaixa.Trim() == "")
                    {
                        quantiaBaixa = "0";
                    }
                    string[] aux = quantia.Split(' ');//tirar a unidade de medida
                    int quant = Int32.Parse(aux[0]);
                    int baixa = Int32.Parse(quantiaBaixa);
                    if (quant > baixa)
                    {
                        int total = quant - baixa;
                        if (motivoBaixa.Trim() != "")
                        {
                            ProdutoDao.editarEBaixa(id, nome, desc, total.ToString());
                            resposta = "";
                        }
                        else
                        {
                            resposta = "Descreva o motivo desta baixa";
                        }
                    }
                    else
                    {
                        resposta = "Quantia a dar baixa maior do que a do estoque.";
                    }
                }
                else
                {
                    resposta = "Descreva o produto para facilitar sua indentificação";
                }
            }
            else
            {
                resposta = "O campo nome não pode estar em branco";
            }
            return resposta;
        }
        public static string excluir(string id, string quantia, string quantiaBaixa, string motivoBaixa)
        {
            string resposta = "";
            if (quantiaBaixa.Trim() == "")
            {
                quantiaBaixa = "0";
            }
            string[] aux = quantia.Split(' ');//tirar a unidade de medida
            int quant = Int32.Parse(aux[0]);
            int baixa = Int32.Parse(quantiaBaixa);
            if (quant <= baixa)
            {
                if (motivoBaixa.Trim() != "")
                {
                    ProdutoDao.excluir(id);
                }
                else
                {
                    resposta = "Espesifique o motivo da baixa, e da exclusão";
                }
            }
            else
            {
                resposta = "Há uma quantia de produto em estoue.\nNão e possivel eexcluir o produto.\nPara continuar adicione o mesmo valor a quantia\ne uma descrição do motivo da baixa";
            }

            return resposta;
        }
    }
}

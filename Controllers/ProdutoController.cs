using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_MaterialContrucao.Models;
using Sistema_MaterialContrucao.Dao;

namespace Sistema_MaterialContrucao.Controllers
{
    class ProdutoController
    {
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



    }
}

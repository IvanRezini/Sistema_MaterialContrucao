using Sistema_MaterialContrucao.Models;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_MaterialContrucao.Dao
{
    class ProdutoDao : Conexao
    {
        public static void insert(ProdutoModel produto)//Data Manipulation Language (insert, Delete, update)
        {
            SQLiteDataAdapter da = null;
            try
            {
                var vcon = conexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = string.Format(@"INSERT INTO tbProduto (nome, descricao, valor, quantidadeEStoque, unidade, fornecedor,status
                      )VALUES('{0}', '{1}', {2}, {3}, '{4}', '{5}',{6})",
                      produto.Nome, produto.Descricao, 0, 0, produto.Unidade, produto.Fornecedor, 0);

                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                cmd.ExecuteNonQueryAsync();
                vcon.Close();
                MessageBox.Show("Cadastro efetuado co socesso" + "\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no cadastro" + "\n" + ex.Message);
                throw ex;
            }
        }

    }
}

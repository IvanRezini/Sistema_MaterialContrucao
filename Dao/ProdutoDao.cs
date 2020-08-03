using Sistema_MaterialContrucao.Models;
using System;
using System.Collections.Generic;
using System.Data;
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
                cmd.CommandText = string.Format(@"INSERT INTO tbProduto (nome, descricao, valor, quantidadeEStoque, unidade, fornecedor, status, margemLucro
                      )VALUES('{0}', '{1}', {2}, {3}, '{4}', '{5}',{6}, {7})",
                      produto.Nome, produto.Descricao, 0, 0, produto.Unidade, produto.Fornecedor, 0, produto.MargemLucro);

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

        public static DataTable ListaProduto()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = conexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = @"SELECT * FROM tbProduto ORDER BY nome";
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();
                return dt;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw ex;
            }

        }
        public static bool entradaDeValorEQuantia(string id, decimal valor, int quantia, string lucro)
        {
            SQLiteDataAdapter da = null;
            try
            {
                var vcon = conexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = string.Format(@"UPDATE tbProduto SET valor = '{0}', margemLucro = '{1}', quantidadeEStoque = '{2}'
                        WHERE id = '{3}'", valor, lucro, quantia, id);
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                cmd.ExecuteNonQueryAsync();
                vcon.Close();
                MessageBox.Show("Cadastro atualiçado com suscesso");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha na atualização" + "\n" + ex.Message);
                return false;
                throw ex;
            }
        }
        public static void editarEBaixa(string id, string nome, string desc, string quantiaEstoque)
        {
            SQLiteDataAdapter da = null;
            try
            {
                var vcon = conexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = string.Format(@"UPDATE tbProduto SET nome = '{0}', descricao = '{1}', quantidadeEStoque = '{2}'
                        WHERE id = '{3}'", nome, desc, quantiaEstoque, id);
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                cmd.ExecuteNonQueryAsync();
                vcon.Close();
                MessageBox.Show("Cadastro atualiçado com suscesso");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha na atualização" + "\n" + ex.Message);
               throw ex;
            }
        }

        public static void excluir(string id)
        {
            SQLiteDataAdapter da = null;
            try
            {
                var vcon = conexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = string.Format(@"DELETE FROM tbProduto WHERE id = '{0}'", id);
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                cmd.ExecuteNonQueryAsync();
                vcon.Close();
                MessageBox.Show("Exclusão efetuada com suscesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha na exclusão" + "\n" + ex.Message);
                throw ex;
            }
        }

    }

}

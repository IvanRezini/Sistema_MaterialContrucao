using Sistema_MaterialContrucao.Controllers;
using Sistema_MaterialContrucao.Views;
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
    class PedidoDao : Conexao
    {
        public static string insertNovoPedido()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            string data = Utilidades.dataParaBanco();

            try
            {
                //Insere u novo pedido no banco
                var vcon = conexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = string.Format(@"INSERT INTO tbPedido (data)
                     VALUES ('{0}')", data);
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                cmd.ExecuteNonQueryAsync();

                //Recupera o id dopedido inserido
                da = null;
                cmd.CommandText = string.Format(@"SELECT id FROM tbPedido WHERE data = '{0}'", data);
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();//veja a conexão
                return dt.Rows[0]["id"].ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void salvarPedido(string pedido, List<string[]> itenPedido)
        {
            SQLiteDataAdapter da = null;
            try
            {
                var vcon = conexaoBanco();
                var cmd = vcon.CreateCommand();
                foreach (string[] item in itenPedido)
                {
                    string valor =( decimal.Parse(item[3]) * 100).ToString();
                    cmd.CommandText = string.Format(@"INSERT INTO tbItensPedido (idPedido, idProduto, quantia, valor)
                          VALUES ('{0}', '{1}', '{2}', '{3}')",
                          pedido, item[0], item[2], valor);
                    da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                    cmd.ExecuteNonQueryAsync();
                }
                vcon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no cadastro" + "\n" + ex.Message);
                throw ex;
            }
        }
        public static void atualisarPedidoCriado(string pedido, string idCliente, string desconto)
        {
            SQLiteDataAdapter da = null;
            try
            {
                var vcon = conexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = string.Format(@"UPDATE tbPedido SET idCliente = '{0}',desconto = '{1}'
                        WHERE id = '{2}'", idCliente, desconto, pedido);
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                cmd.ExecuteNonQueryAsync();
                vcon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha na atualização" + "\n" + ex.Message);
                throw ex;
            }
        }
        public static DataTable ListaPedidos()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = conexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = @"SELECT tbPedido.id, tbCliente.nome, tbPedido.data
                                      FROM tbPedido INNER JOIN tbCliente
                                      ON tbPedido.idCliente = tbCliente.id
                                      ORDER BY data DESC";
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();
                return dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha na obteñção dos pedidos");
                throw ex;
            }

        }
        public static void excuir(int cod)
        {
            SQLiteDataAdapter da = null;
            try
            {
                var vcon = conexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = string.Format(@"DELETE FROM tbPedido WHERE id = {0}", cod);
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                cmd.ExecuteNonQueryAsync();
                vcon.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static DataTable ListaItensPedido(int cod)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = conexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = string.Format(@"SELECT tbItensPedido.idProduto, tbProduto.nome, tbItensPedido.quantia,tbItensPedido.valor, tbPedido.desconto
                                      FROM tbItensPedido INNER JOIN tbProduto
                                      ON tbItensPedido.idProduto = tbProduto.id
                                      INNER JOIN tbPedido ON tbItensPedido.idPedido = tbPedido.id
                                      WHERE  tbItensPedido.idPedido = {0}",cod);
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();
                return dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha na obteñção dos pedidos");
                throw ex;
            }

        }
    }
}

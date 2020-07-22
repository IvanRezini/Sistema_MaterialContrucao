using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;
using Sistema_MaterialContrucao.Models;

namespace Sistema_MaterialContrucao.Dao 
{
    class ClienteDao : Conexao
    {

        public static void insert(ClienteModel cliente, string msgOk = null, string msgErro = null)//Data Manipulation Language (insert, Delete, update)
        {
            SQLiteDataAdapter da = null;
            try
            {
                var vcon = conexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = string.Format(@"INSERT INTO tbCliente(nome, cpf, dataCadastro, cep, cidade, bairro, rua, numero, email)
                      VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', {7}, '{8}')",
                      cliente.Nome, cliente.Cpf, cliente.DataCadastro, cliente.Cep, cliente.Cidade, cliente.Bairro, cliente.Rua, cliente.Numero, cliente.Email);

                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                cmd.ExecuteNonQueryAsync();
                vcon.Close();
                if (msgOk != null)
                {
                    MessageBox.Show(msgOk);
                }

            }
            catch (Exception ex)
            {
                if (msgErro != null)
                {
                    MessageBox.Show(msgErro + "\n" + ex.Message);
                }
                throw ex;
            }
        }
    }
}

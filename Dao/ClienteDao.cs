using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;
using Sistema_MaterialContrucao.Models;
using System.Data;

namespace Sistema_MaterialContrucao.Dao
{
    class ClienteDao : Conexao
    {
        public static DataTable ListaClientes()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = conexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = @"SELECT * FROM tbCliente ORDER BY nome";
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

        public static void insert(ClienteModel cliente)//Data Manipulation Language (insert, Delete, update)
        {
            Console.WriteLine(cliente.Nome + "\n" + cliente.Cpf + "\n" + cliente.Telefone + "\n" + cliente.DataCadastro + "\n" +
                cliente.Cep + "\n" + cliente.Cidade + "\n" + cliente.Bairro + "\n" + cliente.Rua + "\n" +
                cliente.Numero + "\n" + cliente.Email);
            SQLiteDataAdapter da = null;
            try
            {
                var vcon = conexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = string.Format(@"INSERT INTO tbCliente(nome, cpf, telefone, dataCadastro, cep, cidade, bairro, rua, numero, email)
                      VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', {8}, '{9}')",
                      cliente.Nome, cliente.Cpf, cliente.Telefone, cliente.DataCadastro, cliente.Cep, cliente.Cidade, cliente.Bairro, cliente.Rua, cliente.Numero, cliente.Email);

                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                cmd.ExecuteNonQueryAsync();
                vcon.Close();
                MessageBox.Show("Cadastro efetuado co socesso" + "\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no cadastro"+ "\n" + ex.Message);
                throw ex;
            }
        }
    }
}

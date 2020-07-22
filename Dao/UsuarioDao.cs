using Sistema_MaterialContrucao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Data;
using System.Security.Cryptography;

namespace Sistema_MaterialContrucao.Dao
{
    class UsuarioDao : Conexao
    {

        public static void insert(UsuarioModel uso)
        {
            SQLiteDataAdapter da = null;
            try
            {
                var vcon = conexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = string.Format(@"INSERT INTO tbUsuario (nome, telefoneUsuario, nomeDeUsuario, senhaUsuario, tipoUsuario, email)
                      VALUES('{0}', '{1}', '{2}', {3}, {4}, '{5}')",
                      uso.Nome, uso.Telefone, uso.NomeUsuario, uso.Senha, uso.Tipo, uso.Email);
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                cmd.ExecuteNonQueryAsync();
                vcon.Close();
               MessageBox.Show("Cadastro efetuado com suscesso");
               }
            catch (Exception ex)
            {
                MessageBox.Show("Falha no cadastro" + "\n" + ex.Message);
                throw ex;
            }
        }

        public static void update(UsuarioModel uso)
        {
            SQLiteDataAdapter da = null;
            try
            {
                var vcon = conexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = string.Format(@"UPDATE tbUsuario SET  nome = '{0}', telefoneUsuario = '{1}', nomeDeUsuario = '{2}', senhaUsuario = '{3}', tipoUsuario = {4}, email = '{5}'
                        WHERE id = {6}",uso.Nome, uso.Telefone, uso.NomeUsuario, uso.Senha, uso.Tipo, uso.Email, uso.Id);
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
                cmd.CommandText = string.Format(@"DELETE FROM tbUsuario WHERE id = {0}",id);
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

        public static UsuarioModel login(string usuario, string senha)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            UsuarioModel uso = new UsuarioModel();
            
            try
            {
                var vcon = conexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = string.Format(@"SELECT * FROM tbUsuario WHERE nomeDeUsuario = '{0}' AND senhaUsuario = '{1}'", usuario, senha);

                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();
                if (dt.Rows.Count > 0)
                {
                    string id = dt.Rows[0].Field<Int64>("id").ToString();
                    uso.Id = Int32.Parse(id);
                    uso.Nome = dt.Rows[0].Field<string>("nome").ToString();
                    uso.Telefone = dt.Rows[0].Field<string>("telefoneUsuario").ToString();
                    uso.NomeUsuario = dt.Rows[0].Field<string>("nomeDeUsuario").ToString();
                    uso.Senha = dt.Rows[0].Field<string>("senhaUsuario").ToString();
                    uso.Tipo = dt.Rows[0].Field<Int32>("tipoUsuario");
                    uso.Email = dt.Rows[0].Field<string>("email").ToString();
                }
                return uso;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static DataTable ListaUsuario()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = conexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = @"SELECT * FROM tbUsuario ORDER BY nome";
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
    }
}


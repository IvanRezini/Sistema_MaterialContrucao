using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using Sistema_MaterialContrucao.Controllers;


namespace Sistema_MaterialContrucao.Dao
{
    class Conexao
    {
        private static SQLiteConnection conexao;

        public static SQLiteConnection conexaoBanco()
        {
            conexao = new SQLiteConnection("Data Source=" + Utilidades.caminhoBanco + Utilidades.nomeBanco);
            conexao.Open();
            return conexao;
        }
    }
}

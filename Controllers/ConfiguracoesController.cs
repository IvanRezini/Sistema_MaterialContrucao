using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_MaterialContrucao.Controllers
{
    class ConfiguracoesController
    {


        public static string caminho = System.Environment.CurrentDirectory;//lista o caminho do executavel

        public static string nomeBanco = "banco.db";

        public static string caminhoBanco = caminho + @"\banco\";

        public static string[] unidadeDeMedida = { "Kg", "LT", "M", "Un", "Cx" };//usada para popular o comboBox de unidade de produtos

        public static string email = "ivan_rezini@hotmail.com"; //email usado para o enviu

        public static string senha = "#######";//senha do email

        public static string caminhoSalvarArquivos = caminho;
        public static string caminhoImagens = caminho;
        public static string NomeLoja = "\"Nome da loja  ## ##\"";
        public static string Cnpj = "4454452";
        public static string endereço = "Rua das cabras numero 888\nBrusque SC";
        public static string telefone = "(47)9 9999 7474";
    }
}

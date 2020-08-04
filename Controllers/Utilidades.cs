using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Text.RegularExpressions;
using Correios;

namespace Sistema_MaterialContrucao.Controllers
{
    class Utilidades
    {
        public static string caminho = System.Environment.CurrentDirectory;//lista o caminho do executavel

        public static string nomeBanco = "banco.db";

        public static string caminhoBanco = caminho + @"\banco\";

        public static string obterData = DateTime.Now.ToString("dd-MM-yyyy  HH:mm");//obeter data atual

        public static string[] unidadeDeMedida = { "Kg", "LT", "M", "Un", "Cx" };//usada para popular o comboBox de unidade de produtos

        public static string email = "ivan_rezini@hotmail.com"; //email usado para o enviu

        public static string senha = "#######";//senha do email
        ///Validar email
        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                // Normalize the domain
                email = Regex.Replace(email, @"(@)(.+)$", DomainMapper,
                                      RegexOptions.None, TimeSpan.FromMilliseconds(200));

                // Examines the domain part of the email and normalizes it.
                string DomainMapper(Match match)
                {
                    // Use IdnMapping class to convert Unicode domain names.
                    var idn = new IdnMapping();

                    // Pull out and process domain name (throws ArgumentException on invalid)
                    var domainName = idn.GetAscii(match.Groups[2].Value);

                    return match.Groups[1].Value + domainName;
                }
            }
            catch (RegexMatchTimeoutException e)
            {
                return false;
            }
            catch (ArgumentException e)
            {
                return false;
            }

            try
            {
                return Regex.IsMatch(email,
                    @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                    @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }

        /// vaidar cpf
        public static bool IsValidCpf(string cpf)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito = "";
            int soma;
            int resto;
            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "");
            if (cpf.Length != 11)
            {
                return false;
            }

            tempCpf = cpf.Substring(0, 9);
            soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
            resto = soma % 11;
            if (resto < 2)
            {
                resto = 0;
            }

            else
            {
                resto = 11 - resto;
                digito = resto.ToString();
                tempCpf = tempCpf + digito;
                soma = 0;
                for (int i = 0; i < 10; i++)
                    soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
                resto = soma % 11;
            }
            if (resto < 2)
            {
                resto = 0;
            }
            else
            {
                resto = 11 - resto;
                digito = digito + resto.ToString();
            }
            return cpf.EndsWith(digito);
        }

        ///Obeter indereço api correios
        public static string[] endereco(string cep)
        {
            cep = cep.Replace("-", "").Replace(" ", "");
            var service = new CorreiosApi();
            string[] end = new string[3];
            try
            {
                var dados = service.consultaCEP(cep);
                var bairro = dados.bairro;
                var cidade = dados.cidade;
                var rua = dados.complemento;
                end[0] = cidade;
                end[1] = bairro;
                end[2] = rua;
            }
            catch (Exception e)
            {
            }
            return end;
        }

    }
}

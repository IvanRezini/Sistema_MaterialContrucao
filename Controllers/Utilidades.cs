using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Text.RegularExpressions;
using Correios;
using System.Windows.Forms;
using System.Drawing;

namespace Sistema_MaterialContrucao.Controllers
{
    class Utilidades
    {
        public static string data(string mascara)
        {
            string data = DateTime.Now.ToString(mascara);//obeter data atual

            return data;
        }


        public static string obterData() {
            return data("dd-MM-yyyy HH:mm");//obeter data atual para as telas    
        }

        public static string dataParaBanco()//obeter data atual
        {
            return data("yyyy-MM-dd HH:mm:ss.ffff");
        }

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
                Console.WriteLine(e);
                return false;
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e);
                return false;
            }

            try
            {
                return Regex.IsMatch(email,
                    @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                    @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException e)
            {
                Console.WriteLine(e);
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
            string[] end = new string[4];
            try
            {
                var dados = service.consultaCEP(cep);
                var bairro = dados.bairro;
                var cidade = dados.cidade;
                var rua = dados.end;//rua
                var uf = dados.uf;
              
                end[0] = cidade;
                end[1] = bairro;
                end[2] = rua;
                end[3] = uf;
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(i + i * 4+"    "+i);
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return end;
        }


        /// //Formatação do dataGridView para todos terem o mesmo padrão
        public static DataGridView Grade(DataGridView dg)
        {
            dg.EditMode = DataGridViewEditMode.EditProgrammatically;
            dg.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dg.AllowUserToAddRows = false;
            dg.AllowUserToDeleteRows = false;
            dg.DefaultCellStyle.Font = new Font("Calibri", 9);
            dg.EnableHeadersVisualStyles = false; // Desabilita formatação padrão
            dg.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);
            dg.ColumnHeadersDefaultCellStyle.BackColor = Color.Blue;
            dg.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dg.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dg.RowsDefaultCellStyle.BackColor = Color.LightCyan;
            dg.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue;
            dg.MultiSelect = false;
            return dg;
        }

    }
}

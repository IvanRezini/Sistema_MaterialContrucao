using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_MaterialContrucao.Controllers
{
    class EnvioEmail
    {
        public static void envio(string endereco, PdfPTable orcamento)
        {


            // Cria uma instancia com o servidor de email.
            SmtpClient cliente = new SmtpClient("smtp.live.com", 25);

            cliente.EnableSsl = true;
            cliente.ServicePoint.MaxIdleTime = 1;

            // Cria uma instancia de propiedades como endereco do destinatario e remetente e mensagem
            MailAddress remetente = new MailAddress(ConfiguracoesController.email, "Orçamento Online");
            MailAddress destinatario = new MailAddress(endereco);
            MailMessage mensagem = new MailMessage(remetente, destinatario);

            // Criar uma String da mensagem enviada
            StringBuilder texto = new StringBuilder();
            texto.Append(orcamento);
            mensagem.Body = texto.ToString();
            mensagem.Subject = "Solicitação de Orçamentos ::. ";

            // Cria uma autenticação com Usuario e Senha de seu email de envio
            NetworkCredential credenciais = new NetworkCredential(ConfiguracoesController.email, ConfiguracoesController.senha, "");
            cliente.Credentials = credenciais;
            System.Net.ServicePointManager.Expect100Continue = false;

            try
            {
                cliente.Send(mensagem);
            }
            catch (System.Exception erro)
            {
                Console.WriteLine(erro);
                MessageBox.Show(erro.ToString());

            }

        }
    }
}


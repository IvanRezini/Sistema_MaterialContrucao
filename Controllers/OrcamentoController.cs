using Sistema_MaterialContrucao.Dao;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using Correios.CorreiosServiceReference;
using System.Security.Cryptography;

namespace Sistema_MaterialContrucao.Controllers
{
    class OrcamentoController
    {
        public static DataTable preencherDataGridView()
        {
            DataTable dt = new DataTable();
            DataTable prod = new DataTable();
            dt = ProdutoDao.ListaProduto();


            string[] pro = { "Codigo", "Produto", "Descrição", "Valor", "Estoque", "Fornecedor" };
            //adiciona as colunas
            for (int i = 0; i < pro.Length; i++)
            {
                prod.Columns.Add(pro[i]);
            }

            //adiciona as linhas a tabela
            foreach (DataRow linha in dt.Rows)
            {
                pro[0] = linha["id"].ToString();//codigo
                pro[1] = linha["nome"].ToString();//Produto
                pro[2] = linha["descricao"].ToString();//Descrição
                pro[3] = Math.Round(((decimal.Parse(linha["valor"].ToString()) / 100) + (((decimal.Parse(linha["valor"].ToString()) / 100) / 100) * (decimal.Parse(linha["margemLucro"].ToString())))), 2).ToString("F");//Valor de venda
                pro[4] = linha["quantidadeEStoque"].ToString() + " " + linha["unidade"].ToString();//Estoque
                pro[5] = linha["fornecedor"].ToString();//Fornecedor

                prod.Rows.Add(pro);
            }
            return prod;
        }
        public static List<string> preencherComboBox()
        {
            List<string> cliente = new List<string>();
            DataTable dt = new DataTable();
            dt = ClienteDao.ListaClientes();

            foreach (DataRow linha in dt.Rows)
            {
                cliente.Add(linha["id"].ToString() + " - " + linha["nome"].ToString());
            }
            return cliente;
        }
        public static void salvarOrcamento(List<string[]> pedido, string codCliente, string codPedido, string desconto)
        {
            if (desconto.Trim() == "")
            {
                desconto = "0";
            }
            salvarPedidoBanco(pedido, codCliente, codPedido, desconto);


            string nomeArquivo = ConfiguracoesController.caminhoSalvarArquivos + @"\orcamento.pdf";
            FileStream arquivoPdf = new FileStream(nomeArquivo, FileMode.Create);
            Document doc = new Document(PageSize.A4);
            PdfWriter escritorPdf = PdfWriter.GetInstance(doc, arquivoPdf);

            //inserçao de uma imagem no pdf
            // iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(ConfiguracoesController.caminhoImagens + @"\logo.png");
            // logo.ScaleToFit(140f, 120f);//tamanho da imagem
            // logo.Alignment = Element.ALIGN_RIGHT; //Possisao de alinamento
            //logo.SetAbsolutePosition(100f, 700f);///posiçao absoluta



            //Inserção do primeiro paragrafo
            string dados = "";

            Paragraph paragrafos = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 20, (int)System.Drawing.FontStyle.Bold));
            paragrafos.Alignment = Element.ALIGN_CENTER;
            paragrafos.Add(ConfiguracoesController.NomeLoja + "  CNPJ: " + ConfiguracoesController.Cnpj + "\n");

            paragrafos.Font = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 14, (int)System.Drawing.FontStyle.Italic);

            paragrafos.Add("Telefone: " + ConfiguracoesController.telefone + "\n");
            //nova formatação de font
            paragrafos.Alignment = Element.ALIGN_CENTER;
            paragrafos.Add("Orçamento pedido: " + codPedido + "\n");
            paragrafos.Add("Cliente: " + codCliente + "\n\n\n\n");

            ///adicionar uma tabela
            PdfPTable tabela = new PdfPTable(5) { HorizontalAlignment = Element.ALIGN_CENTER, WidthPercentage = 100, HeaderRows = 2 };///5 colunas
            tabela.DefaultCell.FixedHeight = 20;//Altura das celulas
            tabela.AddCell("Codigo");
            tabela.AddCell("Produto");
            tabela.AddCell("Quantidade");
            tabela.AddCell("Valor");
            tabela.AddCell("Total");

            decimal total = 0;
            for (int i = 0; i < pedido.Count; i++)
            {
                total += decimal.Parse(pedido[i][(pedido[i].Length - 1)]);
                for (int p = 0; p < pedido[i].Length; p++)
                {
                    tabela.AddCell(pedido[i][p]);
                }
            }

            //Totais


            PdfPTable tabelaTotal = new PdfPTable(2) { HorizontalAlignment = Element.ALIGN_RIGHT, WidthPercentage = 40, HeaderRows = 2 };///2 colunas

            tabelaTotal.DefaultCell.FixedHeight = 20;//Altura das celulas
            tabelaTotal.AddCell("Total: ");
            tabelaTotal.AddCell(total.ToString("F"));
            tabelaTotal.AddCell("Desconto: ");
            tabelaTotal.AddCell(desconto);
            tabelaTotal.AddCell("Total: ");

            total = total - (total / 100 * Int32.Parse(desconto));
            tabelaTotal.AddCell(total.ToString("F"));


            //adiciona ao documento
            doc.Open();
            //doc.Add(logo);
            doc.Add(paragrafos);
            doc.Add(tabela);
            doc.Add(tabelaTotal);
            doc.Close();

            DialogResult res = MessageBox.Show("Deseja abrir o relatorio", "Relatorio", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start(ConfiguracoesController.caminhoSalvarArquivos + @"\orcamento.pdf");
            }

        }

        public static void salvarPedidoBanco(List<string[]> pedido, string codCliente, string codPedido, string desconto)
        {
            if (desconto.Trim() == "")
            {
                desconto = "0";
            }
            codCliente = codCliente.Trim();
            string[] cod = codCliente.Split(' ');
            PedidoDao.atualisarPedidoCriado(codPedido, cod[0], desconto);
            PedidoDao.salvarPedido(codPedido, pedido);
        }
        public static List<string> preencherComboBoxPedido()
        {
            List<string> cliente = new List<string>();
            DataTable dt = new DataTable();
            dt = PedidoDao.ListaPedidos();

            foreach (DataRow linha in dt.Rows)
            {
                var parsedDate = DateTime.Parse(linha[2].ToString());
                DateTime d = parsedDate;
                cliente.Add(linha[0].ToString() + "  -  " + linha[1].ToString() + "  -  " + d.ToString("dd-MM-yyyy HH:mm"));
            }
            return cliente;
        }
        public static void excluirPedido(string cod)
        {
            int codigo = Int32.Parse(cod);
            PedidoDao.excuir(codigo);
        }
        public static DataTable pedidoCliente(string cod)
        {
            string[] aux = cod.Split('-');
            int codi = Int32.Parse(aux[0].Trim());
            decimal total = 0;
            decimal desc = 0;
            DataTable dt = new DataTable();
            DataTable prod = new DataTable();
            dt = PedidoDao.ListaItensPedido(codi);

            Console.WriteLine(cod);
            Console.WriteLine(codi);
            Console.WriteLine(dt);
            Console.WriteLine("\n\n\n");

            string[] pro = { "Codigo", "Produto", "Quantidade", "Valor", "Total" };
            //adiciona as colunas
            for (int i = 0; i < pro.Length; i++)
            {
                prod.Columns.Add(pro[i]);
            }

            //adiciona as linhas a tabela
            foreach (DataRow linha in dt.Rows)
            {
                pro[0] = linha[0].ToString();//codigo
                pro[1] = linha[1].ToString();//Produto
                pro[2] = linha[2].ToString();//Quantidade
                pro[3] = Math.Round(decimal.Parse(linha[3].ToString())/100,2).ToString();//Valor
                pro[4] = Math.Round((decimal.Parse(linha[2].ToString())) * (decimal.Parse(linha[3].ToString()) / 100),2).ToString("F");//Valor de venda
                total += Math.Round((decimal.Parse(linha[2].ToString())) * (decimal.Parse(linha[3].ToString()) / 100),2);
                desc = decimal.Parse(linha[4].ToString());//desconto
                prod.Rows.Add(pro);
            }

            pro[0] = "";
            pro[1] = "";
            pro[2] = "";
            pro[3] = "Total:";
            pro[4] = total.ToString("F");
            prod.Rows.Add(pro);

            pro[0] = "";
            pro[1] = "";
            pro[2] = "";
            pro[3] = "Desconto:";
            pro[4] = desc.ToString("F");
            prod.Rows.Add(pro);

            pro[0] = "";
            pro[1] = "";
            pro[2] = "";
            pro[3] = "Total:";
            pro[4] = Math.Round(total-((total/100)*desc),2).ToString("F");
            prod.Rows.Add(pro);

            return prod;
        }
    }
}


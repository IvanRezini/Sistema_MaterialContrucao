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
            paragrafos.Add("Cliente: "+codCliente + "\n\n\n\n");

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
                total += decimal.Parse(pedido[i][(pedido[i].Length-1)]);
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
            if (desconto.Trim()=="")
            {
                desconto = "0";
            }
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

        public void salvarPedidoBanco(List<string[]> pedido, string codCliente, string codPedido, string desconto)
        {

        }


    }
}


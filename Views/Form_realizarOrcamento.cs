using Sistema_MaterialContrucao.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_MaterialContrucao.Views
{
    public partial class Form_realizarOrcamento : Form
    {
        public Form_realizarOrcamento()
        {
            InitializeComponent();
        }

        private void Form_realizarOrcamento_Load(object sender, EventArgs e)
        {
            label_data.Text = Utilidades.obterData.ToString();
            label_usuario.Text = UsuarioLogado.usuario.Nome;
            label_versao.Text = Versao.versao;
            this.popularDataGrid();
            this.popularComboBox();
            //cria as colunas do datagrid pedido
            string[] pro = { "Codigo", "Produto", "Quantidade", "Valor", "Total" };
            foreach (string item in pro)
            {
                dataGridView_pedido.Columns.Add(item, item);
            }

        }
        private void popularDataGrid()
        {
            //dataGridView_Produto = Utilidades.Grade(dataGridView_Produto);
            dataGridView_Produto.DataSource = OrcamentoController.preencherDataGridView();
            dataGridView_Produto.AutoResizeColumn(0);
            dataGridView_Produto.AutoResizeColumn(1);
            dataGridView_Produto.AutoResizeColumn(3);
            dataGridView_Produto.AutoResizeColumn(4);
            dataGridView_Produto.AutoResizeColumn(5);
            dataGridView_Produto.Columns[2].Width = 100;
        }

        private void popularComboBox()
        {
            List<String> cliente = new List<string>();
            cliente = OrcamentoController.preencherComboBox();
            comboBox_cliente.Items.AddRange(cliente.ToArray());
        }
        private void dataGridView_Produto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridView dgv = (DataGridView)sender;
            int contLinhas = dgv.SelectedRows.Count;
            if (contLinhas > 0)
            {
                text_id.Text = dgv.SelectedRows[0].Cells[0].Value.ToString();
                text_produto.Text = dgv.SelectedRows[0].Cells[1].Value.ToString();
                text_desc.Text = dgv.SelectedRows[0].Cells[2].Value.ToString();
                text_valor.Text = dgv.SelectedRows[0].Cells[3].Value.ToString();
                text_quantia.Text = dgv.SelectedRows[0].Cells[4].Value.ToString();
            }
        }

        private void btn_proximoProduto_Click(object sender, EventArgs e)
        {
            if (text_id.Text != "")
            {
                if (text_quantiaPedido.Text.Trim() != "")
                {
                    string codigo = text_id.Text;
                    string produto = text_produto.Text;
                    string quantidade = text_quantiaPedido.Text;
                    string valor = text_valor.Text;
                    string total = (decimal.Parse(quantidade) * decimal.Parse(valor)).ToString();
                    dataGridView_pedido.Rows.Add(codigo, produto, quantidade, valor, total);
                    text_total.Text = (decimal.Parse(total) + decimal.Parse(text_total.Text)).ToString("F");
                    if (text_desconto.Text.Trim() != "")
                    {
                        text_totalComDesconto.Text = (decimal.Parse(text_total.Text) - ((decimal.Parse(text_total.Text) / 100) * decimal.Parse(text_desconto.Text))).ToString("F");
                    }
                    else
                    {
                        text_totalComDesconto.Text = text_total.Text;
                    }
                }

                else
                {
                    MessageBox.Show("Especifique uma quantia");
                }
            }
        }

        private void text_quantiaPedido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void text_desconto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
            {
                e.Handled = true;
            }
        }
        private void btn_salvar_Click(object sender, EventArgs e)
        {
            List<string[]> pedido = new List<string[]>();
            int cont = dataGridView_pedido.Rows.Count;
            for (int i = 0; i <cont; i++)
            {
                string[] linha=new string[4];
                linha[0]=dataGridView_pedido.Rows[i].Cells[0].Value.ToString();
                linha[1] = dataGridView_pedido.Rows[i].Cells[1].Value.ToString();
                linha[2] = dataGridView_pedido.Rows[i].Cells[2].Value.ToString();
                linha[3] = dataGridView_pedido.Rows[i].Cells[3].Value.ToString();
                pedido.Add(linha);
            }
            for (int i = 0; i < pedido.Count; i++)
            {
                Console.WriteLine("\n\n");
                for (int p = 0; p < pedido[i].Length; p++)
                {
                    Console.WriteLine(pedido[i][p]);
                }
            }

        }
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Se vc cancelar perdera todos os dados", "Continuar?", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                this.limparCampos();
            }
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Se vc sair perdera todos os dados", "Continuar?", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                this.limparCampos();
                this.Close();
            }
        }
        private void limparCampos()
        {
            text_desc.Clear();
            text_desconto.Clear();
            text_id.Clear();
            text_produto.Clear();
            text_quantia.Clear();
            text_quantiaPedido.Clear();
            text_total.Text = "0";
            text_totalComDesconto.Clear();
            text_valor.Clear();
            dataGridView_pedido.Rows.Clear();

        }
    }
}


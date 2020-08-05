using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_MaterialContrucao.Controllers;
using Sistema_MaterialContrucao.Dao;
using Sistema_MaterialContrucao.Models;

namespace Sistema_MaterialContrucao.Views
{
    public partial class Form_entradaNoEstoque : Form
    {
        public Form_entradaNoEstoque()
        {
            InitializeComponent();
        }

        private void Form_entradaNoEstoque_Load(object sender, EventArgs e)
        {
            label_data.Text = Utilidades.obterData.ToString();
            label_usuario.Text = UsuarioLogado.usuario.Nome;
            label_versao.Text = Versao.versao;
            this.popularDataGrid();
            this.limparCampos();
        }
        private void popularDataGrid()
        {
            dataGridView_Produto.DataSource = ProdutoController.preencherDataGridView();
            dataGridView_Produto.AutoResizeColumn(0);
            dataGridView_Produto.AutoResizeColumn(1);
            dataGridView_Produto.AutoResizeColumn(3);
            dataGridView_Produto.AutoResizeColumn(4);
            dataGridView_Produto.AutoResizeColumn(5);
            dataGridView_Produto.AutoResizeColumn(6);
            dataGridView_Produto.AutoResizeColumn(7);
            dataGridView_Produto.Columns[2].Width = 100;
        }
        private void limparCampos()
        {
            text_id.Clear();
            text_desc.Clear();
            text_entrada.Clear();
            text_lucro.Clear();
            text_novaMargemLucro.Clear();
            text_novoValor.Clear();
            text_produto.Clear();
            text_quantia.Clear();
            text_valor.Clear();
            dataGridView_Produto.ClearSelection();
            btn_salvar.Enabled = false;

        }

        private void dataGridView_Produto_SelectionChanged(object sender, EventArgs e)
        {
            btn_salvar.Enabled = true;
            DataGridView dgv = (DataGridView)sender;
            int contLinhas = dgv.SelectedRows.Count;
            if (contLinhas > 0)
            {
                text_id.Text = dgv.SelectedRows[0].Cells[0].Value.ToString();
                text_produto.Text = dgv.SelectedRows[0].Cells[1].Value.ToString();
                text_desc.Text = dgv.SelectedRows[0].Cells[2].Value.ToString();
                text_valor.Text ="R$ " + dgv.SelectedRows[0].Cells[3].Value.ToString();
                text_lucro.Text = dgv.SelectedRows[0].Cells[4].Value.ToString();
                text_quantia.Text = dgv.SelectedRows[0].Cells[6].Value.ToString() +"  "+ dgv.SelectedRows[0].Cells[7].Value.ToString();
            }
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            string valor = text_novoValor.Text;
            string novaQuantia = text_entrada.Text;
            string lucro = text_novaMargemLucro.Text;
            if(valor.Trim() == "")
            {
                string[] aux = text_valor.Text.Split(' ');
                valor = aux[1];
            }
            if (novaQuantia.Trim() == "")
            {
                novaQuantia = "0";
            }
            if (lucro.Trim() == "")
            {
                lucro = text_lucro.Text;
            }

            DialogResult res = MessageBox.Show("Quantidade: "+ novaQuantia + "\nValor: "+valor+"\nPorcentagem para a venda: "+lucro, "Salvar alterações?", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                bool resposta;
                if (resposta = ProdutoController.alterarEstoque(text_id.Text, text_quantia.Text, valor, novaQuantia, lucro)){
                    this.popularDataGrid();
                    this.limparCampos();
                }
                else
                {
                    MessageBox.Show("Verifique se os valores estão coretos/nSe o erro persistir Contacte o suporte.","Falha ");
                }
            }
        }

        private void text_novoValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
            {
                e.Handled = true;
            }
        }

        private void text_novaMargemLucro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void text_entrada_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.limparCampos();
        }
    }
}

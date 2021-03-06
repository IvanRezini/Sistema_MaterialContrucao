﻿using Sistema_MaterialContrucao.Controllers;
using Sistema_MaterialContrucao.Dao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
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
            label_pedido.Text = PedidoDao.insertNovoPedido();
            timer1.Start();
            label_data.Text = Utilidades.obterData();
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
                text_quantiaPedido.Focus();
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
                    text_desc.Clear();
                    text_id.Clear();
                    text_produto.Clear();
                    text_quantia.Clear();
                    text_quantiaPedido.Clear();
                    text_valor.Clear();
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

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Se vc cancelar perdera todos os dados", "Continuar?", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                OrcamentoController.excluirPedido(label_pedido.Text);
                this.limparCampos();
                label_pedido.Text = PedidoDao.insertNovoPedido();
            }
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Se vc sair perdera todos os dados", "Continuar?", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                OrcamentoController.excluirPedido(label_pedido.Text);
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

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            List<string[]> pedido = this.obterDadosPedido();
            if (pedido.Count > 0)
            { 

            }
        }

        private void btn_enviarPorEmail_Click(object sender, EventArgs e)
        {
            List<string[]> pedido = this.obterDadosPedido();
            if (pedido.Count > 0)
            {

            }
        }
        private void btn_salvar_Click(object sender, EventArgs e)
        {
            List<string[]> pedido = this.obterDadosPedido();
            if (pedido.Count > 0)
            {
                OrcamentoController.salvarOrcamento(pedido, comboBox_cliente.Text, label_pedido.Text, text_desconto.Text.Trim());
                this.limparCampos();
                label_pedido.Text = PedidoDao.insertNovoPedido();
            }
        }
        public List<string[]> obterDadosPedido()
        {

            List<string[]> pedido = new List<string[]>();
            if (comboBox_cliente.Text.Trim() != "")
            {
                if (dataGridView_pedido.Rows.Count > 0)
                {
                    int cont = dataGridView_pedido.Rows.Count;
                    for (int i = 0; i < cont; i++)
                    {
                        string[] linha = new string[5];
                        linha[0] = dataGridView_pedido.Rows[i].Cells[0].Value.ToString();
                        linha[1] = dataGridView_pedido.Rows[i].Cells[1].Value.ToString();
                        linha[2] = dataGridView_pedido.Rows[i].Cells[2].Value.ToString();
                        linha[3] = dataGridView_pedido.Rows[i].Cells[3].Value.ToString();
                        linha[4] = dataGridView_pedido.Rows[i].Cells[4].Value.ToString();
                        pedido.Add(linha);
                    }
                }
                else
                {
                    MessageBox.Show("Este pedido está vazio");
                }
            }
            else
            {
                MessageBox.Show("Selecione um cliente");
            }
            return pedido;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label_data.Text = Utilidades.obterData();
        }

        private void text_desconto_TextChanged(object sender, EventArgs e)
        {
            if (text_desconto.Text.Trim() != "")
            {
                text_totalComDesconto.Text = (decimal.Parse(text_total.Text) - ((decimal.Parse(text_total.Text) / 100) * decimal.Parse(text_desconto.Text))).ToString("F");
            }
            else
            {
                text_totalComDesconto.Text = text_total.Text;
            }
        }

        private void dataGridView_pedido_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult res = MessageBox.Show("Deseja excluir esse produto?", "Confirmar?", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                dataGridView_pedido.Rows.Remove(dataGridView_pedido.CurrentRow);
            }
        }

        private void Form_realizarOrcamento_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult res = MessageBox.Show("Se vc sair perdera todos os dados", "Continuar?", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                OrcamentoController.excluirPedido(label_pedido.Text);
                this.limparCampos();
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}


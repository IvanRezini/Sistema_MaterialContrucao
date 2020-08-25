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
    public partial class Form_buscarPedido : Form
    {
        public Form_buscarPedido()
        {
            InitializeComponent();
        }


        private void Form_buscarPedido_Load(object sender, EventArgs e)
        {
            timer1.Start();
            label_data.Text = Utilidades.obterData();
            label_usuario.Text = UsuarioLogado.usuario.Nome;
            label_versao.Text = Versao.versao;
            this.popularComboBox();
        }
        private void popularComboBox()
        {
            List<String> cliente = new List<string>();
            cliente = OrcamentoController.preencherComboBoxPedido();
            comboBox_cliente.Items.AddRange(cliente.ToArray());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label_data.Text = Utilidades.obterData();
        }
        private void comboBox_cliente_TextChanged(object sender, EventArgs e)
        {
            if (comboBox_cliente.SelectedIndex>=0) 
            {
                dataGridView_Pedido.DataSource = OrcamentoController.pedidoCliente(comboBox_cliente.Text);
            } 
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            List<string[]> pedido = new List<string[]>();
            int cont = dataGridView_Pedido.Rows.Count;
            for (int i = 0; i < (cont - 3); i++)
            {
                string[] linha = new string[5];
                linha[0] = dataGridView_Pedido.Rows[i].Cells[0].Value.ToString();
                linha[1] = dataGridView_Pedido.Rows[i].Cells[1].Value.ToString();
                linha[2] = dataGridView_Pedido.Rows[i].Cells[2].Value.ToString();
                linha[3] = dataGridView_Pedido.Rows[i].Cells[3].Value.ToString();
                linha[4] = dataGridView_Pedido.Rows[i].Cells[4].Value.ToString();
                pedido.Add(linha);
            }
            string[] aux = comboBox_cliente.Text.Split('-');
            if (cont > 3)
            {
                OrcamentoController.salvarOrcamento(pedido, aux[1].Trim(), aux[0].Trim(), dataGridView_Pedido.Rows[cont - 2].Cells[4].Value.ToString());
            }
            else
            {
                MessageBox.Show("Pedido em branco");
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            comboBox_cliente.SelectedIndex = -1;
            dataGridView_Pedido.Columns.Clear();
        }
    }
}

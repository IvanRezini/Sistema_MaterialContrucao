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
            dataGridView_Pedido.DataSource = OrcamentoController.pedidoCliente(comboBox_cliente.Text);
        }
    }
}

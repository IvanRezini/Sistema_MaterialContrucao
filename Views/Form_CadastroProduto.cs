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
using Sistema_MaterialContrucao.Models;

namespace Sistema_MaterialContrucao.Views
{
    public partial class Form_CadastroProduto : Form
    {
        public Form_CadastroProduto()
        {
            InitializeComponent();
        }

        private void Form_CadastroProduto_Load(object sender, EventArgs e)
        {
            label_data.Text = Utilidades.obterData.ToString();
            label_usuario.Text = UsuarioLogado.usuario.Nome;
            label_versao.Text = Versao.versao;
            comboBox_unidadeMedida.DataSource = Utilidades.unidadeDeMedida;
            textBox_nome.Focus();
        }
        private void limparCampos()
        {
            textBox_nome.Clear();
            textBox_descricao.Clear();
            textBox_fornecedor.Clear();
            comboBox_unidadeMedida.SelectedIndex = 0;
            textBox_nome.Focus();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            ProdutoModel pro = new ProdutoModel();
            pro.Nome = textBox_nome.Text.Trim();
            pro.Descricao = textBox_descricao.Text.Trim();
            pro.Fornecedor = textBox_fornecedor.Text.Trim();
            pro.Unidade = comboBox_unidadeMedida.Text;
            DialogResult res = MessageBox.Show(@"Produto: "+ textBox_nome.Text+"\nUnidade: "+ comboBox_unidadeMedida.Text
            +"\nDescrição: "+textBox_descricao.Text+"\nFornecedor: "+textBox_fornecedor.Text, "Confirmar?", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                string resposta = ProdutoController.salvar(pro);
                if (resposta == "") 
                {
                    limparCampos();
                }
                else
                {
                    MessageBox.Show(resposta);
                }
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

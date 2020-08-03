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
    public partial class Form_editarExcluir : Form
    {
        public Form_editarExcluir()
        {
            InitializeComponent();
        }

        private void Form_editarExcluir_Load(object sender, EventArgs e)
        {

            label_data.Text = Utilidades.obterData.ToString();
            label_usuario.Text = UsuarioLogado.usuario.Nome;
            label_versao.Text = Versao.versao;
            this.popularDataGrid();
            this.limparCampos();
            btn_salvar.Visible = false;
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
            text_baixa.Clear();
            text_motivoBaixa.Clear();
            text_produto.Clear();
            text_quantia.Clear();
            dataGridView_Produto.ClearSelection();
            btn_salvar.Enabled = false;
            btn_excluir.Enabled = false;

        }

        private void dataGridView_Produto_SelectionChanged(object sender, EventArgs e)
        {
            btn_salvar.Enabled = true;
            btn_excluir.Enabled = true;
            DataGridView dgv = (DataGridView)sender;
            int contLinhas = dgv.SelectedRows.Count;
            if (contLinhas > 0)
            {
                text_id.Text = dgv.SelectedRows[0].Cells[0].Value.ToString();
                text_produto.Text = dgv.SelectedRows[0].Cells[1].Value.ToString();
                text_desc.Text = dgv.SelectedRows[0].Cells[2].Value.ToString();
                text_quantia.Text = dgv.SelectedRows[0].Cells[6].Value.ToString() + "  " + dgv.SelectedRows[0].Cells[7].Value.ToString();
            }
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            string resposta;
            resposta = ProdutoController.editar(text_id.Text, text_produto.Text, text_desc.Text, text_quantia.Text, text_baixa.Text, text_motivoBaixa.Text);
            if (resposta == "")
            {
                this.limparCampos();
                this.popularDataGrid();
                btn_salvar.Visible = false;
            }
            else
            {
                MessageBox.Show(resposta, "Error");
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            btn_salvar.Visible = false;
            this.limparCampos();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void text_baixa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            btn_salvar.Visible = true;
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            if (dataGridView_Produto.SelectedRows.Count > 0)
            {
                DialogResult res = MessageBox.Show("Confirmar exclusão?", "Excluir?", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    string resposta=ProdutoController.excluir(text_id.Text,  text_quantia.Text, text_baixa.Text, text_motivoBaixa.Text);
                    if (resposta == "")
                    {
                        this.limparCampos();
                        this.popularDataGrid();
                    }
                    else
                    {
                        MessageBox.Show(resposta);
                    }

                }
            }
            else
            {
                MessageBox.Show("Selecione um produto primeiro.");
            }
        }
    }
}

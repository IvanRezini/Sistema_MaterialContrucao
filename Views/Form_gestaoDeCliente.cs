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
    public partial class Form_gestaoDeCliente : Form
    {
        int controleDataGr = 0;
        public Form_gestaoDeCliente()
        {
            InitializeComponent();

        }
        private void Form_gestaoDeCliente_Load(object sender, EventArgs e)
        {
            timer1.Start();
            this.popularDataGrid();
            label_data.Text = Utilidades.obterData();
            label_usuario.Text = UsuarioLogado.usuario.Nome;
            label_versao.Text = Versao.versao;
            btn_excluir.Visible = false;
            btn_salvar.Visible = false;
            this.limparCampos();
        }
        private void popularDataGrid()
        {
            dataGridView_Cliente.DataSource = ClienteDao.ListaClientes();
            dataGridView_Cliente.Columns[0].Width = 50;
            dataGridView_Cliente.Columns[1].Width = 110;
            dataGridView_Cliente.Columns[2].Width = 85;
            dataGridView_Cliente.Columns[3].Width = 90;
            dataGridView_Cliente.Columns[4].Width = 65;
            dataGridView_Cliente.Columns[8].Width = 50;
            dataGridView_Cliente.AutoResizeColumn(9);
            dataGridView_Cliente.AutoResizeColumn(10);
            dataGridView_Cliente.ClearSelection();
            controleDataGr = 1;
        }
            private void limparCampos()
        {
            text_id.Clear();
            text_nome.Clear();
            text_telefone.Clear();
            text_email.Clear();
            text_rua.Clear();
            text_cidade.Clear();
            text_cpf.Clear();
            text_bairro.Clear();
            text_cep.Clear();
            text_uf.Clear();
            text_numero.Value = 0;
            dataGridView_Cliente.ClearSelection();
        }

        private void ocultarCampos()
        {
            text_nome.Enabled = false;
            text_telefone.Enabled = false;
            text_email.Enabled = false;
            text_rua.Enabled = false;
            text_cidade.Enabled = false;
            text_bairro.Enabled = false;
            text_cep.Enabled = false;
            text_cpf.Enabled = false;
            text_uf.Enabled = false;
            text_numero.Enabled = false;

        }
        private void mostrarCampos()
        {
            text_nome.Enabled = true;
            text_telefone.Enabled = true;
            text_email.Enabled = true;
            text_rua.Enabled = true;
            text_cidade.Enabled = true;
            text_uf.Enabled = true;
            text_bairro.Enabled = true;
            text_cep.Enabled = true;
            text_cpf.Enabled = true;
            text_numero.Enabled = true;
        }

        private void text_cep_TextChanged(object sender, EventArgs e)
        {
            Task task = BuscarCep();
        }


        public async Task BuscarCep()
        {
            string r = text_cep.Text.Replace("-", "").Replace(" ", "");
            if (controleDataGr == 1)
            {
                if (r.Length == 8)
                {
                    string[] endereco = await Task.Run(() => Utilidades.endereco(text_cep.Text));
                    text_cidade.Text = endereco[0];
                    text_bairro.Text = endereco[1];
                    text_rua.Text = endereco[2];
                    text_uf.Text = endereco[3];
                }
            }
        }
        private void btn_salvar_Click(object sender, EventArgs e)
        {
            ClienteModel cli = new ClienteModel();
            cli.Nome = text_nome.Text.Trim();
            cli.Numero = Int32.Parse(text_numero.Value.ToString());
            cli.Rua = text_rua.Text;
            cli.Telefone = text_telefone.Text;
            cli.Bairro = text_bairro.Text;
            cli.Cep = text_cep.Text;
            cli.Cidade = text_cidade.Text + " - " + text_uf.Text;
            cli.Cpf = text_cpf.Text;
            cli.Email = text_email.Text;
            if (text_id.Text != "")
            {
                cli.Id = Int32.Parse(text_id.Text);
            }

            string resposta = ClienteController.salvar(cli);

            if (resposta == "")
            {
                dataGridView_Cliente.Enabled = false;
                this.popularDataGrid();
                this.limparCampos();
                this.ocultarCampos();
                btn_salvar.Visible = false;
                btn_editar.Visible = true;
                btn_novo.Visible = true;
                btn_excluir.Visible = false;
            }
            else
            {
                MessageBox.Show(resposta);
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            btn_salvar.Visible = false;
            btn_excluir.Visible = false;
            btn_editar.Visible = true;
            btn_novo.Visible = true;
            dataGridView_Cliente.Enabled = false;
            this.limparCampos();
            this.ocultarCampos();
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            if (dataGridView_Cliente.SelectedRows.Count > 0)
            {
                DialogResult res = MessageBox.Show("Confirmar exclusão?", "Excluir?", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    ClienteDao.excluir(text_id.Text);
                    dataGridView_Cliente.Rows.Remove(dataGridView_Cliente.CurrentRow);
                    this.limparCampos();
                    this.ocultarCampos();
                    btn_salvar.Visible = false;
                    btn_excluir.Visible = false;
                    btn_editar.Visible = true;
                    btn_novo.Visible = true;
                    dataGridView_Cliente.Enabled = false;
                    dataGridView_Cliente.ClearSelection();
                }
            }
            else
            {
                MessageBox.Show("Selecione um cliente");
            }
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            this.limparCampos();
            this.mostrarCampos();
            btn_editar.Visible = false;
            btn_excluir.Visible = false;
            btn_salvar.Visible = true;
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            this.mostrarCampos();
            dataGridView_Cliente.Enabled = true;
            btn_excluir.Visible = false;
            btn_novo.Visible = false;
            btn_excluir.Visible = true;
            btn_salvar.Visible = true;
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView_Cliente_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int contLinhas = dgv.SelectedRows.Count;
            if (contLinhas > 0)
            {
                text_id.Text = dgv.SelectedRows[0].Cells[0].Value.ToString();
                text_nome.Text = dgv.SelectedRows[0].Cells[1].Value.ToString();
                text_cpf.Text = dgv.SelectedRows[0].Cells[2].Value.ToString();
                text_telefone.Text = dgv.SelectedRows[0].Cells[3].Value.ToString();
                text_cep.Text = dgv.SelectedRows[0].Cells[4].Value.ToString();

                text_cidade.Text = dgv.SelectedRows[0].Cells[5].Value.ToString().Split('-')[0].Trim();
                text_uf.Text = dgv.SelectedRows[0].Cells[5].Value.ToString().Split('-')[1].Trim();

                text_bairro.Text = dgv.SelectedRows[0].Cells[6].Value.ToString();
                text_rua.Text = dgv.SelectedRows[0].Cells[7].Value.ToString();
                text_numero.Text = dgv.SelectedRows[0].Cells[8].Value.ToString();
                text_email.Text = dgv.SelectedRows[0].Cells[9].Value.ToString();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label_data.Text = Utilidades.obterData();
        }
    }
}

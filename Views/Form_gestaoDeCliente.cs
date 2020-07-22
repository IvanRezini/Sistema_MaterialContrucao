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
        public Form_gestaoDeCliente()
        {
            InitializeComponent();
            
        }  
        private void Form_gestaoDeCliente_Load(object sender, EventArgs e)
        {
            this.popularDataGrid();
            label_data.Text = Utilidades.obterData.ToString();
            label_usuario.Text = UsuarioLogado.usuario.Nome;
            label_versao.Text = Versao.versao;
            dataGridView_Cliente.Enabled = false;
            btn_excluir.Visible = false;
            btn_salvar.Visible = false;
            this.limparCampos();
        }
        private void popularDataGrid()
        {

            dataGridView_Cliente.ClearSelection();
            dataGridView_Cliente.DataSource = ClienteDao.ListaClientes();
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
            text_rua.Clear();
            text_cep.Clear();
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
            text_numero.Enabled = false;

        }
        private void mostrarCampos()
        {
            text_nome.Enabled = true;
            text_telefone.Enabled = true;
            text_email.Enabled = true;
            text_rua.Enabled = true;
            text_cidade.Enabled = true;
            text_bairro.Enabled = true;
            text_cep.Enabled = true;
            text_cpf.Enabled = true;
            text_numero.Enabled = true;
        }
        private void text_cep_Leave(object sender, EventArgs e)
        {
            string []endereco = Utilidades.endereco(text_cep.Text);
            text_cidade.Text = endereco[0];
            text_bairro.Text = endereco[1];
            text_rua.Text = endereco[2];
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
            cli.Cidade = text_cidade.Text;
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
            DialogResult res = MessageBox.Show("Confirmar exclusão?", "Excluir?", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                UsuarioDao.excluir(text_id.Text);
                dataGridView_Cliente.Rows.Remove(dataGridView_Cliente.CurrentRow);
                this.limparCampos();
                this.ocultarCampos();
                btn_salvar.Visible = false;
                btn_excluir.Visible = false;
                btn_editar.Visible = true;
                btn_novo.Visible = true;
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
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_MaterialContrucao.Dao;
using Sistema_MaterialContrucao.Controllers;
using Sistema_MaterialContrucao.Models;

namespace Sistema_MaterialContrucao.Views
{
    public partial class Form_gestaoDeUsuario : Form
    {
        public Form_gestaoDeUsuario()
        {
            InitializeComponent();
        }

        private void Form_gestaoDeUsuario_Load(object sender, EventArgs e)
        {
            this.popularDataGrid();
            label_data.Text = Utilidades.obterData.ToString();
            label_usuario.Text = UsuarioLogado.usuario.Nome;
            label_versao.Text = Versao.versao;
            dataGridView_usuario.Enabled = false;
            btn_excluir.Visible = false;
            btn_salvar.Visible = false;
            this.limparCampos();
        }
        private void popularDataGrid()
        {

            dataGridView_usuario.ClearSelection();
            dataGridView_usuario.DataSource = UsuarioDao.ListaUsuario();
        }
        private void limparCampos()
        {
            text_id.Clear();
            text_nome.Clear();
            text_telefone.Clear();
            text_email.Clear();
            text_senha.Clear();
            comboBox_tipo.SelectedIndex = 0;
            text_userName.Clear();
            dataGridView_usuario.ClearSelection();
        }

        private void ocultarCampos()
        {
            text_nome.Enabled = false;
            text_telefone.Enabled = false;
            text_email.Enabled = false;
            text_senha.Enabled = false;
            comboBox_tipo.Enabled = false;
            text_userName.Enabled = false;
        }
        private void mostrarCampos()
        {
            text_nome.Enabled = true;
            text_telefone.Enabled = true;
            text_email.Enabled = true;
            text_senha.Enabled = true;
            comboBox_tipo.Enabled = true;
            text_userName.Enabled = true;
        }

            private void btn_novo_Click(object sender, EventArgs e)
        {
            this.limparCampos();
            this.mostrarCampos();
            btn_editar.Visible = false;
            btn_excluir.Visible = false;
            btn_salvar.Visible = true;
        }

        private void dataGridView_usuario_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int contLinhas = dgv.SelectedRows.Count;
            Console.WriteLine(contLinhas.ToString());
            if (contLinhas > 0)
            {
                text_id.Text = dgv.SelectedRows[0].Cells[0].Value.ToString();
                text_nome.Text = dgv.SelectedRows[0].Cells[1].Value.ToString();
                text_telefone.Text = dgv.SelectedRows[0].Cells[2].Value.ToString();
                text_userName.Text = dgv.SelectedRows[0].Cells[3].Value.ToString();
                text_senha.Text= dgv.SelectedRows[0].Cells[4].Value.ToString();
                comboBox_tipo.SelectedIndex = Int32.Parse(dgv.SelectedRows[0].Cells[5].Value.ToString())-1;
                text_email.Text= dgv.SelectedRows[0].Cells[6].Value.ToString();

            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            this.mostrarCampos();
            dataGridView_usuario.Enabled = true;
            btn_excluir.Visible = false;
            btn_novo.Visible = false;
            btn_excluir.Visible = true;
            btn_salvar.Visible = true;
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            UsuarioModel uso = new UsuarioModel();
            uso.Nome = text_nome.Text.Trim();
            uso.NomeUsuario = text_userName.Text;
            uso.Senha = text_senha.Text;
            uso.Telefone = text_telefone.Text;
            uso.Tipo = comboBox_tipo.SelectedIndex + 1;
            uso.Email = text_email.Text;
            if (text_id.Text != "")
            {
                uso.Id = Int32.Parse(text_id.Text);
            }
          
            string resposta = UsurioController.salvar(uso);
            
            if (resposta == "") 
            {
                dataGridView_usuario.Enabled = false;
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

        private void btn_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Confirmar exclusão?", "Excluir?", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                UsuarioDao.excluir(text_id.Text);
                dataGridView_usuario.Rows.Remove(dataGridView_usuario.CurrentRow);
                this.limparCampos();
                this.ocultarCampos();
                btn_salvar.Visible = false;
                btn_excluir.Visible = false;
                btn_editar.Visible = true;
                btn_novo.Visible = true;
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            btn_salvar.Visible = false;
            btn_excluir.Visible = false;
            btn_editar.Visible = true;
            btn_novo.Visible = true;
            dataGridView_usuario.Enabled = false;
            this.limparCampos();
            this.ocultarCampos();
        }
    }
}

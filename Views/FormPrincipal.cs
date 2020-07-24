﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_MaterialContrucao.Controllers;

namespace Sistema_MaterialContrucao.Views
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            Hide();
            Login login = new Login(this);

            login.ShowDialog();
            InitializeComponent();
  
        }
        private void FormPrincipal_Shown(object sender, EventArgs e)
        {
            label_data.Text = Utilidades.obterData.ToString();
            label_usuario.Text = UsuarioLogado.usuario.Nome;
            label_versao.Text = Versao.versao;
        }
        private void FormPrincipal_VisibleChanged(object sender, EventArgs e)
        {
            label_data.Text = Utilidades.obterData.ToString();
            label_usuario.Text = UsuarioLogado.usuario.Nome;
            label_versao.Text = Versao.versao;
        }


        private void cadastroClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_gestaoDeCliente form_CadastroCliente = new Form_gestaoDeCliente();
            form_CadastroCliente.ShowDialog();
        }

        private void logarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Login login = new Login(this);
            login.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Login login = new Login(this);
            login.Show();
        }

        private void cadastroProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_CadastroProduto form_CadastroProduto = new Form_CadastroProduto();
            form_CadastroProduto.ShowDialog();
        }

        private void gestãoDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_gestaoDeUsuario form_GestaoDeUsuario = new Form_gestaoDeUsuario();
            form_GestaoDeUsuario.ShowDialog();
        }

        private void darEntradaNoEstoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_entradaNoEstoque form_EntradaNoEstoque = new Form_entradaNoEstoque();
            form_EntradaNoEstoque.ShowDialog();
        }
    }
}

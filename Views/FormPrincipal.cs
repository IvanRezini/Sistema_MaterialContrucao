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

namespace Sistema_MaterialContrucao.Views
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            label_data.Text = Utilidades.dia.ToString();
            label_usuario.Text = UsuarioLogado.usuario.Nome;
            label_versao.Text = Versao.versao;
        }

        private void gestãoDeUsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_gestaoDeUsuario form_GestaoDeUsuario = new Form_gestaoDeUsuario();
            form_GestaoDeUsuario.ShowDialog();
        }

        private void cadastroClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_gestaoDeCliente form_CadastroCliente = new Form_gestaoDeCliente();
            form_CadastroCliente.ShowDialog();
        }
    }
}

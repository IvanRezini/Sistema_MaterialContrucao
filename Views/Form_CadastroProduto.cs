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
        }
    }
}

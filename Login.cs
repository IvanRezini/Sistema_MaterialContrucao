using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_MaterialContrucao.Dao;
using Sistema_MaterialContrucao.Models;
using Sistema_MaterialContrucao.Controllers;
using Sistema_MaterialContrucao.Views;
namespace Sistema_MaterialContrucao
{

    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_logar_Click(object sender, EventArgs e)
        {
            UsuarioModel uso = new UsuarioModel();
            uso = UsuarioDao.login(text_userName.Text, text_senha.Text);
            UsuarioLogado.usuario = uso;
           FormPrincipal formPrincipal = new FormPrincipal();
            formPrincipal.ShowDialog();
            this.Close();

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            UsuarioLogado.usuario = null;
            Close();
        }
    }
}




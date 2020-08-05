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
using System.Reflection;

namespace Sistema_MaterialContrucao
{

    public partial class Login : Form
    {
        private FormPrincipal form;

        public Login(FormPrincipal f)
        {
            InitializeComponent();
            ControlBox = false;
            form = f;
        }

        private void btn_logar_Click(object sender, EventArgs e)
        {
            UsuarioModel uso = new UsuarioModel();
            uso = UsuarioDao.login(text_userName.Text, text_senha.Text);
            if (uso.Id > 0)
            {
                UsuarioLogado.usuario = uso;
                MessageBox.Show("Bem vindo " + uso.Nome);
                this.Dispose();
                form.Show();
            }
            else
            {
                MessageBox.Show("Usuario ou senha incoretos");
            }

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            UsuarioModel uso = new UsuarioModel();
            uso.Id = 0;
            UsuarioLogado.usuario = uso;
            Application.Exit();
        }
        
    }
}




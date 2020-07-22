namespace Sistema_MaterialContrucao.Views
{
    partial class Form_gestaoDeUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_gestaoDeUsuario));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel_rodape = new System.Windows.Forms.Panel();
            this.label_data = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_usuario = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_versao = new System.Windows.Forms.Label();
            this.panel_botoes = new System.Windows.Forms.Panel();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_novo = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridView_usuario = new System.Windows.Forms.DataGridView();
            this.comboBox_tipo = new System.Windows.Forms.ComboBox();
            this.text_telefone = new System.Windows.Forms.MaskedTextBox();
            this.text_email = new System.Windows.Forms.TextBox();
            this.text_senha = new System.Windows.Forms.TextBox();
            this.text_userName = new System.Windows.Forms.TextBox();
            this.text_nome = new System.Windows.Forms.TextBox();
            this.text_id = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel_rodape.SuspendLayout();
            this.panel_botoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_usuario)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_rodape
            // 
            this.panel_rodape.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel_rodape.Controls.Add(this.label_data);
            this.panel_rodape.Controls.Add(this.label3);
            this.panel_rodape.Controls.Add(this.label_usuario);
            this.panel_rodape.Controls.Add(this.label2);
            this.panel_rodape.Controls.Add(this.label1);
            this.panel_rodape.Controls.Add(this.label_versao);
            resources.ApplyResources(this.panel_rodape, "panel_rodape");
            this.panel_rodape.Name = "panel_rodape";
            // 
            // label_data
            // 
            resources.ApplyResources(this.label_data, "label_data");
            this.label_data.Name = "label_data";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label_usuario
            // 
            resources.ApplyResources(this.label_usuario, "label_usuario");
            this.label_usuario.Name = "label_usuario";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label_versao
            // 
            resources.ApplyResources(this.label_versao, "label_versao");
            this.label_versao.Name = "label_versao";
            // 
            // panel_botoes
            // 
            this.panel_botoes.Controls.Add(this.btn_editar);
            this.panel_botoes.Controls.Add(this.btn_novo);
            this.panel_botoes.Controls.Add(this.btn_sair);
            this.panel_botoes.Controls.Add(this.btn_excluir);
            this.panel_botoes.Controls.Add(this.btn_cancelar);
            this.panel_botoes.Controls.Add(this.btn_salvar);
            resources.ApplyResources(this.panel_botoes, "panel_botoes");
            this.panel_botoes.Name = "panel_botoes";
            // 
            // btn_editar
            // 
            resources.ApplyResources(this.btn_editar, "btn_editar");
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_novo
            // 
            resources.ApplyResources(this.btn_novo, "btn_novo");
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.UseVisualStyleBackColor = true;
            this.btn_novo.Click += new System.EventHandler(this.btn_novo_Click);
            // 
            // btn_sair
            // 
            resources.ApplyResources(this.btn_sair, "btn_sair");
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // btn_excluir
            // 
            resources.ApplyResources(this.btn_excluir, "btn_excluir");
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // btn_cancelar
            // 
            resources.ApplyResources(this.btn_cancelar, "btn_cancelar");
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_salvar
            // 
            resources.ApplyResources(this.btn_salvar, "btn_salvar");
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // splitContainer1
            // 
            resources.ApplyResources(this.splitContainer1, "splitContainer1");
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView_usuario);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.comboBox_tipo);
            this.splitContainer1.Panel2.Controls.Add(this.text_telefone);
            this.splitContainer1.Panel2.Controls.Add(this.text_email);
            this.splitContainer1.Panel2.Controls.Add(this.text_senha);
            this.splitContainer1.Panel2.Controls.Add(this.text_userName);
            this.splitContainer1.Panel2.Controls.Add(this.text_nome);
            this.splitContainer1.Panel2.Controls.Add(this.text_id);
            this.splitContainer1.Panel2.Controls.Add(this.label10);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.label9);
            this.splitContainer1.Panel2.Controls.Add(this.label8);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            // 
            // dataGridView_usuario
            // 
            this.dataGridView_usuario.AllowUserToAddRows = false;
            this.dataGridView_usuario.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_usuario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_usuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dataGridView_usuario, "dataGridView_usuario");
            this.dataGridView_usuario.EnableHeadersVisualStyles = false;
            this.dataGridView_usuario.MultiSelect = false;
            this.dataGridView_usuario.Name = "dataGridView_usuario";
            this.dataGridView_usuario.ReadOnly = true;
            this.dataGridView_usuario.RowHeadersVisible = false;
            this.dataGridView_usuario.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView_usuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_usuario.TabStop = false;
            this.dataGridView_usuario.SelectionChanged += new System.EventHandler(this.dataGridView_usuario_SelectionChanged);
            // 
            // comboBox_tipo
            // 
            resources.ApplyResources(this.comboBox_tipo, "comboBox_tipo");
            this.comboBox_tipo.FormattingEnabled = true;
            this.comboBox_tipo.Items.AddRange(new object[] {
            resources.GetString("comboBox_tipo.Items"),
            resources.GetString("comboBox_tipo.Items1"),
            resources.GetString("comboBox_tipo.Items2")});
            this.comboBox_tipo.Name = "comboBox_tipo";
            // 
            // text_telefone
            // 
            resources.ApplyResources(this.text_telefone, "text_telefone");
            this.text_telefone.Name = "text_telefone";
            // 
            // text_email
            // 
            resources.ApplyResources(this.text_email, "text_email");
            this.text_email.Name = "text_email";
            // 
            // text_senha
            // 
            resources.ApplyResources(this.text_senha, "text_senha");
            this.text_senha.Name = "text_senha";
            // 
            // text_userName
            // 
            resources.ApplyResources(this.text_userName, "text_userName");
            this.text_userName.Name = "text_userName";
            // 
            // text_nome
            // 
            resources.ApplyResources(this.text_nome, "text_nome");
            this.text_nome.Name = "text_nome";
            // 
            // text_id
            // 
            resources.ApplyResources(this.text_id, "text_id");
            this.text_id.Name = "text_id";
            this.text_id.ReadOnly = true;
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // Form_gestaoDeUsuario
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel_botoes);
            this.Controls.Add(this.panel_rodape);
            this.Name = "Form_gestaoDeUsuario";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form_gestaoDeUsuario_Load);
            this.panel_rodape.ResumeLayout(false);
            this.panel_rodape.PerformLayout();
            this.panel_botoes.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_usuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_rodape;
        private System.Windows.Forms.Label label_data;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label_usuario;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_versao;
        private System.Windows.Forms.Panel panel_botoes;
        private System.Windows.Forms.Button btn_novo;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridView_usuario;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox text_id;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox text_userName;
        private System.Windows.Forms.TextBox text_nome;
        private System.Windows.Forms.TextBox text_email;
        private System.Windows.Forms.TextBox text_senha;
        private System.Windows.Forms.MaskedTextBox text_telefone;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.ComboBox comboBox_tipo;
    }
}
namespace Sistema_MaterialContrucao.Views
{
    partial class Form_gestaoDeCliente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridView_Cliente = new System.Windows.Forms.DataGridView();
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
            this.panel_botoes = new System.Windows.Forms.Panel();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_novo = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.panel_rodape = new System.Windows.Forms.Panel();
            this.label_data = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_usuario = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_versao = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Cliente)).BeginInit();
            this.panel_botoes.SuspendLayout();
            this.panel_rodape.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView_Cliente);
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
            this.splitContainer1.Size = new System.Drawing.Size(816, 429);
            this.splitContainer1.SplitterDistance = 422;
            this.splitContainer1.TabIndex = 14;
            // 
            // dataGridView_Cliente
            // 
            this.dataGridView_Cliente.AllowUserToAddRows = false;
            this.dataGridView_Cliente.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Cliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_Cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Cliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Cliente.EnableHeadersVisualStyles = false;
            this.dataGridView_Cliente.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_Cliente.MultiSelect = false;
            this.dataGridView_Cliente.Name = "dataGridView_Cliente";
            this.dataGridView_Cliente.ReadOnly = true;
            this.dataGridView_Cliente.RowHeadersVisible = false;
            this.dataGridView_Cliente.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView_Cliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Cliente.Size = new System.Drawing.Size(422, 429);
            this.dataGridView_Cliente.TabIndex = 3;
            this.dataGridView_Cliente.TabStop = false;
            // 
            // comboBox_tipo
            // 
            this.comboBox_tipo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_tipo.Enabled = false;
            this.comboBox_tipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBox_tipo.FormattingEnabled = true;
            this.comboBox_tipo.Items.AddRange(new object[] {
            "1 - Vendedor",
            "2 - Gerente",
            "3 - Administrador"});
            this.comboBox_tipo.Location = new System.Drawing.Point(51, 173);
            this.comboBox_tipo.Name = "comboBox_tipo";
            this.comboBox_tipo.Size = new System.Drawing.Size(333, 28);
            this.comboBox_tipo.TabIndex = 5;
            // 
            // text_telefone
            // 
            this.text_telefone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.text_telefone.Enabled = false;
            this.text_telefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.text_telefone.Location = new System.Drawing.Point(91, 96);
            this.text_telefone.Mask = "(00) 0 0000 0000";
            this.text_telefone.Name = "text_telefone";
            this.text_telefone.Size = new System.Drawing.Size(293, 26);
            this.text_telefone.TabIndex = 3;
            // 
            // text_email
            // 
            this.text_email.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.text_email.Enabled = false;
            this.text_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.text_email.Location = new System.Drawing.Point(67, 253);
            this.text_email.Name = "text_email";
            this.text_email.Size = new System.Drawing.Size(317, 26);
            this.text_email.TabIndex = 7;
            // 
            // text_senha
            // 
            this.text_senha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.text_senha.Enabled = false;
            this.text_senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.text_senha.Location = new System.Drawing.Point(67, 213);
            this.text_senha.Name = "text_senha";
            this.text_senha.Size = new System.Drawing.Size(317, 26);
            this.text_senha.TabIndex = 6;
            // 
            // text_userName
            // 
            this.text_userName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.text_userName.Enabled = false;
            this.text_userName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.text_userName.Location = new System.Drawing.Point(101, 133);
            this.text_userName.Name = "text_userName";
            this.text_userName.Size = new System.Drawing.Size(283, 26);
            this.text_userName.TabIndex = 4;
            // 
            // text_nome
            // 
            this.text_nome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.text_nome.Enabled = false;
            this.text_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.text_nome.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.text_nome.Location = new System.Drawing.Point(67, 55);
            this.text_nome.Name = "text_nome";
            this.text_nome.Size = new System.Drawing.Size(317, 26);
            this.text_nome.TabIndex = 2;
            // 
            // text_id
            // 
            this.text_id.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.text_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.text_id.Location = new System.Drawing.Point(39, 13);
            this.text_id.Name = "text_id";
            this.text_id.ReadOnly = true;
            this.text_id.Size = new System.Drawing.Size(193, 26);
            this.text_id.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label10.Location = new System.Drawing.Point(-6, 253);
            this.label10.Margin = new System.Windows.Forms.Padding(10);
            this.label10.Name = "label10";
            this.label10.Padding = new System.Windows.Forms.Padding(10);
            this.label10.Size = new System.Drawing.Size(72, 40);
            this.label10.TabIndex = 16;
            this.label10.Text = "Email:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(-6, 213);
            this.label5.Margin = new System.Windows.Forms.Padding(10);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(10);
            this.label5.Size = new System.Drawing.Size(80, 40);
            this.label5.TabIndex = 14;
            this.label5.Text = "Senha:";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(-6, 173);
            this.label9.Margin = new System.Windows.Forms.Padding(10);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(10);
            this.label9.Size = new System.Drawing.Size(63, 40);
            this.label9.TabIndex = 13;
            this.label9.Text = "Tipo:";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(-6, 133);
            this.label8.Margin = new System.Windows.Forms.Padding(10);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(10);
            this.label8.Size = new System.Drawing.Size(109, 40);
            this.label8.TabIndex = 12;
            this.label8.Text = "UserName:";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(-6, 93);
            this.label7.Margin = new System.Windows.Forms.Padding(10);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(10);
            this.label7.Size = new System.Drawing.Size(95, 40);
            this.label7.TabIndex = 11;
            this.label7.Text = "Telefone:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(-6, 53);
            this.label6.Margin = new System.Windows.Forms.Padding(10);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(10);
            this.label6.Size = new System.Drawing.Size(75, 40);
            this.label6.TabIndex = 10;
            this.label6.Text = "Nome:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(-6, 13);
            this.label4.Margin = new System.Windows.Forms.Padding(10);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(10);
            this.label4.Size = new System.Drawing.Size(47, 40);
            this.label4.TabIndex = 9;
            this.label4.Text = "Id:";
            // 
            // panel_botoes
            // 
            this.panel_botoes.Controls.Add(this.btn_editar);
            this.panel_botoes.Controls.Add(this.btn_novo);
            this.panel_botoes.Controls.Add(this.btn_sair);
            this.panel_botoes.Controls.Add(this.btn_excluir);
            this.panel_botoes.Controls.Add(this.btn_cancelar);
            this.panel_botoes.Controls.Add(this.btn_salvar);
            this.panel_botoes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_botoes.Location = new System.Drawing.Point(0, 429);
            this.panel_botoes.Name = "panel_botoes";
            this.panel_botoes.Size = new System.Drawing.Size(816, 31);
            this.panel_botoes.TabIndex = 13;
            // 
            // btn_editar
            // 
            this.btn_editar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_editar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_editar.Location = new System.Drawing.Point(496, 0);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(124, 31);
            this.btn_editar.TabIndex = 5;
            this.btn_editar.Text = "Editar Usuário";
            this.btn_editar.UseVisualStyleBackColor = true;
            // 
            // btn_novo
            // 
            this.btn_novo.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_novo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_novo.Location = new System.Drawing.Point(372, 0);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(124, 31);
            this.btn_novo.TabIndex = 4;
            this.btn_novo.Text = "Novo Usuário";
            this.btn_novo.UseVisualStyleBackColor = true;
            // 
            // btn_sair
            // 
            this.btn_sair.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_sair.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_sair.Location = new System.Drawing.Point(692, 0);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(124, 31);
            this.btn_sair.TabIndex = 3;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = true;
            // 
            // btn_excluir
            // 
            this.btn_excluir.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_excluir.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_excluir.Location = new System.Drawing.Point(248, 0);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(124, 31);
            this.btn_excluir.TabIndex = 2;
            this.btn_excluir.Text = "Excluir Usuário";
            this.btn_excluir.UseVisualStyleBackColor = true;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_cancelar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_cancelar.Location = new System.Drawing.Point(124, 0);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(124, 31);
            this.btn_cancelar.TabIndex = 1;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // btn_salvar
            // 
            this.btn_salvar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_salvar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_salvar.Location = new System.Drawing.Point(0, 0);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(124, 31);
            this.btn_salvar.TabIndex = 0;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = true;
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
            this.panel_rodape.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_rodape.Location = new System.Drawing.Point(0, 460);
            this.panel_rodape.Name = "panel_rodape";
            this.panel_rodape.Size = new System.Drawing.Size(816, 23);
            this.panel_rodape.TabIndex = 12;
            // 
            // label_data
            // 
            this.label_data.AutoSize = true;
            this.label_data.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_data.Location = new System.Drawing.Point(161, 3);
            this.label_data.Margin = new System.Windows.Forms.Padding(3);
            this.label_data.Name = "label_data";
            this.label_data.Size = new System.Drawing.Size(40, 13);
            this.label_data.TabIndex = 6;
            this.label_data.Text = "##/##";
            this.label_data.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(122, 3);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Data:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_usuario
            // 
            this.label_usuario.AutoSize = true;
            this.label_usuario.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_usuario.Location = new System.Drawing.Point(42, 3);
            this.label_usuario.Margin = new System.Windows.Forms.Padding(3);
            this.label_usuario.Name = "label_usuario";
            this.label_usuario.Size = new System.Drawing.Size(35, 13);
            this.label_usuario.TabIndex = 4;
            this.label_usuario.Text = "####";
            this.label_usuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(0, 3);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Usuário:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Version:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_versao
            // 
            this.label_versao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_versao.AutoSize = true;
            this.label_versao.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_versao.Location = new System.Drawing.Point(768, 3);
            this.label_versao.Margin = new System.Windows.Forms.Padding(3);
            this.label_versao.Name = "label_versao";
            this.label_versao.Size = new System.Drawing.Size(42, 13);
            this.label_versao.TabIndex = 1;
            this.label_versao.Text = "#####";
            this.label_versao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form_gestaoDeCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 483);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel_botoes);
            this.Controls.Add(this.panel_rodape);
            this.Name = "Form_gestaoDeCliente";
            this.Text = "Gestçao de Clientes";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Cliente)).EndInit();
            this.panel_botoes.ResumeLayout(false);
            this.panel_rodape.ResumeLayout(false);
            this.panel_rodape.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridView_Cliente;
        private System.Windows.Forms.ComboBox comboBox_tipo;
        private System.Windows.Forms.MaskedTextBox text_telefone;
        private System.Windows.Forms.TextBox text_email;
        private System.Windows.Forms.TextBox text_senha;
        private System.Windows.Forms.TextBox text_userName;
        private System.Windows.Forms.TextBox text_nome;
        private System.Windows.Forms.TextBox text_id;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel_botoes;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_novo;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Panel panel_rodape;
        private System.Windows.Forms.Label label_data;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label_usuario;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_versao;
    }
}
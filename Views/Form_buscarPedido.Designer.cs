namespace Sistema_MaterialContrucao.Views
{
    partial class Form_buscarPedido
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_cliente = new System.Windows.Forms.ComboBox();
            this.panel_botoes = new System.Windows.Forms.Panel();
            this.btn_enviarPorEmail = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_imprimir = new System.Windows.Forms.Button();
            this.label_data = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_usuario = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel_rodape = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label_versao = new System.Windows.Forms.Label();
            this.dataGridView_Pedido = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel_botoes.SuspendLayout();
            this.panel_rodape.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Pedido)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cliente:";
            // 
            // comboBox_cliente
            // 
            this.comboBox_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_cliente.FormattingEnabled = true;
            this.comboBox_cliente.Location = new System.Drawing.Point(99, 24);
            this.comboBox_cliente.Name = "comboBox_cliente";
            this.comboBox_cliente.Size = new System.Drawing.Size(360, 28);
            this.comboBox_cliente.TabIndex = 2;
            this.comboBox_cliente.TextChanged += new System.EventHandler(this.comboBox_cliente_TextChanged);
            // 
            // panel_botoes
            // 
            this.panel_botoes.Controls.Add(this.btn_enviarPorEmail);
            this.panel_botoes.Controls.Add(this.btn_sair);
            this.panel_botoes.Controls.Add(this.btn_cancelar);
            this.panel_botoes.Controls.Add(this.btn_imprimir);
            this.panel_botoes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_botoes.Location = new System.Drawing.Point(0, 381);
            this.panel_botoes.Name = "panel_botoes";
            this.panel_botoes.Size = new System.Drawing.Size(639, 31);
            this.panel_botoes.TabIndex = 16;
            // 
            // btn_enviarPorEmail
            // 
            this.btn_enviarPorEmail.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_enviarPorEmail.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_enviarPorEmail.Location = new System.Drawing.Point(248, 0);
            this.btn_enviarPorEmail.Name = "btn_enviarPorEmail";
            this.btn_enviarPorEmail.Size = new System.Drawing.Size(124, 31);
            this.btn_enviarPorEmail.TabIndex = 5;
            this.btn_enviarPorEmail.Text = "Enviar por email";
            this.btn_enviarPorEmail.UseVisualStyleBackColor = true;
            // 
            // btn_sair
            // 
            this.btn_sair.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_sair.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_sair.Location = new System.Drawing.Point(515, 0);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(124, 31);
            this.btn_sair.TabIndex = 3;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
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
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_imprimir.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_imprimir.Location = new System.Drawing.Point(0, 0);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(124, 31);
            this.btn_imprimir.TabIndex = 0;
            this.btn_imprimir.Text = "Imprimir";
            this.btn_imprimir.UseVisualStyleBackColor = true;
            this.btn_imprimir.Click += new System.EventHandler(this.btn_imprimir_Click);
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
            this.panel_rodape.Location = new System.Drawing.Point(0, 412);
            this.panel_rodape.Name = "panel_rodape";
            this.panel_rodape.Size = new System.Drawing.Size(639, 23);
            this.panel_rodape.TabIndex = 15;
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
            this.label_versao.Location = new System.Drawing.Point(591, 3);
            this.label_versao.Margin = new System.Windows.Forms.Padding(3);
            this.label_versao.Name = "label_versao";
            this.label_versao.Size = new System.Drawing.Size(42, 13);
            this.label_versao.TabIndex = 1;
            this.label_versao.Text = "#####";
            this.label_versao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView_Pedido
            // 
            this.dataGridView_Pedido.AllowUserToAddRows = false;
            this.dataGridView_Pedido.AllowUserToDeleteRows = false;
            this.dataGridView_Pedido.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Pedido.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_Pedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Pedido.EnableHeadersVisualStyles = false;
            this.dataGridView_Pedido.Location = new System.Drawing.Point(0, 58);
            this.dataGridView_Pedido.MultiSelect = false;
            this.dataGridView_Pedido.Name = "dataGridView_Pedido";
            this.dataGridView_Pedido.ReadOnly = true;
            this.dataGridView_Pedido.RowHeadersVisible = false;
            this.dataGridView_Pedido.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView_Pedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Pedido.Size = new System.Drawing.Size(639, 318);
            this.dataGridView_Pedido.TabIndex = 17;
            this.dataGridView_Pedido.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 60000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form_buscarPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 435);
            this.Controls.Add(this.dataGridView_Pedido);
            this.Controls.Add(this.panel_botoes);
            this.Controls.Add(this.panel_rodape);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox_cliente);
            this.Name = "Form_buscarPedido";
            this.Text = "Pedidos";
            this.Load += new System.EventHandler(this.Form_buscarPedido_Load);
            this.panel_botoes.ResumeLayout(false);
            this.panel_rodape.ResumeLayout(false);
            this.panel_rodape.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Pedido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_cliente;
        private System.Windows.Forms.Panel panel_botoes;
        private System.Windows.Forms.Button btn_enviarPorEmail;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_imprimir;
        private System.Windows.Forms.Label label_data;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label_usuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel_rodape;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_versao;
        private System.Windows.Forms.DataGridView dataGridView_Pedido;
        private System.Windows.Forms.Timer timer1;
    }
}
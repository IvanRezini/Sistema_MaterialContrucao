namespace Sistema_MaterialContrucao.Views
{
    partial class Form_entradaNoEstoque
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
            this.panel_botoes = new System.Windows.Forms.Panel();
            this.btn_sair = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.panel_rodape = new System.Windows.Forms.Panel();
            this.label_data = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_usuario = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_versao = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridView_Produto = new System.Windows.Forms.DataGridView();
            this.text_lucro = new System.Windows.Forms.TextBox();
            this.text_novaMargemLucro = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.text_entrada = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.text_valor = new System.Windows.Forms.TextBox();
            this.text_novoValor = new System.Windows.Forms.TextBox();
            this.text_desc = new System.Windows.Forms.TextBox();
            this.text_quantia = new System.Windows.Forms.TextBox();
            this.text_produto = new System.Windows.Forms.TextBox();
            this.text_id = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel_botoes.SuspendLayout();
            this.panel_rodape.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Produto)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_botoes
            // 
            this.panel_botoes.Controls.Add(this.btn_sair);
            this.panel_botoes.Controls.Add(this.btn_cancelar);
            this.panel_botoes.Controls.Add(this.btn_salvar);
            this.panel_botoes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_botoes.Location = new System.Drawing.Point(0, 427);
            this.panel_botoes.Name = "panel_botoes";
            this.panel_botoes.Size = new System.Drawing.Size(850, 31);
            this.panel_botoes.TabIndex = 4;
            // 
            // btn_sair
            // 
            this.btn_sair.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_sair.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_sair.Location = new System.Drawing.Point(726, 0);
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
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
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
            this.panel_rodape.Location = new System.Drawing.Point(0, 458);
            this.panel_rodape.Name = "panel_rodape";
            this.panel_rodape.Size = new System.Drawing.Size(850, 23);
            this.panel_rodape.TabIndex = 3;
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
            this.label_versao.Location = new System.Drawing.Point(802, 3);
            this.label_versao.Margin = new System.Windows.Forms.Padding(3);
            this.label_versao.Name = "label_versao";
            this.label_versao.Size = new System.Drawing.Size(42, 13);
            this.label_versao.TabIndex = 1;
            this.label_versao.Text = "#####";
            this.label_versao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView_Produto);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.text_lucro);
            this.splitContainer1.Panel2.Controls.Add(this.text_novaMargemLucro);
            this.splitContainer1.Panel2.Controls.Add(this.label10);
            this.splitContainer1.Panel2.Controls.Add(this.label12);
            this.splitContainer1.Panel2.Controls.Add(this.text_entrada);
            this.splitContainer1.Panel2.Controls.Add(this.label11);
            this.splitContainer1.Panel2.Controls.Add(this.text_valor);
            this.splitContainer1.Panel2.Controls.Add(this.text_novoValor);
            this.splitContainer1.Panel2.Controls.Add(this.text_desc);
            this.splitContainer1.Panel2.Controls.Add(this.text_quantia);
            this.splitContainer1.Panel2.Controls.Add(this.text_produto);
            this.splitContainer1.Panel2.Controls.Add(this.text_id);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.label9);
            this.splitContainer1.Panel2.Controls.Add(this.label8);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Size = new System.Drawing.Size(850, 427);
            this.splitContainer1.SplitterDistance = 431;
            this.splitContainer1.TabIndex = 12;
            // 
            // dataGridView_Produto
            // 
            this.dataGridView_Produto.AllowUserToAddRows = false;
            this.dataGridView_Produto.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Produto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_Produto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Produto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Produto.EnableHeadersVisualStyles = false;
            this.dataGridView_Produto.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_Produto.MultiSelect = false;
            this.dataGridView_Produto.Name = "dataGridView_Produto";
            this.dataGridView_Produto.ReadOnly = true;
            this.dataGridView_Produto.RowHeadersVisible = false;
            this.dataGridView_Produto.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView_Produto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Produto.Size = new System.Drawing.Size(431, 427);
            this.dataGridView_Produto.TabIndex = 3;
            this.dataGridView_Produto.TabStop = false;
            this.dataGridView_Produto.SelectionChanged += new System.EventHandler(this.dataGridView_Produto_SelectionChanged);
            // 
            // text_lucro
            // 
            this.text_lucro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_lucro.Location = new System.Drawing.Point(65, 280);
            this.text_lucro.Name = "text_lucro";
            this.text_lucro.ReadOnly = true;
            this.text_lucro.Size = new System.Drawing.Size(99, 26);
            this.text_lucro.TabIndex = 24;
            // 
            // text_novaMargemLucro
            // 
            this.text_novaMargemLucro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.text_novaMargemLucro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.text_novaMargemLucro.Location = new System.Drawing.Point(219, 322);
            this.text_novaMargemLucro.Name = "text_novaMargemLucro";
            this.text_novaMargemLucro.Size = new System.Drawing.Size(155, 26);
            this.text_novaMargemLucro.TabIndex = 21;
            this.text_novaMargemLucro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_novaMargemLucro_KeyPress);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label10.Location = new System.Drawing.Point(9, 322);
            this.label10.Margin = new System.Windows.Forms.Padding(10);
            this.label10.Name = "label10";
            this.label10.Padding = new System.Windows.Forms.Padding(3);
            this.label10.Size = new System.Drawing.Size(213, 26);
            this.label10.TabIndex = 23;
            this.label10.Text = "Nova porcentagem de lucro:";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label12.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label12.Location = new System.Drawing.Point(7, 283);
            this.label12.Margin = new System.Windows.Forms.Padding(10);
            this.label12.Name = "label12";
            this.label12.Padding = new System.Windows.Forms.Padding(3);
            this.label12.Size = new System.Drawing.Size(59, 26);
            this.label12.TabIndex = 22;
            this.label12.Text = "Lucro:";
            // 
            // text_entrada
            // 
            this.text_entrada.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.text_entrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.text_entrada.Location = new System.Drawing.Point(208, 199);
            this.text_entrada.Name = "text_entrada";
            this.text_entrada.Size = new System.Drawing.Size(201, 26);
            this.text_entrada.TabIndex = 5;
            this.text_entrada.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_entrada_KeyPress);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label11.Location = new System.Drawing.Point(9, 199);
            this.label11.Margin = new System.Windows.Forms.Padding(10);
            this.label11.Name = "label11";
            this.label11.Padding = new System.Windows.Forms.Padding(3);
            this.label11.Size = new System.Drawing.Size(201, 26);
            this.label11.TabIndex = 20;
            this.label11.Text = "Quantidade a dar entrada:";
            // 
            // text_valor
            // 
            this.text_valor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_valor.Location = new System.Drawing.Point(65, 238);
            this.text_valor.Name = "text_valor";
            this.text_valor.ReadOnly = true;
            this.text_valor.Size = new System.Drawing.Size(99, 26);
            this.text_valor.TabIndex = 18;
            // 
            // text_novoValor
            // 
            this.text_novoValor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.text_novoValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.text_novoValor.Location = new System.Drawing.Point(255, 238);
            this.text_novoValor.Name = "text_novoValor";
            this.text_novoValor.Size = new System.Drawing.Size(155, 26);
            this.text_novoValor.TabIndex = 6;
            this.text_novoValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_novoValor_KeyPress);
            // 
            // text_desc
            // 
            this.text_desc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.text_desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.text_desc.Location = new System.Drawing.Point(96, 83);
            this.text_desc.Multiline = true;
            this.text_desc.Name = "text_desc";
            this.text_desc.ReadOnly = true;
            this.text_desc.Size = new System.Drawing.Size(316, 64);
            this.text_desc.TabIndex = 6;
            // 
            // text_quantia
            // 
            this.text_quantia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.text_quantia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.text_quantia.Location = new System.Drawing.Point(198, 160);
            this.text_quantia.Name = "text_quantia";
            this.text_quantia.ReadOnly = true;
            this.text_quantia.Size = new System.Drawing.Size(214, 26);
            this.text_quantia.TabIndex = 4;
            // 
            // text_produto
            // 
            this.text_produto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.text_produto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.text_produto.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.text_produto.Location = new System.Drawing.Point(86, 51);
            this.text_produto.Name = "text_produto";
            this.text_produto.ReadOnly = true;
            this.text_produto.Size = new System.Drawing.Size(326, 26);
            this.text_produto.TabIndex = 2;
            // 
            // text_id
            // 
            this.text_id.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.text_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.text_id.Location = new System.Drawing.Point(77, 12);
            this.text_id.Name = "text_id";
            this.text_id.ReadOnly = true;
            this.text_id.Size = new System.Drawing.Size(193, 26);
            this.text_id.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(167, 238);
            this.label5.Margin = new System.Windows.Forms.Padding(10);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(3);
            this.label5.Size = new System.Drawing.Size(92, 26);
            this.label5.TabIndex = 14;
            this.label5.Text = "Novo valor:";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(7, 241);
            this.label9.Margin = new System.Windows.Forms.Padding(10);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(3);
            this.label9.Size = new System.Drawing.Size(56, 26);
            this.label9.TabIndex = 13;
            this.label9.Text = "Valor:";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(9, 160);
            this.label8.Margin = new System.Windows.Forms.Padding(10);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(3);
            this.label8.Size = new System.Drawing.Size(190, 26);
            this.label8.TabIndex = 12;
            this.label8.Text = "Quantidade em estoque:";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(9, 90);
            this.label7.Margin = new System.Windows.Forms.Padding(10);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(3);
            this.label7.Size = new System.Drawing.Size(90, 26);
            this.label7.TabIndex = 11;
            this.label7.Text = "Descrição:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(9, 51);
            this.label6.Margin = new System.Windows.Forms.Padding(10);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(3);
            this.label6.Size = new System.Drawing.Size(75, 26);
            this.label6.TabIndex = 10;
            this.label6.Text = "Produto:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(9, 12);
            this.label4.Margin = new System.Windows.Forms.Padding(10);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(3);
            this.label4.Size = new System.Drawing.Size(69, 26);
            this.label4.TabIndex = 9;
            this.label4.Text = "Codigo:";
            // 
            // Form_entradaNoEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 481);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel_botoes);
            this.Controls.Add(this.panel_rodape);
            this.Name = "Form_entradaNoEstoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entrda no estoque";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form_entradaNoEstoque_Load);
            this.panel_botoes.ResumeLayout(false);
            this.panel_rodape.ResumeLayout(false);
            this.panel_rodape.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Produto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_botoes;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Panel panel_rodape;
        private System.Windows.Forms.Label label_data;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label_usuario;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_versao;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridView_Produto;
        private System.Windows.Forms.TextBox text_novoValor;
        private System.Windows.Forms.TextBox text_desc;
        private System.Windows.Forms.TextBox text_quantia;
        private System.Windows.Forms.TextBox text_produto;
        private System.Windows.Forms.TextBox text_id;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox text_valor;
        private System.Windows.Forms.TextBox text_entrada;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox text_lucro;
        private System.Windows.Forms.TextBox text_novaMargemLucro;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
    }
}
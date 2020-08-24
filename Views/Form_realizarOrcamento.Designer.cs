namespace Sistema_MaterialContrucao.Views
{
    partial class Form_realizarOrcamento
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.label_pedido = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_cliente = new System.Windows.Forms.ComboBox();
            this.dataGridView_Produto = new System.Windows.Forms.DataGridView();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.btn_proximoProduto = new System.Windows.Forms.Button();
            this.text_quantiaPedido = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.text_valor = new System.Windows.Forms.TextBox();
            this.text_desc = new System.Windows.Forms.TextBox();
            this.text_quantia = new System.Windows.Forms.TextBox();
            this.text_produto = new System.Windows.Forms.TextBox();
            this.text_id = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.dataGridView_pedido = new System.Windows.Forms.DataGridView();
            this.text_totalComDesconto = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.text_total = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.text_desconto = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel_botoes = new System.Windows.Forms.Panel();
            this.btn_enviarPorEmail = new System.Windows.Forms.Button();
            this.btn_imprimir = new System.Windows.Forms.Button();
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Produto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_pedido)).BeginInit();
            this.panel_botoes.SuspendLayout();
            this.panel_rodape.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer1.Size = new System.Drawing.Size(1046, 558);
            this.splitContainer1.SplitterDistance = 419;
            this.splitContainer1.TabIndex = 15;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.label_pedido);
            this.splitContainer2.Panel1.Controls.Add(this.label5);
            this.splitContainer2.Panel1.Controls.Add(this.label4);
            this.splitContainer2.Panel1.Controls.Add(this.comboBox_cliente);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dataGridView_Produto);
            this.splitContainer2.Size = new System.Drawing.Size(419, 558);
            this.splitContainer2.SplitterDistance = 137;
            this.splitContainer2.TabIndex = 0;
            // 
            // label_pedido
            // 
            this.label_pedido.AutoSize = true;
            this.label_pedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pedido.Location = new System.Drawing.Point(82, 15);
            this.label_pedido.Name = "label_pedido";
            this.label_pedido.Size = new System.Drawing.Size(50, 24);
            this.label_pedido.TabIndex = 3;
            this.label_pedido.Text = "0000";
            this.label_pedido.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 24);
            this.label5.TabIndex = 2;
            this.label5.Text = "Pedido:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "Cliente:";
            // 
            // comboBox_cliente
            // 
            this.comboBox_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_cliente.FormattingEnabled = true;
            this.comboBox_cliente.Location = new System.Drawing.Point(96, 46);
            this.comboBox_cliente.Name = "comboBox_cliente";
            this.comboBox_cliente.Size = new System.Drawing.Size(201, 28);
            this.comboBox_cliente.TabIndex = 0;
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
            this.dataGridView_Produto.Size = new System.Drawing.Size(419, 417);
            this.dataGridView_Produto.TabIndex = 1;
            this.dataGridView_Produto.TabStop = false;
            this.dataGridView_Produto.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Produto_CellDoubleClick);
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.btn_proximoProduto);
            this.splitContainer3.Panel1.Controls.Add(this.text_quantiaPedido);
            this.splitContainer3.Panel1.Controls.Add(this.label11);
            this.splitContainer3.Panel1.Controls.Add(this.text_valor);
            this.splitContainer3.Panel1.Controls.Add(this.text_desc);
            this.splitContainer3.Panel1.Controls.Add(this.text_quantia);
            this.splitContainer3.Panel1.Controls.Add(this.text_produto);
            this.splitContainer3.Panel1.Controls.Add(this.text_id);
            this.splitContainer3.Panel1.Controls.Add(this.label9);
            this.splitContainer3.Panel1.Controls.Add(this.label8);
            this.splitContainer3.Panel1.Controls.Add(this.label7);
            this.splitContainer3.Panel1.Controls.Add(this.label6);
            this.splitContainer3.Panel1.Controls.Add(this.label10);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.splitContainer4);
            this.splitContainer3.Size = new System.Drawing.Size(623, 558);
            this.splitContainer3.SplitterDistance = 220;
            this.splitContainer3.TabIndex = 0;
            // 
            // btn_proximoProduto
            // 
            this.btn_proximoProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_proximoProduto.Location = new System.Drawing.Point(406, 166);
            this.btn_proximoProduto.Name = "btn_proximoProduto";
            this.btn_proximoProduto.Size = new System.Drawing.Size(75, 27);
            this.btn_proximoProduto.TabIndex = 33;
            this.btn_proximoProduto.Text = "Proximo";
            this.btn_proximoProduto.UseVisualStyleBackColor = true;
            this.btn_proximoProduto.Click += new System.EventHandler(this.btn_proximoProduto_Click);
            // 
            // text_quantiaPedido
            // 
            this.text_quantiaPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.text_quantiaPedido.Location = new System.Drawing.Point(168, 167);
            this.text_quantiaPedido.Name = "text_quantiaPedido";
            this.text_quantiaPedido.Size = new System.Drawing.Size(149, 26);
            this.text_quantiaPedido.TabIndex = 2;
            this.text_quantiaPedido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_quantiaPedido_KeyPress);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label11.Location = new System.Drawing.Point(-4, 167);
            this.label11.Margin = new System.Windows.Forms.Padding(10);
            this.label11.Name = "label11";
            this.label11.Padding = new System.Windows.Forms.Padding(3);
            this.label11.Size = new System.Drawing.Size(176, 26);
            this.label11.TabIndex = 32;
            this.label11.Text = "Quantidade do pedido:";
            // 
            // text_valor
            // 
            this.text_valor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.text_valor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_valor.Location = new System.Drawing.Point(397, 128);
            this.text_valor.Name = "text_valor";
            this.text_valor.ReadOnly = true;
            this.text_valor.Size = new System.Drawing.Size(181, 26);
            this.text_valor.TabIndex = 31;
            // 
            // text_desc
            // 
            this.text_desc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.text_desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.text_desc.Location = new System.Drawing.Point(94, 54);
            this.text_desc.Multiline = true;
            this.text_desc.Name = "text_desc";
            this.text_desc.ReadOnly = true;
            this.text_desc.Size = new System.Drawing.Size(526, 62);
            this.text_desc.TabIndex = 25;
            // 
            // text_quantia
            // 
            this.text_quantia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.text_quantia.Location = new System.Drawing.Point(190, 128);
            this.text_quantia.Name = "text_quantia";
            this.text_quantia.ReadOnly = true;
            this.text_quantia.Size = new System.Drawing.Size(137, 26);
            this.text_quantia.TabIndex = 23;
            // 
            // text_produto
            // 
            this.text_produto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.text_produto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.text_produto.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.text_produto.Location = new System.Drawing.Point(245, 15);
            this.text_produto.Name = "text_produto";
            this.text_produto.ReadOnly = true;
            this.text_produto.Size = new System.Drawing.Size(375, 26);
            this.text_produto.TabIndex = 22;
            // 
            // text_id
            // 
            this.text_id.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.text_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.text_id.Location = new System.Drawing.Point(69, 15);
            this.text_id.Name = "text_id";
            this.text_id.ReadOnly = true;
            this.text_id.Size = new System.Drawing.Size(92, 26);
            this.text_id.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(342, 128);
            this.label9.Margin = new System.Windows.Forms.Padding(10);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(3);
            this.label9.Size = new System.Drawing.Size(56, 26);
            this.label9.TabIndex = 30;
            this.label9.Text = "Valor:";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(1, 128);
            this.label8.Margin = new System.Windows.Forms.Padding(10);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(3);
            this.label8.Size = new System.Drawing.Size(190, 26);
            this.label8.TabIndex = 29;
            this.label8.Text = "Quantidade em estoque:";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(1, 54);
            this.label7.Margin = new System.Windows.Forms.Padding(10);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(3);
            this.label7.Size = new System.Drawing.Size(90, 26);
            this.label7.TabIndex = 28;
            this.label7.Text = "Descrição:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(174, 15);
            this.label6.Margin = new System.Windows.Forms.Padding(10);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(3);
            this.label6.Size = new System.Drawing.Size(75, 26);
            this.label6.TabIndex = 27;
            this.label6.Text = "Produto:";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label10.Location = new System.Drawing.Point(1, 15);
            this.label10.Margin = new System.Windows.Forms.Padding(10);
            this.label10.Name = "label10";
            this.label10.Padding = new System.Windows.Forms.Padding(3);
            this.label10.Size = new System.Drawing.Size(69, 26);
            this.label10.TabIndex = 26;
            this.label10.Text = "Codigo:";
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.dataGridView_pedido);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.text_totalComDesconto);
            this.splitContainer4.Panel2.Controls.Add(this.label14);
            this.splitContainer4.Panel2.Controls.Add(this.text_total);
            this.splitContainer4.Panel2.Controls.Add(this.label13);
            this.splitContainer4.Panel2.Controls.Add(this.text_desconto);
            this.splitContainer4.Panel2.Controls.Add(this.label12);
            this.splitContainer4.Size = new System.Drawing.Size(623, 334);
            this.splitContainer4.SplitterDistance = 398;
            this.splitContainer4.TabIndex = 0;
            // 
            // dataGridView_pedido
            // 
            this.dataGridView_pedido.AllowUserToAddRows = false;
            this.dataGridView_pedido.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_pedido.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_pedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_pedido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_pedido.EnableHeadersVisualStyles = false;
            this.dataGridView_pedido.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_pedido.MultiSelect = false;
            this.dataGridView_pedido.Name = "dataGridView_pedido";
            this.dataGridView_pedido.ReadOnly = true;
            this.dataGridView_pedido.RowHeadersVisible = false;
            this.dataGridView_pedido.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView_pedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_pedido.Size = new System.Drawing.Size(398, 334);
            this.dataGridView_pedido.TabIndex = 5;
            this.dataGridView_pedido.TabStop = false;
            this.dataGridView_pedido.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_pedido_CellDoubleClick);
            // 
            // text_totalComDesconto
            // 
            this.text_totalComDesconto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.text_totalComDesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_totalComDesconto.Location = new System.Drawing.Point(72, 107);
            this.text_totalComDesconto.Name = "text_totalComDesconto";
            this.text_totalComDesconto.ReadOnly = true;
            this.text_totalComDesconto.Size = new System.Drawing.Size(146, 26);
            this.text_totalComDesconto.TabIndex = 37;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label14.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label14.Location = new System.Drawing.Point(10, 107);
            this.label14.Margin = new System.Windows.Forms.Padding(10);
            this.label14.Name = "label14";
            this.label14.Padding = new System.Windows.Forms.Padding(3);
            this.label14.Size = new System.Drawing.Size(54, 26);
            this.label14.TabIndex = 36;
            this.label14.Text = "Total:";
            // 
            // text_total
            // 
            this.text_total.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.text_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_total.Location = new System.Drawing.Point(72, 30);
            this.text_total.Name = "text_total";
            this.text_total.ReadOnly = true;
            this.text_total.Size = new System.Drawing.Size(146, 26);
            this.text_total.TabIndex = 35;
            this.text_total.Text = "0";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label13.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label13.Location = new System.Drawing.Point(10, 30);
            this.label13.Margin = new System.Windows.Forms.Padding(10);
            this.label13.Name = "label13";
            this.label13.Padding = new System.Windows.Forms.Padding(3);
            this.label13.Size = new System.Drawing.Size(54, 26);
            this.label13.TabIndex = 34;
            this.label13.Text = "Total:";
            // 
            // text_desconto
            // 
            this.text_desconto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.text_desconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_desconto.Location = new System.Drawing.Point(72, 62);
            this.text_desconto.Name = "text_desconto";
            this.text_desconto.Size = new System.Drawing.Size(146, 26);
            this.text_desconto.TabIndex = 3;
            this.text_desconto.TextChanged += new System.EventHandler(this.text_desconto_TextChanged);
            this.text_desconto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_desconto_KeyPress);
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label12.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label12.Location = new System.Drawing.Point(10, 64);
            this.label12.Margin = new System.Windows.Forms.Padding(10);
            this.label12.Name = "label12";
            this.label12.Padding = new System.Windows.Forms.Padding(3);
            this.label12.Size = new System.Drawing.Size(60, 26);
            this.label12.TabIndex = 32;
            this.label12.Text = "Desc.:";
            // 
            // panel_botoes
            // 
            this.panel_botoes.Controls.Add(this.btn_enviarPorEmail);
            this.panel_botoes.Controls.Add(this.btn_imprimir);
            this.panel_botoes.Controls.Add(this.btn_sair);
            this.panel_botoes.Controls.Add(this.btn_cancelar);
            this.panel_botoes.Controls.Add(this.btn_salvar);
            this.panel_botoes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_botoes.Location = new System.Drawing.Point(0, 558);
            this.panel_botoes.Name = "panel_botoes";
            this.panel_botoes.Size = new System.Drawing.Size(1046, 31);
            this.panel_botoes.TabIndex = 14;
            // 
            // btn_enviarPorEmail
            // 
            this.btn_enviarPorEmail.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_enviarPorEmail.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_enviarPorEmail.Location = new System.Drawing.Point(372, 0);
            this.btn_enviarPorEmail.Name = "btn_enviarPorEmail";
            this.btn_enviarPorEmail.Size = new System.Drawing.Size(124, 31);
            this.btn_enviarPorEmail.TabIndex = 5;
            this.btn_enviarPorEmail.Text = "Enviar por email";
            this.btn_enviarPorEmail.UseVisualStyleBackColor = true;
            this.btn_enviarPorEmail.Click += new System.EventHandler(this.btn_enviarPorEmail_Click);
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_imprimir.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_imprimir.Location = new System.Drawing.Point(248, 0);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(124, 31);
            this.btn_imprimir.TabIndex = 4;
            this.btn_imprimir.Text = "Imprimir";
            this.btn_imprimir.UseVisualStyleBackColor = true;
            this.btn_imprimir.Click += new System.EventHandler(this.btn_imprimir_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_sair.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_sair.Location = new System.Drawing.Point(922, 0);
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
            this.panel_rodape.Location = new System.Drawing.Point(0, 589);
            this.panel_rodape.Name = "panel_rodape";
            this.panel_rodape.Size = new System.Drawing.Size(1046, 23);
            this.panel_rodape.TabIndex = 13;
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
            this.label_versao.Location = new System.Drawing.Point(998, 3);
            this.label_versao.Margin = new System.Windows.Forms.Padding(3);
            this.label_versao.Name = "label_versao";
            this.label_versao.Size = new System.Drawing.Size(42, 13);
            this.label_versao.TabIndex = 1;
            this.label_versao.Text = "#####";
            this.label_versao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 60000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form_realizarOrcamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 612);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel_botoes);
            this.Controls.Add(this.panel_rodape);
            this.Name = "Form_realizarOrcamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orçamento";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_realizarOrcamento_FormClosing);
            this.Load += new System.EventHandler(this.Form_realizarOrcamento_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Produto)).EndInit();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            this.splitContainer4.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_pedido)).EndInit();
            this.panel_botoes.ResumeLayout(false);
            this.panel_rodape.ResumeLayout(false);
            this.panel_rodape.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
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
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label label_pedido;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_cliente;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.DataGridView dataGridView_Produto;
        private System.Windows.Forms.TextBox text_quantiaPedido;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox text_valor;
        private System.Windows.Forms.TextBox text_desc;
        private System.Windows.Forms.TextBox text_quantia;
        private System.Windows.Forms.TextBox text_produto;
        private System.Windows.Forms.TextBox text_id;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_proximoProduto;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.DataGridView dataGridView_pedido;
        private System.Windows.Forms.TextBox text_totalComDesconto;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox text_total;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox text_desconto;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_enviarPorEmail;
        private System.Windows.Forms.Button btn_imprimir;
        private System.Windows.Forms.Timer timer1;
    }
}
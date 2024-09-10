namespace SysPecNSDesk
{
    partial class FrmPedidoNovo
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
            grb_Itens = new GroupBox();
            label10 = new Label();
            txt_ValorTotal = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            txt_Desconto = new TextBox();
            txt_Quantidade = new TextBox();
            btn_AddItem = new Button();
            txt_ValorUnit = new TextBox();
            txt_CodBar = new TextBox();
            txt_Descricao = new TextBox();
            dgv_ItensPedido = new DataGridView();
            clnSeq = new DataGridViewTextBoxColumn();
            clnCodBar = new DataGridViewTextBoxColumn();
            clnDescricao = new DataGridViewTextBoxColumn();
            clnValorUnit = new DataGridViewTextBoxColumn();
            clnQuantidade = new DataGridViewTextBoxColumn();
            clnDescontoItem = new DataGridViewTextBoxColumn();
            clnTotalItem = new DataGridViewTextBoxColumn();
            grb_Identificacao = new GroupBox();
            btn_Insere = new Button();
            txt_Cliente = new TextBox();
            txt_IdCliente = new TextBox();
            label4 = new Label();
            txt_Usuario = new TextBox();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            txt_IdPedido = new TextBox();
            txt_SubTotal = new TextBox();
            txt_DescontoItens = new TextBox();
            txt_DescontoPedido = new TextBox();
            txt_Total = new TextBox();
            btn_Fechar = new Button();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            grb_Itens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_ItensPedido).BeginInit();
            grb_Identificacao.SuspendLayout();
            SuspendLayout();
            // 
            // grb_Itens
            // 
            grb_Itens.BackColor = Color.White;
            grb_Itens.Controls.Add(label10);
            grb_Itens.Controls.Add(txt_ValorTotal);
            grb_Itens.Controls.Add(label9);
            grb_Itens.Controls.Add(label8);
            grb_Itens.Controls.Add(label7);
            grb_Itens.Controls.Add(label6);
            grb_Itens.Controls.Add(label5);
            grb_Itens.Controls.Add(txt_Desconto);
            grb_Itens.Controls.Add(txt_Quantidade);
            grb_Itens.Controls.Add(btn_AddItem);
            grb_Itens.Controls.Add(txt_ValorUnit);
            grb_Itens.Controls.Add(txt_CodBar);
            grb_Itens.Controls.Add(txt_Descricao);
            grb_Itens.Controls.Add(dgv_ItensPedido);
            grb_Itens.Enabled = false;
            grb_Itens.Location = new Point(22, 217);
            grb_Itens.Name = "grb_Itens";
            grb_Itens.Size = new Size(624, 303);
            grb_Itens.TabIndex = 0;
            grb_Itens.TabStop = false;
            grb_Itens.Text = "Itens do Pedido";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label10.Location = new Point(397, 264);
            label10.Name = "label10";
            label10.Size = new Size(110, 19);
            label10.TabIndex = 13;
            label10.Text = "Valor Total R$";
            // 
            // txt_ValorTotal
            // 
            txt_ValorTotal.Location = new Point(513, 260);
            txt_ValorTotal.Name = "txt_ValorTotal";
            txt_ValorTotal.ReadOnly = true;
            txt_ValorTotal.Size = new Size(100, 23);
            txt_ValorTotal.TabIndex = 12;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(408, 26);
            label9.Name = "label9";
            label9.Size = new Size(57, 15);
            label9.TabIndex = 11;
            label9.Text = "Desconto";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(329, 24);
            label8.Name = "label8";
            label8.Size = new Size(69, 15);
            label8.TabIndex = 10;
            label8.Text = "Quantidade";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(265, 24);
            label7.Name = "label7";
            label7.Size = new Size(58, 15);
            label7.TabIndex = 9;
            label7.Text = "Valor Unit";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(109, 24);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 8;
            label6.Text = "descrição";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 24);
            label5.Name = "label5";
            label5.Size = new Size(97, 15);
            label5.TabIndex = 7;
            label5.Text = "Código de Barras";
            // 
            // txt_Desconto
            // 
            txt_Desconto.Location = new Point(407, 42);
            txt_Desconto.Name = "txt_Desconto";
            txt_Desconto.RightToLeft = RightToLeft.Yes;
            txt_Desconto.Size = new Size(100, 23);
            txt_Desconto.TabIndex = 6;
            txt_Desconto.Text = "0";
            // 
            // txt_Quantidade
            // 
            txt_Quantidade.Location = new Point(330, 42);
            txt_Quantidade.Name = "txt_Quantidade";
            txt_Quantidade.RightToLeft = RightToLeft.Yes;
            txt_Quantidade.Size = new Size(71, 23);
            txt_Quantidade.TabIndex = 5;
            txt_Quantidade.Text = "1";
            // 
            // btn_AddItem
            // 
            btn_AddItem.Location = new Point(524, 26);
            btn_AddItem.Name = "btn_AddItem";
            btn_AddItem.Size = new Size(75, 41);
            btn_AddItem.TabIndex = 1;
            btn_AddItem.Text = "A&dicionar";
            btn_AddItem.UseVisualStyleBackColor = true;
            btn_AddItem.Click += btn_AddItem_Click;
            // 
            // txt_ValorUnit
            // 
            txt_ValorUnit.Location = new Point(265, 42);
            txt_ValorUnit.Name = "txt_ValorUnit";
            txt_ValorUnit.Size = new Size(59, 23);
            txt_ValorUnit.TabIndex = 4;
            // 
            // txt_CodBar
            // 
            txt_CodBar.Font = new Font("Arial", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txt_CodBar.Location = new Point(8, 42);
            txt_CodBar.Name = "txt_CodBar";
            txt_CodBar.Size = new Size(95, 25);
            txt_CodBar.TabIndex = 3;
            txt_CodBar.Leave += txt_CodBar_Leave;
            // 
            // txt_Descricao
            // 
            txt_Descricao.Location = new Point(109, 42);
            txt_Descricao.Name = "txt_Descricao";
            txt_Descricao.Size = new Size(148, 23);
            txt_Descricao.TabIndex = 2;
            // 
            // dgv_ItensPedido
            // 
            dgv_ItensPedido.AllowUserToAddRows = false;
            dgv_ItensPedido.AllowUserToDeleteRows = false;
            dgv_ItensPedido.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_ItensPedido.Columns.AddRange(new DataGridViewColumn[] { clnSeq, clnCodBar, clnDescricao, clnValorUnit, clnQuantidade, clnDescontoItem, clnTotalItem });
            dgv_ItensPedido.Location = new Point(4, 71);
            dgv_ItensPedido.Name = "dgv_ItensPedido";
            dgv_ItensPedido.ReadOnly = true;
            dgv_ItensPedido.RowHeadersVisible = false;
            dgv_ItensPedido.Size = new Size(620, 175);
            dgv_ItensPedido.TabIndex = 0;
            // 
            // clnSeq
            // 
            clnSeq.Frozen = true;
            clnSeq.HeaderText = "#SEQ";
            clnSeq.Name = "clnSeq";
            clnSeq.ReadOnly = true;
            clnSeq.Width = 40;
            // 
            // clnCodBar
            // 
            clnCodBar.Frozen = true;
            clnCodBar.HeaderText = "Cod Barras";
            clnCodBar.Name = "clnCodBar";
            clnCodBar.ReadOnly = true;
            clnCodBar.Width = 90;
            // 
            // clnDescricao
            // 
            clnDescricao.Frozen = true;
            clnDescricao.HeaderText = "Descrição";
            clnDescricao.Name = "clnDescricao";
            clnDescricao.ReadOnly = true;
            clnDescricao.Width = 150;
            // 
            // clnValorUnit
            // 
            clnValorUnit.Frozen = true;
            clnValorUnit.HeaderText = "Valor Unit";
            clnValorUnit.Name = "clnValorUnit";
            clnValorUnit.ReadOnly = true;
            clnValorUnit.Width = 90;
            // 
            // clnQuantidade
            // 
            clnQuantidade.Frozen = true;
            clnQuantidade.HeaderText = "Quant";
            clnQuantidade.Name = "clnQuantidade";
            clnQuantidade.ReadOnly = true;
            clnQuantidade.Width = 70;
            // 
            // clnDescontoItem
            // 
            clnDescontoItem.Frozen = true;
            clnDescontoItem.HeaderText = "Desconto";
            clnDescontoItem.Name = "clnDescontoItem";
            clnDescontoItem.ReadOnly = true;
            clnDescontoItem.Width = 70;
            // 
            // clnTotalItem
            // 
            clnTotalItem.Frozen = true;
            clnTotalItem.HeaderText = "Total";
            clnTotalItem.Name = "clnTotalItem";
            clnTotalItem.ReadOnly = true;
            clnTotalItem.Width = 90;
            // 
            // grb_Identificacao
            // 
            grb_Identificacao.BackColor = Color.White;
            grb_Identificacao.Controls.Add(btn_Insere);
            grb_Identificacao.Controls.Add(txt_Cliente);
            grb_Identificacao.Controls.Add(txt_IdCliente);
            grb_Identificacao.Controls.Add(label4);
            grb_Identificacao.Controls.Add(txt_Usuario);
            grb_Identificacao.Controls.Add(label3);
            grb_Identificacao.Location = new Point(22, 52);
            grb_Identificacao.Name = "grb_Identificacao";
            grb_Identificacao.Size = new Size(415, 159);
            grb_Identificacao.TabIndex = 0;
            grb_Identificacao.TabStop = false;
            grb_Identificacao.Text = "Identificação";
            // 
            // btn_Insere
            // 
            btn_Insere.Location = new Point(265, 114);
            btn_Insere.Name = "btn_Insere";
            btn_Insere.Size = new Size(75, 23);
            btn_Insere.TabIndex = 5;
            btn_Insere.Text = "&Abrir";
            btn_Insere.UseVisualStyleBackColor = true;
            btn_Insere.Click += btn_Insere_Click;
            // 
            // txt_Cliente
            // 
            txt_Cliente.Font = new Font("Arial", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txt_Cliente.Location = new Point(126, 76);
            txt_Cliente.Name = "txt_Cliente";
            txt_Cliente.Size = new Size(214, 21);
            txt_Cliente.TabIndex = 1;
            // 
            // txt_IdCliente
            // 
            txt_IdCliente.Font = new Font("Arial", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txt_IdCliente.Location = new Point(80, 76);
            txt_IdCliente.Name = "txt_IdCliente";
            txt_IdCliente.Size = new Size(40, 21);
            txt_IdCliente.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 75);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 2;
            label4.Text = "&Cliente";
            // 
            // txt_Usuario
            // 
            txt_Usuario.Font = new Font("Arial", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txt_Usuario.Location = new Point(83, 32);
            txt_Usuario.Name = "txt_Usuario";
            txt_Usuario.ReadOnly = true;
            txt_Usuario.Size = new Size(257, 21);
            txt_Usuario.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 35);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 0;
            label3.Text = "Usuario";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(335, 9);
            label1.Name = "label1";
            label1.Size = new Size(242, 40);
            label1.TabIndex = 2;
            label1.Text = "NOVO PEDIDO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(676, 30);
            label2.Name = "label2";
            label2.Size = new Size(67, 19);
            label2.TabIndex = 3;
            label2.Text = "Número";
            // 
            // txt_IdPedido
            // 
            txt_IdPedido.BackColor = Color.White;
            txt_IdPedido.Font = new Font("Arial", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txt_IdPedido.ForeColor = Color.Red;
            txt_IdPedido.Location = new Point(749, 27);
            txt_IdPedido.Name = "txt_IdPedido";
            txt_IdPedido.Size = new Size(100, 26);
            txt_IdPedido.TabIndex = 4;
            // 
            // txt_SubTotal
            // 
            txt_SubTotal.Location = new Point(760, 263);
            txt_SubTotal.Name = "txt_SubTotal";
            txt_SubTotal.ReadOnly = true;
            txt_SubTotal.Size = new Size(100, 23);
            txt_SubTotal.TabIndex = 5;
            // 
            // txt_DescontoItens
            // 
            txt_DescontoItens.Location = new Point(760, 302);
            txt_DescontoItens.Name = "txt_DescontoItens";
            txt_DescontoItens.ReadOnly = true;
            txt_DescontoItens.Size = new Size(100, 23);
            txt_DescontoItens.TabIndex = 5;
            // 
            // txt_DescontoPedido
            // 
            txt_DescontoPedido.Location = new Point(760, 341);
            txt_DescontoPedido.Name = "txt_DescontoPedido";
            txt_DescontoPedido.Size = new Size(100, 23);
            txt_DescontoPedido.TabIndex = 5;
            // 
            // txt_Total
            // 
            txt_Total.Location = new Point(760, 380);
            txt_Total.Name = "txt_Total";
            txt_Total.ReadOnly = true;
            txt_Total.Size = new Size(100, 23);
            txt_Total.TabIndex = 5;
            // 
            // btn_Fechar
            // 
            btn_Fechar.Location = new Point(774, 419);
            btn_Fechar.Name = "btn_Fechar";
            btn_Fechar.Size = new Size(75, 29);
            btn_Fechar.TabIndex = 6;
            btn_Fechar.Text = "&Fechar";
            btn_Fechar.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label11.Location = new Point(687, 266);
            label11.Name = "label11";
            label11.Size = new Size(59, 15);
            label11.TabIndex = 7;
            label11.Text = "Sub Total";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label12.Location = new Point(646, 304);
            label12.Name = "label12";
            label12.Size = new Size(108, 15);
            label12.TabIndex = 7;
            label12.Text = "Desconto Itens R$";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Arial", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label13.Location = new Point(676, 344);
            label13.Name = "label13";
            label13.Size = new Size(78, 15);
            label13.TabIndex = 7;
            label13.Text = "Desconto R$";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Arial", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label14.Location = new Point(699, 383);
            label14.Name = "label14";
            label14.Size = new Size(55, 15);
            label14.TabIndex = 7;
            label14.Text = " Total R$";
            // 
            // FrmPedidoNovo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(871, 517);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(btn_Fechar);
            Controls.Add(txt_Total);
            Controls.Add(txt_DescontoPedido);
            Controls.Add(txt_DescontoItens);
            Controls.Add(txt_SubTotal);
            Controls.Add(txt_IdPedido);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(grb_Identificacao);
            Controls.Add(grb_Itens);
            Name = "FrmPedidoNovo";
            Text = "FrmPedidoNovo";
            Load += FrmPedidoNovo_Load;
            grb_Itens.ResumeLayout(false);
            grb_Itens.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_ItensPedido).EndInit();
            grb_Identificacao.ResumeLayout(false);
            grb_Identificacao.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grb_Itens;
        private GroupBox grb_Identificacao;
        private Label label1;
        private Label label2;
        private TextBox txt_IdPedido;
        private TextBox txt_Usuario;
        private Label label3;
        private Label label4;
        private DataGridView dgv_ItensPedido;
        private TextBox txt_Cliente;
        private TextBox txt_IdCliente;
        private Label label5;
        private TextBox txt_Desconto;
        private TextBox txt_Quantidade;
        private TextBox txt_ValorUnit;
        private TextBox txt_CodBar;
        private TextBox txt_Descricao;
        private Button btn_AddItem;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Button btn_Insere;
        private Label label10;
        private TextBox txt_ValorTotal;
        private TextBox txt_SubTotal;
        private TextBox txt_DescontoItens;
        private TextBox txt_DescontoPedido;
        private TextBox txt_Total;
        private Button btn_Fechar;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private DataGridViewTextBoxColumn clnSeq;
        private DataGridViewTextBoxColumn clnCodBar;
        private DataGridViewTextBoxColumn clnDescricao;
        private DataGridViewTextBoxColumn clnValorUnit;
        private DataGridViewTextBoxColumn clnQuantidade;
        private DataGridViewTextBoxColumn clnDescontoItem;
        private DataGridViewTextBoxColumn clnTotalItem;
    }
}
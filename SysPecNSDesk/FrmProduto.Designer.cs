namespace SysPecNSDesk
{
    partial class FrmProduto
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
            gpb_Produtos = new GroupBox();
            btn_Consultar = new Button();
            btn_Editar = new Button();
            btn_Adicionar = new Button();
            cmb_Categoria = new ComboBox();
            np_EstoqueMinimo = new NumericUpDown();
            txt_CodBar = new TextBox();
            txt_ValorUnit = new TextBox();
            txt_UnidadeVenda = new TextBox();
            txt_Desconto = new TextBox();
            txt_Descricao = new TextBox();
            label7 = new Label();
            label6 = new Label();
            lbl_Categoria = new Label();
            label4 = new Label();
            lbl_UnidadeVenda = new Label();
            lbl_ValorUnit = new Label();
            lbl_CodBar = new Label();
            txt_Id = new TextBox();
            lbl_ID = new Label();
            lbl_Produtos = new Label();
            dgvProdutos = new DataGridView();
            clnid = new DataGridViewTextBoxColumn();
            clnCodigo = new DataGridViewTextBoxColumn();
            clnDescricao = new DataGridViewTextBoxColumn();
            clnValorUnit = new DataGridViewTextBoxColumn();
            clnEstoqueMin = new DataGridViewTextBoxColumn();
            clnDesconto = new DataGridViewTextBoxColumn();
            clnDataCad = new DataGridViewTextBoxColumn();
            clnValorUnic = new DataGridViewTextBoxColumn();
            clnUnidadeVenda = new DataGridViewTextBoxColumn();
            gpb_Produtos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)np_EstoqueMinimo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).BeginInit();
            SuspendLayout();
            // 
            // gpb_Produtos
            // 
            gpb_Produtos.BackColor = Color.Aqua;
            gpb_Produtos.Controls.Add(btn_Consultar);
            gpb_Produtos.Controls.Add(btn_Editar);
            gpb_Produtos.Controls.Add(btn_Adicionar);
            gpb_Produtos.Controls.Add(cmb_Categoria);
            gpb_Produtos.Controls.Add(np_EstoqueMinimo);
            gpb_Produtos.Controls.Add(txt_CodBar);
            gpb_Produtos.Controls.Add(txt_ValorUnit);
            gpb_Produtos.Controls.Add(txt_UnidadeVenda);
            gpb_Produtos.Controls.Add(txt_Desconto);
            gpb_Produtos.Controls.Add(txt_Descricao);
            gpb_Produtos.Controls.Add(label7);
            gpb_Produtos.Controls.Add(label6);
            gpb_Produtos.Controls.Add(lbl_Categoria);
            gpb_Produtos.Controls.Add(label4);
            gpb_Produtos.Controls.Add(lbl_UnidadeVenda);
            gpb_Produtos.Controls.Add(lbl_ValorUnit);
            gpb_Produtos.Controls.Add(lbl_CodBar);
            gpb_Produtos.Controls.Add(txt_Id);
            gpb_Produtos.Controls.Add(lbl_ID);
            gpb_Produtos.Location = new Point(82, 46);
            gpb_Produtos.Name = "gpb_Produtos";
            gpb_Produtos.Size = new Size(646, 289);
            gpb_Produtos.TabIndex = 0;
            gpb_Produtos.TabStop = false;
            gpb_Produtos.Text = "Produtos";
            // 
            // btn_Consultar
            // 
            btn_Consultar.Cursor = Cursors.Hand;
            btn_Consultar.Location = new Point(479, 214);
            btn_Consultar.Name = "btn_Consultar";
            btn_Consultar.Size = new Size(75, 23);
            btn_Consultar.TabIndex = 20;
            btn_Consultar.Text = "&Consultar";
            btn_Consultar.UseVisualStyleBackColor = true;
            btn_Consultar.Click += btn_Consultar_Click;
            // 
            // btn_Editar
            // 
            btn_Editar.Cursor = Cursors.Hand;
            btn_Editar.Enabled = false;
            btn_Editar.Location = new Point(378, 214);
            btn_Editar.Name = "btn_Editar";
            btn_Editar.Size = new Size(75, 23);
            btn_Editar.TabIndex = 19;
            btn_Editar.Text = "&Editar";
            btn_Editar.UseVisualStyleBackColor = true;
            btn_Editar.Click += btn_Editar_Click;
            // 
            // btn_Adicionar
            // 
            btn_Adicionar.Cursor = Cursors.Hand;
            btn_Adicionar.Location = new Point(270, 214);
            btn_Adicionar.Name = "btn_Adicionar";
            btn_Adicionar.Size = new Size(75, 23);
            btn_Adicionar.TabIndex = 18;
            btn_Adicionar.Text = "&Adicionar";
            btn_Adicionar.UseVisualStyleBackColor = true;
            btn_Adicionar.Click += btn_Adicionar_Click;
            // 
            // cmb_Categoria
            // 
            cmb_Categoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_Categoria.FormattingEnabled = true;
            cmb_Categoria.Location = new Point(138, 161);
            cmb_Categoria.Name = "cmb_Categoria";
            cmb_Categoria.Size = new Size(315, 23);
            cmb_Categoria.TabIndex = 17;
            cmb_Categoria.SelectedIndexChanged += cmb_Categoria_SelectedIndexChanged;
            // 
            // np_EstoqueMinimo
            // 
            np_EstoqueMinimo.Location = new Point(385, 109);
            np_EstoqueMinimo.Name = "np_EstoqueMinimo";
            np_EstoqueMinimo.Size = new Size(34, 23);
            np_EstoqueMinimo.TabIndex = 16;
            // 
            // txt_CodBar
            // 
            txt_CodBar.Location = new Point(197, 60);
            txt_CodBar.Name = "txt_CodBar";
            txt_CodBar.Size = new Size(117, 23);
            txt_CodBar.TabIndex = 15;
            // 
            // txt_ValorUnit
            // 
            txt_ValorUnit.Location = new Point(138, 109);
            txt_ValorUnit.Name = "txt_ValorUnit";
            txt_ValorUnit.Size = new Size(120, 23);
            txt_ValorUnit.TabIndex = 14;
            // 
            // txt_UnidadeVenda
            // 
            txt_UnidadeVenda.Location = new Point(264, 109);
            txt_UnidadeVenda.Name = "txt_UnidadeVenda";
            txt_UnidadeVenda.Size = new Size(100, 23);
            txt_UnidadeVenda.TabIndex = 13;
            // 
            // txt_Desconto
            // 
            txt_Desconto.Location = new Point(138, 214);
            txt_Desconto.Name = "txt_Desconto";
            txt_Desconto.Size = new Size(100, 23);
            txt_Desconto.TabIndex = 11;
            // 
            // txt_Descricao
            // 
            txt_Descricao.Location = new Point(320, 60);
            txt_Descricao.Name = "txt_Descricao";
            txt_Descricao.Size = new Size(176, 23);
            txt_Descricao.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(385, 91);
            label7.Name = "label7";
            label7.Size = new Size(94, 15);
            label7.TabIndex = 8;
            label7.Text = "Estoque Mínimo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(138, 196);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 7;
            label6.Text = "Desconto";
            // 
            // lbl_Categoria
            // 
            lbl_Categoria.AutoSize = true;
            lbl_Categoria.Location = new Point(138, 143);
            lbl_Categoria.Name = "lbl_Categoria";
            lbl_Categoria.Size = new Size(58, 15);
            lbl_Categoria.TabIndex = 6;
            lbl_Categoria.Text = "Categoria";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(320, 42);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 5;
            label4.Text = "Descrição";
            // 
            // lbl_UnidadeVenda
            // 
            lbl_UnidadeVenda.AutoSize = true;
            lbl_UnidadeVenda.Location = new Point(264, 90);
            lbl_UnidadeVenda.Name = "lbl_UnidadeVenda";
            lbl_UnidadeVenda.Size = new Size(102, 15);
            lbl_UnidadeVenda.TabIndex = 4;
            lbl_UnidadeVenda.Text = "Unidade de Venda";
            // 
            // lbl_ValorUnit
            // 
            lbl_ValorUnit.AutoSize = true;
            lbl_ValorUnit.Location = new Point(138, 90);
            lbl_ValorUnit.Name = "lbl_ValorUnit";
            lbl_ValorUnit.Size = new Size(78, 15);
            lbl_ValorUnit.TabIndex = 3;
            lbl_ValorUnit.Text = "Valor Unitário";
            // 
            // lbl_CodBar
            // 
            lbl_CodBar.AutoSize = true;
            lbl_CodBar.Location = new Point(197, 41);
            lbl_CodBar.Name = "lbl_CodBar";
            lbl_CodBar.Size = new Size(97, 15);
            lbl_CodBar.TabIndex = 2;
            lbl_CodBar.Text = "Código de barras";
            // 
            // txt_Id
            // 
            txt_Id.Location = new Point(138, 60);
            txt_Id.Name = "txt_Id";
            txt_Id.Size = new Size(50, 23);
            txt_Id.TabIndex = 1;
            // 
            // lbl_ID
            // 
            lbl_ID.AutoSize = true;
            lbl_ID.Location = new Point(138, 42);
            lbl_ID.Name = "lbl_ID";
            lbl_ID.Size = new Size(18, 15);
            lbl_ID.TabIndex = 0;
            lbl_ID.Text = "ID";
            // 
            // lbl_Produtos
            // 
            lbl_Produtos.AutoSize = true;
            lbl_Produtos.Font = new Font("Gill Sans Ultra Bold", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Produtos.ForeColor = SystemColors.ControlText;
            lbl_Produtos.Location = new Point(274, 9);
            lbl_Produtos.Name = "lbl_Produtos";
            lbl_Produtos.Size = new Size(210, 42);
            lbl_Produtos.TabIndex = 1;
            lbl_Produtos.Text = "PRODUTOS";
            // 
            // dgvProdutos
            // 
            dgvProdutos.AllowUserToAddRows = false;
            dgvProdutos.AllowUserToDeleteRows = false;
            dgvProdutos.BackgroundColor = Color.White;
            dgvProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProdutos.Columns.AddRange(new DataGridViewColumn[] { clnid, clnCodigo, clnDescricao, clnValorUnit, clnEstoqueMin, clnDesconto, clnDataCad, clnValorUnic, clnUnidadeVenda });
            dgvProdutos.GridColor = Color.White;
            dgvProdutos.Location = new Point(106, 341);
            dgvProdutos.Name = "dgvProdutos";
            dgvProdutos.ReadOnly = true;
            dgvProdutos.RowHeadersVisible = false;
            dgvProdutos.Size = new Size(646, 256);
            dgvProdutos.TabIndex = 2;
            dgvProdutos.CellContentClick += dataGridView1_CellContentClick;
            // 
            // clnid
            // 
            clnid.HeaderText = "ID";
            clnid.Name = "clnid";
            clnid.ReadOnly = true;
            clnid.Width = 40;
            // 
            // clnCodigo
            // 
            clnCodigo.HeaderText = "Código de Barras";
            clnCodigo.Name = "clnCodigo";
            clnCodigo.ReadOnly = true;
            clnCodigo.Width = 122;
            // 
            // clnDescricao
            // 
            clnDescricao.HeaderText = "Descrição";
            clnDescricao.Name = "clnDescricao";
            clnDescricao.ReadOnly = true;
            clnDescricao.Width = 70;
            // 
            // clnValorUnit
            // 
            clnValorUnit.HeaderText = "Valor Unitarios";
            clnValorUnit.Name = "clnValorUnit";
            clnValorUnit.ReadOnly = true;
            clnValorUnit.Width = 110;
            // 
            // clnEstoqueMin
            // 
            clnEstoqueMin.HeaderText = "Estoque Minimo";
            clnEstoqueMin.Name = "clnEstoqueMin";
            clnEstoqueMin.ReadOnly = true;
            clnEstoqueMin.Width = 120;
            // 
            // clnDesconto
            // 
            clnDesconto.HeaderText = "Desconto";
            clnDesconto.Name = "clnDesconto";
            clnDesconto.ReadOnly = true;
            clnDesconto.Width = 70;
            // 
            // clnDataCad
            // 
            clnDataCad.HeaderText = "Data Cadastro";
            clnDataCad.Name = "clnDataCad";
            clnDataCad.ReadOnly = true;
            clnDataCad.Width = 110;
            // 
            // clnValorUnic
            // 
            clnValorUnic.HeaderText = "Valor Unico";
            clnValorUnic.Name = "clnValorUnic";
            clnValorUnic.ReadOnly = true;
            // 
            // clnUnidadeVenda
            // 
            clnUnidadeVenda.HeaderText = "Unidade Venda";
            clnUnidadeVenda.Name = "clnUnidadeVenda";
            clnUnidadeVenda.ReadOnly = true;
            clnUnidadeVenda.Width = 120;
            // 
            // FrmProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cyan;
            ClientSize = new Size(800, 598);
            Controls.Add(dgvProdutos);
            Controls.Add(lbl_Produtos);
            Controls.Add(gpb_Produtos);
            Name = "FrmProduto";
            Text = "FrmProduto";
            Load += FrmProduto_Load;
            gpb_Produtos.ResumeLayout(false);
            gpb_Produtos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)np_EstoqueMinimo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gpb_Produtos;
        private Label lbl_Produtos;
        private Label label6;
        private Label lbl_Categoria;
        private Label label4;
        private Label lbl_UnidadeVenda;
        private Label lbl_ValorUnit;
        private Label lbl_CodBar;
        private TextBox txt_Id;
        private Label lbl_ID;
        private TextBox txt_CodBar;
        private TextBox txt_ValorUnit;
        private TextBox txt_UnidadeVenda;
        private TextBox textBox4;
        private TextBox txt_Desconto;
        private TextBox txt_Categoria;
        private TextBox txt_Descricao;
        private Label label7;
        private NumericUpDown np_EstoqueMinimo;
        private ComboBox cmb_Categoria;
        private Button btn_Consultar;
        private Button btn_Editar;
        private Button btn_Adicionar;
        private DataGridView dgvProdutos;
        private DataGridViewTextBoxColumn clnid;
        private DataGridViewTextBoxColumn clnCodigo;
        private DataGridViewTextBoxColumn clnDescricao;
        private DataGridViewTextBoxColumn clnValorUnit;
        private DataGridViewTextBoxColumn clnEstoqueMin;
        private DataGridViewTextBoxColumn clnDesconto;
        private DataGridViewTextBoxColumn clnDataCad;
        private DataGridViewTextBoxColumn clnValorUnic;
        private DataGridViewTextBoxColumn clnUnidadeVenda;
    }
}
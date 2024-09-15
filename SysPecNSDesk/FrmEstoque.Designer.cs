namespace SysPecNSDesk
{
    partial class FrmEstoque
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
            label1 = new Label();
            label2 = new Label();
            txt_Produto_Id = new TextBox();
            label3 = new Label();
            txt_Quantidade = new TextBox();
            dataGridView1 = new DataGridView();
            cln_Id = new DataGridViewTextBoxColumn();
            cln_Quantidade = new DataGridViewTextBoxColumn();
            cln_Data_ultimo_movimento = new DataGridViewTextBoxColumn();
            label4 = new Label();
            Data_Movimento = new DateTimePicker();
            btn_Inserir = new Button();
            btn_Cancelar = new Button();
            btn_Editar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(201, 9);
            label1.Name = "label1";
            label1.Size = new Size(165, 40);
            label1.TabIndex = 0;
            label1.Text = "Estoque";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(80, 66);
            label2.Name = "label2";
            label2.Size = new Size(23, 17);
            label2.TabIndex = 1;
            label2.Text = "ID";
            // 
            // txt_Produto_Id
            // 
            txt_Produto_Id.Location = new Point(80, 83);
            txt_Produto_Id.Name = "txt_Produto_Id";
            txt_Produto_Id.ReadOnly = true;
            txt_Produto_Id.Size = new Size(54, 23);
            txt_Produto_Id.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(184, 63);
            label3.Name = "label3";
            label3.Size = new Size(83, 17);
            label3.TabIndex = 3;
            label3.Text = "Quantidade";
            // 
            // txt_Quantidade
            // 
            txt_Quantidade.Location = new Point(162, 83);
            txt_Quantidade.Name = "txt_Quantidade";
            txt_Quantidade.Size = new Size(135, 23);
            txt_Quantidade.TabIndex = 4;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { cln_Id, cln_Quantidade, cln_Data_ultimo_movimento });
            dataGridView1.Location = new Point(61, 171);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(450, 170);
            dataGridView1.TabIndex = 5;
            // 
            // cln_Id
            // 
            cln_Id.Frozen = true;
            cln_Id.HeaderText = "ID";
            cln_Id.Name = "cln_Id";
            cln_Id.ReadOnly = true;
            // 
            // cln_Quantidade
            // 
            cln_Quantidade.Frozen = true;
            cln_Quantidade.HeaderText = "Quantidade";
            cln_Quantidade.Name = "cln_Quantidade";
            cln_Quantidade.ReadOnly = true;
            cln_Quantidade.Width = 170;
            // 
            // cln_Data_ultimo_movimento
            // 
            cln_Data_ultimo_movimento.Frozen = true;
            cln_Data_ultimo_movimento.HeaderText = "Data do ultimo movimento";
            cln_Data_ultimo_movimento.Name = "cln_Data_ultimo_movimento";
            cln_Data_ultimo_movimento.ReadOnly = true;
            cln_Data_ultimo_movimento.Width = 175;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(315, 49);
            label4.Name = "label4";
            label4.Size = new Size(179, 34);
            label4.TabIndex = 6;
            label4.Text = "\r\nData do ultimo movimento\r\n";
            // 
            // Data_Movimento
            // 
            Data_Movimento.Location = new Point(315, 83);
            Data_Movimento.Name = "Data_Movimento";
            Data_Movimento.Size = new Size(170, 23);
            Data_Movimento.TabIndex = 7;
            // 
            // btn_Inserir
            // 
            btn_Inserir.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Inserir.Location = new Point(241, 127);
            btn_Inserir.Name = "btn_Inserir";
            btn_Inserir.Size = new Size(75, 23);
            btn_Inserir.TabIndex = 8;
            btn_Inserir.Text = "Inserir";
            btn_Inserir.UseVisualStyleBackColor = true;
            btn_Inserir.Click += btn_Inserir_Click;
            // 
            // btn_Cancelar
            // 
            btn_Cancelar.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Cancelar.Location = new Point(427, 127);
            btn_Cancelar.Name = "btn_Cancelar";
            btn_Cancelar.Size = new Size(75, 23);
            btn_Cancelar.TabIndex = 9;
            btn_Cancelar.Text = "&Cancelar";
            btn_Cancelar.UseVisualStyleBackColor = true;
            btn_Cancelar.Click += btn_Cancelar_Click;
            // 
            // btn_Editar
            // 
            btn_Editar.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Editar.Location = new Point(334, 127);
            btn_Editar.Name = "btn_Editar";
            btn_Editar.Size = new Size(75, 23);
            btn_Editar.TabIndex = 10;
            btn_Editar.Text = "&Editar";
            btn_Editar.UseVisualStyleBackColor = true;
            // 
            // FrmEstoque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(543, 344);
            Controls.Add(btn_Editar);
            Controls.Add(btn_Cancelar);
            Controls.Add(btn_Inserir);
            Controls.Add(Data_Movimento);
            Controls.Add(label4);
            Controls.Add(dataGridView1);
            Controls.Add(txt_Quantidade);
            Controls.Add(label3);
            Controls.Add(txt_Produto_Id);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmEstoque";
            Text = "FrmEstoque";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txt_Produto_Id;
        private Label label3;
        private TextBox txt_Quantidade;
        private DataGridView dataGridView1;
        private Label label4;
        private DateTimePicker Data_Movimento;
        private DataGridViewTextBoxColumn cln_Id;
        private DataGridViewTextBoxColumn cln_Quantidade;
        private DataGridViewTextBoxColumn cln_Data_ultimo_movimento;
        private Button btn_Inserir;
        private Button btn_Cancelar;
        private Button btn_Editar;
    }
}